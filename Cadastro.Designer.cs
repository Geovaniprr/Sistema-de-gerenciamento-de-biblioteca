namespace Biblioteca_01.Apresentacao
{
    partial class Cadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro));
            panel2 = new Panel();
            label1 = new Label();
            label = new Label();
            txtPerfil = new TextBox();
            txtTel = new TextBox();
            chkMosSenha = new CheckBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            btnLogin = new Button();
            btnSair = new Button();
            txtConfSenha = new TextBox();
            label7 = new Label();
            label6 = new Label();
            txtSenha = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtEndereco = new TextBox();
            txtMatricula = new TextBox();
            txtNome = new TextBox();
            label9 = new Label();
            txtUsuario = new TextBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(97, 120, 150);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(603, 66);
            panel2.TabIndex = 35;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Palatino Linotype", 23.28F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(168, 9);
            label1.Name = "label1";
            label1.Size = new Size(252, 44);
            label1.TabIndex = 19;
            label1.Text = "CADASTRE-SE";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label.Location = new Point(51, 302);
            label.Name = "label";
            label.Size = new Size(48, 20);
            label.TabIndex = 78;
            label.Text = "Perfil:";
            // 
            // txtPerfil
            // 
            txtPerfil.BackColor = SystemColors.Window;
            txtPerfil.BorderStyle = BorderStyle.None;
            txtPerfil.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtPerfil.Location = new Point(51, 325);
            txtPerfil.Multiline = true;
            txtPerfil.Name = "txtPerfil";
            txtPerfil.Size = new Size(208, 23);
            txtPerfil.TabIndex = 77;
            // 
            // txtTel
            // 
            txtTel.BackColor = SystemColors.Window;
            txtTel.BorderStyle = BorderStyle.None;
            txtTel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtTel.Location = new Point(348, 120);
            txtTel.Multiline = true;
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(208, 23);
            txtTel.TabIndex = 63;
            // 
            // chkMosSenha
            // 
            chkMosSenha.AutoSize = true;
            chkMosSenha.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            chkMosSenha.Location = new Point(455, 354);
            chkMosSenha.Name = "chkMosSenha";
            chkMosSenha.Size = new Size(100, 17);
            chkMosSenha.TabIndex = 76;
            chkMosSenha.Text = "Mostrar senha";
            chkMosSenha.UseVisualStyleBackColor = true;
            chkMosSenha.CheckedChanged += chkMosSenha_CheckedChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(462, 447);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(23, 28);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 75;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(119, 446);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 74;
            pictureBox1.TabStop = false;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.Location = new Point(347, 444);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(109, 34);
            btnLogin.TabIndex = 73;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnSair
            // 
            btnSair.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSair.Location = new Point(150, 444);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(109, 32);
            btnSair.TabIndex = 72;
            btnSair.Text = "SAIR";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // txtConfSenha
            // 
            txtConfSenha.BorderStyle = BorderStyle.None;
            txtConfSenha.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtConfSenha.Location = new Point(347, 325);
            txtConfSenha.Multiline = true;
            txtConfSenha.Name = "txtConfSenha";
            txtConfSenha.PasswordChar = '*';
            txtConfSenha.Size = new Size(208, 23);
            txtConfSenha.TabIndex = 71;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(347, 302);
            label7.Name = "label7";
            label7.Size = new Size(126, 20);
            label7.TabIndex = 70;
            label7.Text = "Confirmar senha:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(347, 230);
            label6.Name = "label6";
            label6.Size = new Size(55, 20);
            label6.TabIndex = 69;
            label6.Text = "Senha:";
            // 
            // txtSenha
            // 
            txtSenha.BorderStyle = BorderStyle.None;
            txtSenha.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtSenha.Location = new Point(347, 253);
            txtSenha.Multiline = true;
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(208, 23);
            txtSenha.TabIndex = 68;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(347, 97);
            label5.Name = "label5";
            label5.Size = new Size(71, 20);
            label5.TabIndex = 67;
            label5.Text = "Telefone:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(348, 159);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 66;
            label4.Text = "Endereço:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(50, 230);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 65;
            label3.Text = "Matrícula:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(50, 97);
            label2.Name = "label2";
            label2.Size = new Size(127, 20);
            label2.TabIndex = 64;
            label2.Text = "Nome  completo:";
            // 
            // txtEndereco
            // 
            txtEndereco.BorderStyle = BorderStyle.None;
            txtEndereco.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtEndereco.Location = new Point(347, 182);
            txtEndereco.Multiline = true;
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(208, 23);
            txtEndereco.TabIndex = 62;
            // 
            // txtMatricula
            // 
            txtMatricula.BorderStyle = BorderStyle.None;
            txtMatricula.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtMatricula.Location = new Point(50, 253);
            txtMatricula.Multiline = true;
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(208, 23);
            txtMatricula.TabIndex = 61;
            // 
            // txtNome
            // 
            txtNome.BorderStyle = BorderStyle.None;
            txtNome.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtNome.Location = new Point(50, 120);
            txtNome.Multiline = true;
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(208, 23);
            txtNome.TabIndex = 60;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(50, 159);
            label9.Name = "label9";
            label9.Size = new Size(66, 20);
            label9.TabIndex = 82;
            label9.Text = "Usuário:";
            // 
            // txtUsuario
            // 
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsuario.Location = new Point(50, 182);
            txtUsuario.Multiline = true;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(208, 23);
            txtUsuario.TabIndex = 81;
            // 
            // Cadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(229, 218, 216);
            ClientSize = new Size(603, 512);
            Controls.Add(label9);
            Controls.Add(txtUsuario);
            Controls.Add(label);
            Controls.Add(txtPerfil);
            Controls.Add(txtTel);
            Controls.Add(chkMosSenha);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnLogin);
            Controls.Add(btnSair);
            Controls.Add(txtConfSenha);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtSenha);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtEndereco);
            Controls.Add(txtMatricula);
            Controls.Add(txtNome);
            Controls.Add(panel2);
            Name = "Cadastro";
            Text = "Tela de Cadastro";
            Load += Cadastro_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label label1;
        private Label label;
        private TextBox txtPerfil;
        private TextBox txtTel;
        private CheckBox chkMosSenha;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button btnLogin;
        private Button btnSair;
        private TextBox txtConfSenha;
        private Label label7;
        private Label label6;
        private TextBox txtSenha;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtEndereco;
        private TextBox txtMatricula;
        private TextBox txtNome;
        private Label label9;
        private TextBox txtUsuario;
    }
}