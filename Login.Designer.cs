namespace Biblioteca_01.Apresentacao
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            chkMosSenha = new CheckBox();
            lblMatricula = new Label();
            txtMatricula = new TextBox();
            lblCadastrese = new Label();
            label4 = new Label();
            label3 = new Label();
            btnEntrar = new Button();
            label2 = new Label();
            label1 = new Label();
            txtSenha = new TextBox();
            txtUsuario = new TextBox();
            label6 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(97, 120, 150);
            panel1.Controls.Add(chkMosSenha);
            panel1.Controls.Add(lblMatricula);
            panel1.Controls.Add(txtMatricula);
            panel1.Controls.Add(lblCadastrese);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btnEntrar);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtSenha);
            panel1.Controls.Add(txtUsuario);
            panel1.Font = new Font("Sitka Banner", 9F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.Location = new Point(233, 118);
            panel1.Name = "panel1";
            panel1.Size = new Size(272, 384);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // chkMosSenha
            // 
            chkMosSenha.AutoSize = true;
            chkMosSenha.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            chkMosSenha.Location = new Point(127, 224);
            chkMosSenha.Name = "chkMosSenha";
            chkMosSenha.Size = new Size(100, 17);
            chkMosSenha.TabIndex = 21;
            chkMosSenha.Text = "Mostrar senha";
            chkMosSenha.UseVisualStyleBackColor = true;
            chkMosSenha.CheckedChanged += chkMosSenha_CheckedChanged_1;
            // 
            // lblMatricula
            // 
            lblMatricula.AutoSize = true;
            lblMatricula.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblMatricula.Location = new Point(45, 115);
            lblMatricula.Name = "lblMatricula";
            lblMatricula.Size = new Size(60, 15);
            lblMatricula.TabIndex = 20;
            lblMatricula.Text = "Matrícula:";
            // 
            // txtMatricula
            // 
            txtMatricula.BorderStyle = BorderStyle.None;
            txtMatricula.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtMatricula.Location = new Point(45, 133);
            txtMatricula.Multiline = true;
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(182, 23);
            txtMatricula.TabIndex = 19;
            // 
            // lblCadastrese
            // 
            lblCadastrese.AutoSize = true;
            lblCadastrese.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblCadastrese.ForeColor = SystemColors.GradientActiveCaption;
            lblCadastrese.Location = new Point(93, 343);
            lblCadastrese.Name = "lblCadastrese";
            lblCadastrese.Size = new Size(82, 19);
            lblCadastrese.TabIndex = 18;
            lblCadastrese.Text = "Cadastre-se";
            lblCadastrese.Click += lblCadastrese_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(60, 324);
            label4.Name = "label4";
            label4.Size = new Size(152, 19);
            label4.TabIndex = 16;
            label4.Text = "Não possui uma conta?";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 16.26F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(100, 9);
            label3.Name = "label3";
            label3.Size = new Size(78, 30);
            label3.TabIndex = 15;
            label3.Text = "LOGIN";
            // 
            // btnEntrar
            // 
            btnEntrar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEntrar.ForeColor = SystemColors.InfoText;
            btnEntrar.Location = new Point(93, 298);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(85, 23);
            btnEntrar.TabIndex = 14;
            btnEntrar.Text = "ENTRAR";
            btnEntrar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(45, 177);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 13;
            label2.Text = "Senha:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(45, 57);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 12;
            label1.Text = "Usuário:";
            // 
            // txtSenha
            // 
            txtSenha.BorderStyle = BorderStyle.None;
            txtSenha.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtSenha.Location = new Point(45, 195);
            txtSenha.Multiline = true;
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(182, 23);
            txtSenha.TabIndex = 11;
            txtSenha.TextChanged += txtSenha_TextChanged;
            // 
            // txtUsuario
            // 
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsuario.Location = new Point(45, 75);
            txtUsuario.Multiline = true;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(182, 23);
            txtUsuario.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Palatino Linotype", 32.26F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(159, 19);
            label6.Name = "label6";
            label6.Size = new Size(422, 60);
            label6.TabIndex = 7;
            label6.Text = "BIBLIOTECA FITO";
            label6.Click += label6_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(559, 233);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(157, 156);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(566, 411);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(139, 139);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 9;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(559, 75);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(146, 136);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(36, 233);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(134, 181);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 13;
            pictureBox6.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(30, 75);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(140, 136);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(30, 442);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(134, 129);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(229, 218, 216);
            ClientSize = new Size(738, 583);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(label6);
            Controls.Add(panel1);
            Name = "Login";
            Text = "Tela de Login";
            Load += Cadastro_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private CheckBox chkMosSenha;
        private Label lblMatricula;
        private TextBox txtMatricula;
        private Label lblCadastrese;
        private Label label4;
        private Label label3;
        private Button btnEntrar;
        private Label label2;
        private Label label1;
        private TextBox txtSenha;
        private TextBox txtUsuario;
        private Label label6;
        private PictureBox pictureBox2;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox6;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
    }
}