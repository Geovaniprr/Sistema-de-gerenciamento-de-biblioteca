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


namespace Biblioteca_01.Apresentacao
{
    public partial class Cadastro : Form
    {
        private string connectionString = "Data Source=CAIO_WIN11\\SQLEXPRESS;Initial Catalog=Biblioteca;Integrated Security=True";

        public Cadastro()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string matricula = txtMatricula.Text;
            string usuario = txtUsuario.Text;
            string endereco = txtEndereco.Text;
            string perfil = txtPerfil.Text;
            string telefone = txtTel.Text;
            string senha = txtSenha.Text;
            string confirmacaoSenha = txtConfSenha.Text;

            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(matricula) || string.IsNullOrWhiteSpace(usuario) ||
                string.IsNullOrWhiteSpace(endereco) || string.IsNullOrWhiteSpace(perfil) ||
                string.IsNullOrWhiteSpace(telefone) || string.IsNullOrWhiteSpace(senha) ||
                string.IsNullOrWhiteSpace(confirmacaoSenha))
            {
                MessageBox.Show("Preencha todos os campos corretamente.");
                return;
            }

            if (senha != confirmacaoSenha)
            {
                MessageBox.Show("A senha e a confirmação de senha não correspondem.");
                return;
            }

            int perfilValue;
            if (txtPerfil.Text == "123")
            {
                perfilValue = 123;
            }
            else if (txtPerfil.Text == "1234")
            {
                perfilValue = 1234;
            }
            else
            {
                MessageBox.Show("Preencha o campo Perfil corretamente.");
                return;
            }

            if (InserirUsuario(nome, matricula, usuario, endereco, perfil, telefone, senha))
            {
                MessageBox.Show("Cadastro realizado com sucesso. Retorne para a tela de login.");

                LimparCampos();
                Login login = new Login();
                login.Show();
                this.Close();
            }
        }

        private bool InserirUsuario(string nome, string matricula, string usuario, string endereco, string perfil, string telefone, string senha)
        {
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                try
                {
                    cn.Open();

                    string query = "INSERT INTO usuarios (nome, matricula, usuario, endereco, perfil, telefone, senha) " +
                        "VALUES (@nome, @matricula, @usuario, @endereco, @perfil, @telefone, @senha)";

                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@matricula", matricula);
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    cmd.Parameters.AddWithValue("@endereco", endereco);
                    cmd.Parameters.AddWithValue("@perfil", perfil);
                    cmd.Parameters.AddWithValue("@telefone", telefone);
                    cmd.Parameters.AddWithValue("@senha", senha);

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
            txtNome.Text = string.Empty;
            txtMatricula.Text = string.Empty;
            txtUsuario.Text = string.Empty;
            txtEndereco.Text = string.Empty;
            txtPerfil.Text = string.Empty;
            txtTel.Text = string.Empty;
            txtSenha.Text = string.Empty;
            txtConfSenha.Text = string.Empty;
        }

        private void chkMosSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMosSenha.Checked)
            {
                txtSenha.PasswordChar = '\0';
                txtConfSenha.PasswordChar = '\0';
            }
            else
            {
                txtSenha.PasswordChar = '*';
                txtConfSenha.PasswordChar = '*';
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {

        }
    }
}

