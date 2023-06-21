using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;

namespace Biblioteca_01.Apresentacao
{
    public partial class CadLivro : Form
    {
        private string connectionString = "Data Source=CAIO_WIN11\\SQLEXPRESS;Initial Catalog=Biblioteca;Integrated Security=True";
        DataTable table = new DataTable("table");
        public CadLivro()
        {
            InitializeComponent();
        }
        private void CadLivro_Load(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                // Configure o DataGridView
                dgvCadLivro.AutoGenerateColumns = false;
                CarregarLivros();

                // Configurar as colunas do DataGridView
                dgvCadLivro.AutoGenerateColumns = false;
                dgvCadLivro.Columns.Add("ColTitulo", "Título");
                dgvCadLivro.Columns.Add("ColAutor", "Autor");
                dgvCadLivro.Columns.Add("ColEditora", "Editora");
                dgvCadLivro.Columns.Add("ColAnoPublicacao", "Ano de Publicação");
                dgvCadLivro.Columns.Add("ColCategoria", "Categoria");
                dgvCadLivro.Columns.Add("ColQuantidade", "Quantidade de Exemplares");

                // Definir o nome da propriedade de dados para cada coluna
                dgvCadLivro.Columns["ColTitulo"].DataPropertyName = "titulo";
                dgvCadLivro.Columns["ColAutor"].DataPropertyName = "autor";
                dgvCadLivro.Columns["ColEditora"].DataPropertyName = "editora";
                dgvCadLivro.Columns["ColAnoPublicacao"].DataPropertyName = "ano_publicacao";
                dgvCadLivro.Columns["ColCategoria"].DataPropertyName = "categoria";
                dgvCadLivro.Columns["ColQuantidade"].DataPropertyName = "quantidade_estoque";
            }
        }
        private void CarregarLivros()
        {
            using (SqlConnection cn = new SqlConnection(connectionString))
                try
                {
                    cn.Open();
                    // Consultar os livros cadastrados
                    string query = "SELECT * FROM livros";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Exibir os dados no DataGridView
                    dgvCadLivro.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message);
                }
                finally
                {
                    cn.Close();
                }
        }


        private void btnAcervo_Click(object sender, EventArgs e)
        {
            this.Close();
            Biblioteca biblioteca = new Biblioteca();
            biblioteca.Show();
        }

        private void btnMinhaArea_Click(object sender, EventArgs e)
        {
            this.Close();
            MinhaArea minhaArea = new MinhaArea();
            minhaArea.Show();
        }

        private void btnCadLivro_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            // Obter os valores dos campos do formulário
            string titulo = txtTitulo.Text;
            string autor = txtAutor.Text;
            string editora = txtEditora.Text;
            int anoPublicacao;
            if (!int.TryParse(txtAnoPubli.Text, out anoPublicacao))
            {
                MessageBox.Show("Ano de publicação inválido. Insira um valor numérico de 4 dígitos.");
                return;
            }
            string categoria = txtCategoria.Text;
            int quantidadeExemplares;
            if (!int.TryParse(txtQtdEstoque.Text, out quantidadeExemplares))
            {
                MessageBox.Show("Quantidade de exemplares inválida. Insira um valor numérico válido.");
                return;
            }

            // Verificar se todos os campos foram preenchidos
            if (string.IsNullOrWhiteSpace(titulo) || string.IsNullOrWhiteSpace(autor) ||
                string.IsNullOrWhiteSpace(editora) || string.IsNullOrWhiteSpace(txtAnoPubli.Text) ||
                string.IsNullOrWhiteSpace(categoria) || string.IsNullOrWhiteSpace(txtQtdEstoque.Text))
            {
                MessageBox.Show("Preencha todos os campos corretamente.");
                return;
            }

            // Inserir o novo livro no banco de dados
            if (InserirLivro(titulo, autor, editora, anoPublicacao, categoria, quantidadeExemplares))
            {
                MessageBox.Show("Cadastro de livro realizado com sucesso!");
                LimparCampos();
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar o livro. Verifique os dados e tente novamente.");
            }
        }

        private bool InserirLivro(string titulo, string autor, string editora, int anoPublicacao, string categoria, int quantidadeExemplares)
        {
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                try
                {
                    cn.Open();

                    // Inserir o novo livro na tabela 'livros'
                    string query = "INSERT INTO livros (titulo, autor, editora, ano_publicacao, categoria, quantidade_estoque) " +
                        "VALUES (@titulo, @autor, @editora, @anoPublicacao, @categoria, @quantidade_estoque)";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@titulo", titulo);
                    cmd.Parameters.AddWithValue("@autor", autor);
                    cmd.Parameters.AddWithValue("@editora", editora);
                    cmd.Parameters.AddWithValue("@anoPublicacao", anoPublicacao);
                    cmd.Parameters.AddWithValue("@categoria", categoria);
                    cmd.Parameters.AddWithValue("@quantidade_estoque", quantidadeExemplares);
                    cmd.ExecuteNonQuery();

                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message);
                    return false;
                }
            }
        }


        private void LimparCampos()
        {
            // Limpar os campos do formulário
            txtTitulo.Clear();
            txtAutor.Clear();
            txtEditora.Clear();
            txtAnoPubli.Clear();
            txtCategoria.Clear();
            txtQtdEstoque.Clear();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvCadLivro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvCadLivro.Rows.Add(txtTitulo.Text, txtAutor.Text, txtEditora.Text, txtAnoPubli.Text, txtCategoria.Text);
        }

    }
}