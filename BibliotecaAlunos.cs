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
    public partial class BibliotecaAlunos : Form
    {
        private string connectionString = "Data Source=CAIO_WIN11\\SQLEXPRESS;Initial Catalog=Biblioteca;Integrated Security=True";
        DataTable table = new DataTable("table");
        int idUsuarioLog = Login.idUsuarioLogado;
        public BibliotecaAlunos()
        {
            InitializeComponent();
        }


        private void btnAcervo_Click(object sender, EventArgs e)
        {

        }


        private void btnMinhaArea_Click(object sender, EventArgs e)
        {
            this.Close();
            MinhaAreaAlunos minhaAreaAlunos = new MinhaAreaAlunos();
            minhaAreaAlunos.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BibliotecaAlunos_Load(object sender, EventArgs e)
        {
            // Configurar as colunas do DataGridView
            dgvAcervo.AutoGenerateColumns = false;
            dgvAcervo.Columns.Add("ColTitulo", "Título");
            dgvAcervo.Columns.Add("ColAutor", "Autor");
            dgvAcervo.Columns.Add("ColEditora", "Editora");
            dgvAcervo.Columns.Add("ColAnoPublicacao", "Ano de Publicação");
            dgvAcervo.Columns.Add("ColCategoria", "Categoria");
            dgvAcervo.Columns.Add("ColQuantidade", "Quantidade de Exemplares");

            // Definir o nome da propriedade de dados para cada coluna
            dgvAcervo.Columns["ColTitulo"].DataPropertyName = "titulo";
            dgvAcervo.Columns["ColAutor"].DataPropertyName = "autor";
            dgvAcervo.Columns["ColEditora"].DataPropertyName = "editora";
            dgvAcervo.Columns["ColAnoPublicacao"].DataPropertyName = "ano_publicacao";
            dgvAcervo.Columns["ColCategoria"].DataPropertyName = "categoria";
            dgvAcervo.Columns["ColQuantidade"].DataPropertyName = "quantidade_estoque";
            CarregarLivros();
        }

        private void CarregarLivros()
        {
            DataTable table = new DataTable();
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                try
                {
                    cn.Open();

                    // Consultar os livros cadastrados no banco de dados
                    string query = "SELECT titulo, autor, editora, ano_publicacao, categoria, quantidade_estoque FROM livros";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(table);

                    dgvAcervo.DataSource = table;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message);
                }
            }

            // Exibir os dados no DataGridView
            dgvAcervo.DataSource = table;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Variável representa o livro que o usuário deseja pesquisar.
            string pesquisarLivro = txtProcurar.Text;

            //Aqui foi criada uma nova instância da classe DataTable chamada table.
            //Essa tabela será usada para armazenar os resultados da pesquisa feita pelo usuário.
            DataTable table = new DataTable();
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                try
                {
                    cn.Open();
                    //Esta linha define a consulta SQL Server que será executada no banco de dados Biblioteca.
                    //A consulta seleciona os campos titulo, autor, editora, ano_publicacao e categoria da tabela livros onde o título do livro corresponde à pesquisa do usuário e a quantidade em estoque é maior que zero.
                    string query = "SELECT titulo, autor, editora, ano_publicacao, categoria FROM livros WHERE (titulo LIKE @pesquisarLivro OR autor LIKE @pesquisarLivro OR editora LIKE @pesquisarLivro OR ano_publicação LIKE @pesquisarLivro OR categoria LIKE @pesquisarLivro) AND quantidade_estoque > 0";
                    using (SqlCommand cmd = new SqlCommand(query, cn))
                    {
                        //Esta linha adiciona um parâmetro à consulta SQL para substituir o valor da variável @pesquisarLivro.
                        //O operador % é usado para corresponder a qualquer sequência de caracteres antes e depois do texto pesquisado, permitindo pesquisas parciais pelo usuário.
                        cmd.Parameters.AddWithValue("@pesquisarLivro", "%" + pesquisarLivro + "%");
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(table);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao pesquisar no estoque: " + ex.Message);
                }
            }

            if (table.Rows.Count > 0)
            {
                dgvAcervo.DataSource = table;
            }
            else
            {
                MessageBox.Show("O livro que você deseja não se encontra em estoque no momento.");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtProcurar.Clear();

            dgvAcervo.DataSource = null;
            dgvAcervo.Rows.Clear();
        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            if (dgvAcervo.SelectedRows.Count > 0)
            {
                // Obtém os dados do livro selecionado
                string tituloLivro = dgvAcervo.SelectedRows[0].Cells["ColTitulo"].Value?.ToString() ?? string.Empty;
                string autorLivro = dgvAcervo.SelectedRows[0].Cells["ColAutor"].Value?.ToString() ?? string.Empty;
                string categoriaLivro = dgvAcervo.SelectedRows[0].Cells["ColCategoria"].Value?.ToString() ?? string.Empty;

                // Obtém o ID do livro
                int idLivro = ObterIdLivro(tituloLivro, autorLivro, categoriaLivro);

                // Verifica se foi encontrado um ID válido para o livro
                if (idLivro != -1)
                {
                    // Verifica se o usuário já possui um empréstimo do mesmo livro dentro do período de 30 dias
                    if (!VerificarEmprestimoExistente(idUsuarioLog, idLivro))
                    {
                        // Obtém a data atual
                        DateTime dataAtual = DateTime.Now;

                        // Obtém a data de devolução (acrescenta 30 dias à data atual)
                        DateTime dataDevolucao = dataAtual.AddDays(30);

                        // Insere o empréstimo na tabela "emprestimo"
                        if (InserirEmprestimo(idUsuarioLog, idLivro, dataAtual, dataDevolucao))
                        {
                            MessageBox.Show("Livro reservado com sucesso!");
                            AtualizarDataGridView();
                        }
                        else
                        {
                            MessageBox.Show("Erro ao reservar o livro. Tente novamente.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Você já possui um empréstimo do mesmo livro dentro do período de 30 dias.");
                    }
                }
                else
                {
                    MessageBox.Show("Erro ao obter o ID do livro. Tente novamente.");
                }
            }
            else
            {
                MessageBox.Show("Selecione um livro para reservar.");
            }
        }

        private bool VerificarEmprestimoExistente(int idUsuario, int idLivro)
        {
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                try
                {
                    cn.Open();

                    // Obtém a data atual
                    DateTime dataAtual = DateTime.Now;

                    // Calcula a data de 30 dias atrás a partir da data atual
                    DateTime dataLimite = dataAtual.AddDays(-30);

                    // Verifica se existe algum empréstimo do mesmo id_usuario e id_livro dentro do período de 30 dias
                    string query = "SELECT COUNT(*) FROM emprestimos WHERE id_usuario = @idUsuario AND id_livro = @idLivro AND data_emprestimo >= @dataLimite";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
                    cmd.Parameters.AddWithValue("@idLivro", idLivro);
                    cmd.Parameters.AddWithValue("@dataLimite", dataLimite);
                    int count = (int)cmd.ExecuteScalar();

                    return count > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message);
                    return false;
                }
            }
        }
        private bool InserirEmprestimo(int idUsuario, int idLivro, DateTime dataEmprestimo, DateTime dataDevolucao)
        {
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                try
                {
                    cn.Open();
                    string query = "INSERT INTO emprestimos (id_usuario, id_livro, data_emprestimo, data_devolucao) VALUES (@idUsuario, @idLivro, @dataEmprestimo, @dataDevolucao)";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
                    cmd.Parameters.AddWithValue("@idLivro", idLivro);
                    cmd.Parameters.AddWithValue("@dataEmprestimo", dataEmprestimo);
                    cmd.Parameters.AddWithValue("@dataDevolucao", dataDevolucao);
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

        private int ObterIdLivro(string titulo, string autor, string categoria)
        {
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                try
                {
                    cn.Open();
                    string query = "SELECT id_livro FROM livros WHERE titulo = @titulo AND autor = @autor AND categoria = @categoria";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@titulo", titulo);
                    cmd.Parameters.AddWithValue("@autor", autor);
                    cmd.Parameters.AddWithValue("@categoria", categoria);
                    int idLivro = (int)cmd.ExecuteScalar();
                    return idLivro;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message);
                    return -1;
                }
            }
        }
        private void AtualizarDataGridView()
        {
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                try
                {
                    cn.Open();
                    string query = "SELECT * FROM livros";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvAcervo.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message);
                }
            }
        }
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}