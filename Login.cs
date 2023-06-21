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
    public partial class Login : Form
    {
        private string connectionString = "Data Source=CAIO_WIN11\\SQLEXPRESS;Initial Catalog=Biblioteca;Integrated Security=True";
        public static int idUsuarioLogado;

        public Login()
        {
            InitializeComponent();
            btnEntrar.Click += btnEntrar_Click;
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click([AllowNull] object sender, EventArgs e)
        {
            // Variáveis sendo inicializadas com os valores dos campos correspondentes no formulário.
            string usuario = txtUsuario.Text;
            string matricula = txtMatricula.Text;
            string senha = txtSenha.Text;
            //Aqui é feita uma verificação para assegurar que todos os campos tenham sido preenchidos
            //Se algum deles estiver vazio ou conter espaços em branco, uma mensagem de erro é exibida
            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(matricula) || string.IsNullOrWhiteSpace(senha))
            {
                MessageBox.Show("Preencha todos os campos corretamente.");
            }
            //Caso contrário, os dados são verificados e é chamado o método ValidarCredenciais, que passa as informações de usuário, matrícula e senha como parâmetros.
            //Esse método realiza uma consulta no banco de dados para verificar se as credenciais são válidas
            //Se as credenciais forem válidas, o próximo passo é obter o id_perfil do usuário chamando o método ObterIdPerfil e
            //passando o nome de usuário como parâmetro. Esse método também faz uma consulta no banco de dados para recuperar
            //o valor do campo id_perfil correspondente ao usuário.
            else
            {
                if (ValidarCredenciais(usuario, matricula, senha))
                {
                    int perfil = ObterPerfil(usuario);
                    if (perfil == 123)
                    {
                        idUsuarioLogado = ObterIdUsuario(usuario);
                        MessageBox.Show("Login bem-sucedido! Bem-vindo a Biblioteca administrador.");
                        AbreBibliotecaAdm();
                    }
                    else if (perfil == 1234)
                    {
                        idUsuarioLogado = ObterIdUsuario(usuario);
                        MessageBox.Show("Login bem-sucedido! Bem-vindo, Aluno.");
                        AbreBibliotecaAluno();
                    }
                    else
                    {
                        MessageBox.Show("O usuário não tem permissão para acessar.");
                    }

                    LimparCampos();
                }
                else
                {
                    MessageBox.Show("Os dados inseridos não correspondem. Verifique se você colocou os dados corretamente e tente novamente!");
                }
            }
        }

        private bool ValidarCredenciais(string usuario, string matricula, string senha)
        {
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                try
                {
                    cn.Open();
                    string query = "SELECT COUNT(*) FROM usuarios WHERE usuario = @usuario AND matricula = @matricula AND senha = @senha";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    cmd.Parameters.AddWithValue("@matricula", matricula);
                    cmd.Parameters.AddWithValue("@senha", senha);
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

        private int ObterPerfil(string usuario)
        {
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                try
                {
                    cn.Open();
                    string query = "SELECT perfil FROM usuarios WHERE usuario = @usuario";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    int perfil = (int)cmd.ExecuteScalar();
                    return perfil;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message);
                    return -1;
                }
            }
        }

        private void AbreBibliotecaAdm()
        {
            // Lógica para abrir a biblioteca do Adm
            Biblioteca biblioteca = new Biblioteca();
            biblioteca.Show();
            this.Hide();
        }

        private void AbreBibliotecaAluno()
        {
            // Lógica para abrir a biblioteca do aluno
            BibliotecaAlunos bibliotecaAluno = new BibliotecaAlunos();
            bibliotecaAluno.Show();
            this.Hide();
        }

        private void LimparCampos()
        {
            // Os campos do formulário são limpos chamando o método LimparCampos,
            // para que o próximo usuário possa fazer login sem problemas
            txtUsuario.Clear();
            txtMatricula.Clear();
            txtSenha.Clear();
        }

        private void lblCadastrese_Click(object sender, EventArgs e)
        {
            Cadastro cadastro = new Cadastro();
            cadastro.Show();
            this.Hide();
        }


        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chkMosSenha_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkMosSenha.Checked)
            {
                txtSenha.PasswordChar = '\0';
            }
            else
            {
                txtSenha.PasswordChar = '*';
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private int ObterIdUsuario(string usuario)
        {
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                try
                {
                    cn.Open();
                    string query = "SELECT id_usuario FROM usuarios WHERE usuario = @usuario";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    int idUsuario = (int)cmd.ExecuteScalar();
                    return idUsuario;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message);
                    return -1;
                }
            }
        }
    }
}