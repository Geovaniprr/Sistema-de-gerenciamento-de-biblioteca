namespace Biblioteca_01.Apresentacao
{
    partial class Biblioteca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Biblioteca));
            panel1 = new Panel();
            btnCadLivro = new Button();
            btnSair = new Button();
            label3 = new Label();
            btnMinhaArea = new Button();
            btnAcervo = new Button();
            btnBuscar = new Button();
            pictureBox2 = new PictureBox();
            txtProcurar = new TextBox();
            btnReservar = new Button();
            btnLimpar = new Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            dgvAcervo = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAcervo).BeginInit();
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
            panel1.Size = new Size(159, 518);
            panel1.TabIndex = 21;
            panel1.Paint += panel1_Paint;
            // 
            // btnCadLivro
            // 
            btnCadLivro.FlatStyle = FlatStyle.Flat;
            btnCadLivro.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCadLivro.ForeColor = Color.LightGray;
            btnCadLivro.Location = new Point(0, 239);
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
            btnSair.Location = new Point(0, 422);
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
            btnMinhaArea.Location = new Point(0, 168);
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
            btnAcervo.Location = new Point(0, 97);
            btnAcervo.Name = "btnAcervo";
            btnAcervo.Size = new Size(159, 59);
            btnAcervo.TabIndex = 0;
            btnAcervo.Text = "Acervo";
            btnAcervo.UseVisualStyleBackColor = true;
            btnAcervo.Click += btnAcervo_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.ImageAlign = ContentAlignment.TopRight;
            btnBuscar.Location = new Point(459, 116);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(57, 23);
            btnBuscar.TabIndex = 43;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(425, 116);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(28, 25);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 42;
            pictureBox2.TabStop = false;
            // 
            // txtProcurar
            // 
            txtProcurar.BorderStyle = BorderStyle.None;
            txtProcurar.Location = new Point(204, 116);
            txtProcurar.Multiline = true;
            txtProcurar.Name = "txtProcurar";
            txtProcurar.Size = new Size(215, 23);
            txtProcurar.TabIndex = 41;
            // 
            // btnReservar
            // 
            btnReservar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnReservar.Location = new Point(578, 454);
            btnReservar.Name = "btnReservar";
            btnReservar.Size = new Size(110, 28);
            btnReservar.TabIndex = 40;
            btnReservar.Text = "RESERVAR LIVRO";
            btnReservar.UseVisualStyleBackColor = true;
            btnReservar.Click += btnReservar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpar.Location = new Point(309, 454);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(110, 28);
            btnLimpar.TabIndex = 39;
            btnLimpar.Text = "LIMPAR LISTA";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(550, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 113);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 38;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(198, 88);
            label2.Name = "label2";
            label2.Size = new Size(221, 25);
            label2.TabIndex = 37;
            label2.Text = "Procure o livro que deseja:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Palatino Linotype", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(187, 20);
            label1.Name = "label1";
            label1.Size = new Size(357, 37);
            label1.TabIndex = 36;
            label1.Text = "BEM-VINDO AO ACERVO";
            // 
            // dgvAcervo
            // 
            dgvAcervo.AllowUserToAddRows = false;
            dgvAcervo.Anchor = AnchorStyles.None;
            dgvAcervo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAcervo.BackgroundColor = Color.WhiteSmoke;
            dgvAcervo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAcervo.Location = new Point(198, 159);
            dgvAcervo.Name = "dgvAcervo";
            dgvAcervo.RowTemplate.Height = 25;
            dgvAcervo.Size = new Size(615, 260);
            dgvAcervo.TabIndex = 44;
            dgvAcervo.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Biblioteca
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(229, 218, 216);
            ClientSize = new Size(945, 518);
            Controls.Add(dgvAcervo);
            Controls.Add(btnBuscar);
            Controls.Add(pictureBox2);
            Controls.Add(txtProcurar);
            Controls.Add(btnReservar);
            Controls.Add(btnLimpar);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Biblioteca";
            Text = "Acervo do Administrador";
            Load += Biblioteca_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAcervo).EndInit();
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
        private Button btnBuscar;
        private PictureBox pictureBox2;
        private TextBox txtProcurar;
        private Button btnReservar;
        private Button btnLimpar;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private DataGridView dgvAcervo;
    }
}