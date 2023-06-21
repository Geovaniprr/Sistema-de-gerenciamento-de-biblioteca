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
    public partial class MinhaAreaAlunos : Form
    {
        private string connectionString = "Data Source=CAIO_WIN11\\SQLEXPRESS;Initial Catalog=Biblioteca;Integrated Security=True";
        DataTable table = new DataTable("table");
        public MinhaAreaAlunos()
        {
            InitializeComponent();
        }

        private void MinhaAreaAlunos_Load(object sender, EventArgs e)
        {
            // DataGridView Histórico de empréstimos
            dgvHistorico.AutoGenerateColumns = false;
            dgvHistorico.Columns.Add("ColidLivro", "ID Livro");
            dgvHistorico.Columns.Add("ColTitulo", "Título");
            dgvHistorico.Columns.Add("ColidEmprestimo", "ID Empréstimo");
            dgvHistorico.Columns.Add("ColDataEmprestimo", "Data Empréstimo");

            dgvHistorico.Columns["ColidLivro"].DataPropertyName = "id_livro";
            dgvHistorico.Columns["ColTitulo"].DataPropertyName = "titulo";
            dgvHistorico.Columns["ColidEmprestimo"].DataPropertyName = "id_emprestimo";
            dgvHistorico.Columns["ColDataEmprestimo"].DataPropertyName = "data_emprestimo";

            CarregarHistorico();

            // DataGridView Histórico de devoluções
            dgvDevolucoes.AutoGenerateColumns = false;
            dgvDevolucoes.Columns.Add("ColidLivro", "ID Livro");
            dgvDevolucoes.Columns.Add("ColTitulo", "Título");
            dgvDevolucoes.Columns.Add("ColidEmprestimo", "ID Empréstimo");
            dgvDevolucoes.Columns.Add("ColDataDevolucao", "Data Devolução");

            dgvDevolucoes.Columns["ColidLivro"].DataPropertyName = "id_livro";
            dgvDevolucoes.Columns["ColTitulo"].DataPropertyName = "titulo";
            dgvDevolucoes.Columns["ColidEmprestimo"].DataPropertyName = "id_emprestimo";
            dgvDevolucoes.Columns["ColDataDevolucao"].DataPropertyName = "data_devolucao";

            CarregarDevolucoes();
        }

        private void CarregarHistorico()
        {
            DataTable table = new DataTable();
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                try
                {
                    cn.Open();

                    // Consultar os empréstimos cadastrados no banco de dados com o título do livro
                    string query = "SELECT e.id_emprestimo, e.id_livro, l.titulo, e.data_emprestimo FROM emprestimos e INNER JOIN livros l ON e.id_livro = l.id_livro";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(table);

                    dgvHistorico.DataSource = table;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message);
                }
            }
        }

        private void CarregarDevolucoes()
        {
            DataTable table = new DataTable();
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                try
                {
                    cn.Open();

                    // Consultar as devoluções cadastradas no banco de dados com o título do livro
                    string query = "SELECT e.id_emprestimo, e.id_livro, l.titulo, e.data_devolucao FROM emprestimos e INNER JOIN livros l ON e.id_livro = l.id_livro";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(table);

                    dgvDevolucoes.DataSource = table;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message);
                }
            }
        }
        private void btnAcervo_Click(object sender, EventArgs e)
        {
            this.Close();
            BibliotecaAlunos bibliotecaAlunos = new BibliotecaAlunos();
            bibliotecaAlunos.Show();
        }

        private void btnMinhaArea_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }
    }
}