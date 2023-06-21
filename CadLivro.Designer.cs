namespace Biblioteca_01.Apresentacao
{
    partial class CadLivro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadLivro));
            panel1 = new Panel();
            btnCadLivro = new Button();
            btnSair = new Button();
            label3 = new Label();
            btnMinhaArea = new Button();
            btnAcervo = new Button();
            btnInserirNoBanco = new Button();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            txtCategoria = new TextBox();
            txtAnoPubli = new TextBox();
            txtEditora = new TextBox();
            txtAutor = new TextBox();
            btnLimpar = new Button();
            txtTitulo = new TextBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            dgvCadLivro = new DataGridView();
            txtQtdEstoque = new TextBox();
            label9 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCadLivro).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(97, 120, 150);
            panel1.Controls.Add(btnCadLivro);
            panel1.Controls.Add(btnSair);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btnMinhaArea);
            panel1.Controls.Add(btnAcervo);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(159, 630);
            panel1.TabIndex = 23;
            // 
            // btnCadLivro
            // 
            btnCadLivro.FlatStyle = FlatStyle.Flat;
            btnCadLivro.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCadLivro.ForeColor = Color.LightGray;
            btnCadLivro.Location = new Point(0, 214);
            btnCadLivro.Margin = new Padding(0);
            btnCadLivro.Name = "btnCadLivro";
            btnCadLivro.Size = new Size(159, 60);
            btnCadLivro.TabIndex = 21;
            btnCadLivro.Text = "Cadastrar novo livro";
            btnCadLivro.UseVisualStyleBackColor = true;
            btnCadLivro.Click += btnCadLivro_Click;
            // 
            // btnSair
            // 
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSair.ForeColor = Color.LightGray;
            btnSair.Location = new Point(0, 530);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(159, 60);
            btnSair.TabIndex = 3;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.LightGray;
            label3.Location = new Point(51, 9);
            label3.Name = "label3";
            label3.Size = new Size(55, 21);
            label3.TabIndex = 2;
            label3.Text = "MENU";
            // 
            // btnMinhaArea
            // 
            btnMinhaArea.FlatStyle = FlatStyle.Flat;
            btnMinhaArea.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnMinhaArea.ForeColor = Color.LightGray;
            btnMinhaArea.Location = new Point(0, 142);
            btnMinhaArea.Margin = new Padding(0);
            btnMinhaArea.Name = "btnMinhaArea";
            btnMinhaArea.Size = new Size(159, 60);
            btnMinhaArea.TabIndex = 1;
            btnMinhaArea.Text = "Minha área";
            btnMinhaArea.UseVisualStyleBackColor = true;
            btnMinhaArea.Click += btnMinhaArea_Click;
            // 
            // btnAcervo
            // 
            btnAcervo.FlatStyle = FlatStyle.Flat;
            btnAcervo.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAcervo.ForeColor = Color.LightGray;
            btnAcervo.Location = new Point(0, 68);
            btnAcervo.Name = "btnAcervo";
            btnAcervo.Size = new Size(159, 59);
            btnAcervo.TabIndex = 0;
            btnAcervo.Text = "Acervo";
            btnAcervo.UseVisualStyleBackColor = true;
            btnAcervo.Click += btnAcervo_Click;
            // 
            // btnInserirNoBanco
            // 
            btnInserirNoBanco.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnInserirNoBanco.Location = new Point(490, 574);
            btnInserirNoBanco.Name = "btnInserirNoBanco";
            btnInserirNoBanco.Size = new Size(197, 28);
            btnInserirNoBanco.TabIndex = 68;
            btnInserirNoBanco.Text = "ADICIONAR LIVRO NO ACERVO";
            btnInserirNoBanco.UseVisualStyleBackColor = true;
            btnInserirNoBanco.Click += btnInserir_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(204, 341);
            label8.Name = "label8";
            label8.Size = new Size(61, 15);
            label8.TabIndex = 67;
            label8.Text = "Categoria:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(204, 287);
            label7.Name = "label7";
            label7.Size = new Size(109, 15);
            label7.TabIndex = 66;
            label7.Text = "Ano de publicação:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(204, 233);
            label6.Name = "label6";
            label6.Size = new Size(47, 15);
            label6.TabIndex = 65;
            label6.Text = "Editora:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(204, 179);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 64;
            label5.Text = "Autor:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(204, 124);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 63;
            label4.Text = "Título:";
            // 
            // txtCategoria
            // 
            txtCategoria.BorderStyle = BorderStyle.None;
            txtCategoria.Location = new Point(204, 359);
            txtCategoria.Multiline = true;
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(190, 23);
            txtCategoria.TabIndex = 62;
            // 
            // txtAnoPubli
            // 
            txtAnoPubli.BorderStyle = BorderStyle.None;
            txtAnoPubli.Location = new Point(204, 305);
            txtAnoPubli.Multiline = true;
            txtAnoPubli.Name = "txtAnoPubli";
            txtAnoPubli.Size = new Size(190, 23);
            txtAnoPubli.TabIndex = 61;
            // 
            // txtEditora
            // 
            txtEditora.BorderStyle = BorderStyle.None;
            txtEditora.Location = new Point(204, 251);
            txtEditora.Multiline = true;
            txtEditora.Name = "txtEditora";
            txtEditora.Size = new Size(190, 23);
            txtEditora.TabIndex = 60;
            // 
            // txtAutor
            // 
            txtAutor.BorderStyle = BorderStyle.None;
            txtAutor.Location = new Point(204, 197);
            txtAutor.Multiline = true;
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(190, 23);
            txtAutor.TabIndex = 59;
            // 
            // btnLimpar
            // 
            btnLimpar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpar.Location = new Point(789, 574);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(142, 28);
            btnLimpar.TabIndex = 57;
            btnLimpar.Text = "LIMPAR LISTA";
            btnLimpar.UseVisualStyleBackColor = true;
            // 
            // txtTitulo
            // 
            txtTitulo.BorderStyle = BorderStyle.None;
            txtTitulo.Location = new Point(204, 142);
            txtTitulo.Multiline = true;
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(190, 23);
            txtTitulo.TabIndex = 56;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(182, 85);
            label2.Name = "label2";
            label2.Size = new Size(203, 25);
            label2.TabIndex = 55;
            label2.Text = "Insira os dados do livro:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(572, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(84, 99);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 54;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Palatino Linotype", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(182, 20);
            label1.Name = "label1";
            label1.Size = new Size(384, 37);
            label1.TabIndex = 53;
            label1.Text = "CADASTRAR NOVO LIVRO";
            // 
            // dgvCadLivro
            // 
            dgvCadLivro.AllowUserToAddRows = false;
            dgvCadLivro.Anchor = AnchorStyles.None;
            dgvCadLivro.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCadLivro.BackgroundColor = Color.WhiteSmoke;
            dgvCadLivro.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCadLivro.Location = new Point(437, 132);
            dgvCadLivro.Name = "dgvCadLivro";
            dgvCadLivro.RowTemplate.Height = 25;
            dgvCadLivro.Size = new Size(563, 402);
            dgvCadLivro.TabIndex = 69;
            dgvCadLivro.CellContentClick += dgvCadLivro_CellContentClick;
            // 
            // txtQtdEstoque
            // 
            txtQtdEstoque.BorderStyle = BorderStyle.None;
            txtQtdEstoque.Location = new Point(204, 422);
            txtQtdEstoque.Multiline = true;
            txtQtdEstoque.Name = "txtQtdEstoque";
            txtQtdEstoque.Size = new Size(190, 23);
            txtQtdEstoque.TabIndex = 71;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(204, 404);
            label9.Name = "label9";
            label9.Size = new Size(151, 15);
            label9.TabIndex = 72;
            label9.Text = "Quantidade de exemplares:";
            // 
            // CadLivro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(229, 218, 216);
            ClientSize = new Size(1042, 630);
            Controls.Add(label9);
            Controls.Add(txtQtdEstoque);
            Controls.Add(dgvCadLivro);
            Controls.Add(btnInserirNoBanco);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtCategoria);
            Controls.Add(txtAnoPubli);
            Controls.Add(txtEditora);
            Controls.Add(txtAutor);
            Controls.Add(btnLimpar);
            Controls.Add(txtTitulo);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "CadLivro";
            Text = "Cadastrar Livro";
            Load += CadLivro_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCadLivro).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnCadLivro;
        private Button btnSair;
        private Label label3;
        private Button btnMinhaArea;
        private Button btnAcervo;
        private Button btnInserirNoBanco;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox txtCategoria;
        private TextBox txtAnoPubli;
        private TextBox txtEditora;
        private TextBox txtAutor;
        private Button btnLimpar;
        private TextBox txtTitulo;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label1;
        private DataGridView dgvCadLivro;
        private TextBox txtQtdEstoque;
        private Label label9;
    }
}