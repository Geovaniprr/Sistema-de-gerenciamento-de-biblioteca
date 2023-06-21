namespace Biblioteca_01.Apresentacao
{
    partial class MinhaAreaAlunos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MinhaAreaAlunos));
            panel1 = new Panel();
            btnSair = new Button();
            label3 = new Label();
            btnMinhaArea = new Button();
            btnAcervo = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            dgvDevolucoes = new DataGridView();
            dgvHistorico = new DataGridView();
            label4 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDevolucoes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvHistorico).BeginInit();
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
            panel1.Size = new Size(159, 547);
            panel1.TabIndex = 21;
            panel1.Paint += panel1_Paint;
            // 
            // btnSair
            // 
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSair.ForeColor = Color.LightGray;
            btnSair.Location = new Point(0, 430);
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Palatino Linotype", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(177, 19);
            label1.Name = "label1";
            label1.Size = new Size(203, 37);
            label1.TabIndex = 35;
            label1.Text = "MINHA ÁREA";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(386, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(93, 74);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 34;
            pictureBox1.TabStop = false;
            // 
            // dgvDevolucoes
            // 
            dgvDevolucoes.AllowUserToAddRows = false;
            dgvDevolucoes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDevolucoes.BackgroundColor = Color.WhiteSmoke;
            dgvDevolucoes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDevolucoes.Location = new Point(193, 370);
            dgvDevolucoes.Name = "dgvDevolucoes";
            dgvDevolucoes.RowTemplate.Height = 25;
            dgvDevolucoes.Size = new Size(363, 119);
            dgvDevolucoes.TabIndex = 43;
            // 
            // dgvHistorico
            // 
            dgvHistorico.AllowUserToAddRows = false;
            dgvHistorico.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistorico.BackgroundColor = Color.WhiteSmoke;
            dgvHistorico.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorico.Location = new Point(193, 127);
            dgvHistorico.Name = "dgvHistorico";
            dgvHistorico.RowTemplate.Height = 25;
            dgvHistorico.Size = new Size(363, 119);
            dgvHistorico.TabIndex = 42;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(193, 327);
            label4.Name = "label4";
            label4.Size = new Size(207, 25);
            label4.TabIndex = 41;
            label4.Text = "Histórico de devoluções:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(193, 90);
            label2.Name = "label2";
            label2.Size = new Size(221, 25);
            label2.TabIndex = 40;
            label2.Text = "Histórico de emprestimos:";
            // 
            // MinhaAreaAlunos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(229, 218, 216);
            ClientSize = new Size(887, 547);
            Controls.Add(dgvDevolucoes);
            Controls.Add(dgvHistorico);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Name = "MinhaAreaAlunos";
            Text = "Minha area - Aluno";
            Load += MinhaAreaAlunos_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDevolucoes).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvHistorico).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnSair;
        private Label label3;
        private Button btnMinhaArea;
        private Button btnAcervo;
        private Label label1;
        private PictureBox pictureBox1;
        private DataGridView dgvDevolucoes;
        private DataGridView dgvHistorico;
        private Label label4;
        private Label label2;
    }
}