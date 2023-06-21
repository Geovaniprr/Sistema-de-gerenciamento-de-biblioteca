namespace Biblioteca_01.Apresentacao
{
    partial class BibliotecaAlunos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BibliotecaAlunos));
            panel1 = new Panel();
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
            panel1.Controls.Add(btnSair);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btnMinhaArea);
            panel1.Controls.Add(btnAcervo);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(159, 498);
            panel1.TabIndex = 20;
            panel1.Paint += panel1_Paint;
            // 
            // btnSair
            // 
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSair.ForeColor = Color.LightGray;
            btnSair.Location = new Point(0, 409);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(159, 59);
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
            btnMinhaArea.Location = new Point(0, 163);
            btnMinhaArea.Margin = new Padding(0);
            btnMinhaArea.Name = "btnMinhaArea";
            btnMinhaArea.Size = new Size(159, 59);
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
            btnAcervo.Location = new Point(0, 95);
            btnAcervo.Name = "btnAcervo";
            btnAcervo.Size = new Size(159, 57);
            btnAcervo.TabIndex = 0;
            btnAcervo.Text = "Acervo";
            btnAcervo.UseVisualStyleBackColor = true;
            btnAcervo.Click += btnAcervo_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.ImageAlign = ContentAlignment.TopRight;
            btnBuscar.Location = new Point(457, 117);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(57, 23);
            btnBuscar.TabIndex = 35;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(423, 117);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(28, 25);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 34;
            pictureBox2.TabStop = false;
            // 
            // txtProcurar
            // 
            txtProcurar.BorderStyle = BorderStyle.None;
            txtProcurar.Location = new Point(202, 117);
            txtProcurar.Multiline = true;
            txtProcurar.Name = "txtProcurar";
            txtProcurar.Size = new Size(215, 23);
            txtProcurar.TabIndex = 33;
            // 
            // btnReservar
            // 
            btnReservar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnReservar.Location = new Point(566, 431);
            btnReservar.Name = "btnReservar";
            btnReservar.Size = new Size(110, 28);
            btnReservar.TabIndex = 32;
            btnReservar.Text = "RESERVAR LIVRO";
            btnReservar.UseVisualStyleBackColor = true;
            btnReservar.Click += btnReservar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpar.Location = new Point(319, 431);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(110, 28);
            btnLimpar.TabIndex = 31;
            btnLimpar.Text = "LIMPAR LISTA";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(548, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 113);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 30;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(196, 89);
            label2.Name = "label2";
            label2.Size = new Size(221, 25);
            label2.TabIndex = 29;
            label2.Text = "Procure o livro que deseja:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Palatino Linotype", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(185, 21);
            label1.Name = "label1";
            label1.Size = new Size(357, 37);
            label1.TabIndex = 28;
            label1.Text = "BEM-VINDO AO ACERVO";
            // 
            // dgvAcervo
            // 
            dgvAcervo.Anchor = AnchorStyles.None;
            dgvAcervo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAcervo.BackgroundColor = Color.WhiteSmoke;
            dgvAcervo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAcervo.Location = new Point(202, 163);
            dgvAcervo.Name = "dgvAcervo";
            dgvAcervo.RowTemplate.Height = 25;
            dgvAcervo.Size = new Size(577, 243);
            dgvAcervo.TabIndex = 45;
            // 
            // BibliotecaAlunos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(229, 218, 216);
            ClientSize = new Size(861, 498);
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
            Name = "BibliotecaAlunos";
            Text = "Acervo do Aluno";
            Load += BibliotecaAlunos_Load;
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