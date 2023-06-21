namespace Biblioteca_01.Apresentacao
{
    partial class MinhaArea
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MinhaArea));
            panel1 = new Panel();
            btnCadLivro = new Button();
            btnSair = new Button();
            label3 = new Label();
            btnMinhaArea = new Button();
            btnAcervo = new Button();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvHistorico = new DataGridView();
            dgvDevolucoes = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvHistorico).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDevolucoes).BeginInit();
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
            panel1.Size = new Size(159, 533);
            panel1.TabIndex = 22;
            panel1.Paint += panel1_Paint;
            // 
            // btnCadLivro
            // 
            btnCadLivro.FlatStyle = FlatStyle.Flat;
            btnCadLivro.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCadLivro.ForeColor = Color.LightGray;
            btnCadLivro.Location = new Point(0, 212);
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
            btnSair.Location = new Point(0, 427);
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
            btnAcervo.Location = new Point(0, 71);
            btnAcervo.Name = "btnAcervo";
            btnAcervo.Size = new Size(159, 59);
            btnAcervo.TabIndex = 0;
            btnAcervo.Text = "Acervo";
            btnAcervo.UseVisualStyleBackColor = true;
            btnAcervo.Click += btnAcervo_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(392, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(91, 74);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(203, 325);
            label4.Name = "label4";
            label4.Size = new Size(207, 25);
            label4.TabIndex = 32;
            label4.Text = "Histórico de devoluções:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(203, 88);
            label2.Name = "label2";
            label2.Size = new Size(221, 25);
            label2.TabIndex = 31;
            label2.Text = "Histórico de emprestimos:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Palatino Linotype", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(175, 20);
            label1.Name = "label1";
            label1.Size = new Size(203, 37);
            label1.TabIndex = 30;
            label1.Text = "MINHA ÁREA";
            // 
            // dgvHistorico
            // 
            dgvHistorico.AllowUserToAddRows = false;
            dgvHistorico.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistorico.BackgroundColor = Color.WhiteSmoke;
            dgvHistorico.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorico.Location = new Point(203, 125);
            dgvHistorico.Name = "dgvHistorico";
            dgvHistorico.RowTemplate.Height = 25;
            dgvHistorico.Size = new Size(363, 119);
            dgvHistorico.TabIndex = 35;
            // 
            // dgvDevolucoes
            // 
            dgvDevolucoes.AllowUserToAddRows = false;
            dgvDevolucoes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDevolucoes.BackgroundColor = Color.WhiteSmoke;
            dgvDevolucoes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDevolucoes.Location = new Point(203, 368);
            dgvDevolucoes.Name = "dgvDevolucoes";
            dgvDevolucoes.RowTemplate.Height = 25;
            dgvDevolucoes.Size = new Size(363, 119);
            dgvDevolucoes.TabIndex = 37;
            // 
            // MinhaArea
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(229, 218, 216);
            ClientSize = new Size(867, 533);
            Controls.Add(dgvDevolucoes);
            Controls.Add(dgvHistorico);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Name = "MinhaArea";
            Text = "Minha area - Administrador";
            Load += MinhaArea_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvHistorico).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDevolucoes).EndInit();
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
        private PictureBox pictureBox1;
        private Label label4;
        private Label label2;
        private Label label1;
        private DataGridView dgvHistorico;
        private DataGridView dgvDevolucoes;
    }
}