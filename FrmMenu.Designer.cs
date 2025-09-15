namespace AppSistema1
{
    partial class FrmMenu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LabelRelogio = new System.Windows.Forms.Label();
            this.TxtSystem = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LabelData = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnSair0 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.BemVindo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(108)))), ((int)(((byte)(181)))));
            this.panel1.Controls.Add(this.BemVindo);
            this.panel1.Controls.Add(this.BtnSair0);
            this.panel1.Controls.Add(this.TxtSystem);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1198, 60);
            this.panel1.TabIndex = 0;
            // 
            // LabelRelogio
            // 
            this.LabelRelogio.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.LabelRelogio.AutoSize = true;
            this.LabelRelogio.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.LabelRelogio.Location = new System.Drawing.Point(68, 527);
            this.LabelRelogio.Name = "LabelRelogio";
            this.LabelRelogio.Size = new System.Drawing.Size(63, 20);
            this.LabelRelogio.TabIndex = 1;
            this.LabelRelogio.Text = "Rélogio";
            // 
            // TxtSystem
            // 
            this.TxtSystem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtSystem.AutoSize = true;
            this.TxtSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSystem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.TxtSystem.Location = new System.Drawing.Point(432, 16);
            this.TxtSystem.Name = "TxtSystem";
            this.TxtSystem.Size = new System.Drawing.Size(337, 29);
            this.TxtSystem.TabIndex = 0;
            this.TxtSystem.Text = "SISTEMA DE ELETRONICA";
            this.TxtSystem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TxtSystem.Click += new System.EventHandler(this.TxtSystem_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(108)))), ((int)(((byte)(181)))));
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.LabelData);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.LabelRelogio);
            this.panel2.Controls.Add(this.button8);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Location = new System.Drawing.Point(0, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 595);
            this.panel2.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LabelData
            // 
            this.LabelData.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.LabelData.AutoSize = true;
            this.LabelData.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.LabelData.Location = new System.Drawing.Point(52, 494);
            this.LabelData.Name = "LabelData";
            this.LabelData.Size = new System.Drawing.Size(44, 20);
            this.LabelData.TabIndex = 2;
            this.LabelData.Text = "Data";
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 494);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Data:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(7, 527);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Horario:";
            // 
            // BtnSair0
            // 
            this.BtnSair0.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSair0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSair0.FlatAppearance.BorderSize = 0;
            this.BtnSair0.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnSair0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSair0.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSair0.ForeColor = System.Drawing.Color.White;
            this.BtnSair0.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSair0.Location = new System.Drawing.Point(1046, -5);
            this.BtnSair0.Name = "BtnSair0";
            this.BtnSair0.Size = new System.Drawing.Size(137, 65);
            this.BtnSair0.TabIndex = 0;
            this.BtnSair0.Text = "Sair";
            this.BtnSair0.UseVisualStyleBackColor = true;
            this.BtnSair0.Click += new System.EventHandler(this.button7_Click);
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Image = global::AppSistema1.Properties.Resources.nf1;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(0, 235);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(200, 45);
            this.button5.TabIndex = 0;
            this.button5.Text = "Nota Fiscal";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = global::AppSistema1.Properties.Resources.clientes1;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(0, 63);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 45);
            this.button3.TabIndex = 0;
            this.button3.Text = "Funcionarios";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button8
            // 
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Image = global::AppSistema1.Properties.Resources.estoque1;
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(0, 113);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(200, 45);
            this.button8.TabIndex = 0;
            this.button8.Text = "Estoque";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = global::AppSistema1.Properties.Resources.rota1;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(0, 173);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(200, 45);
            this.button4.TabIndex = 0;
            this.button4.Text = "Rota";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(108)))), ((int)(((byte)(181)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::AppSistema1.Properties.Resources.clientes;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 120);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 45);
            this.button2.TabIndex = 0;
            this.button2.Text = "Clientes";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::AppSistema1.Properties.Resources.carrinho2;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "Produtos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button6
            // 
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(108)))), ((int)(((byte)(181)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Image = global::AppSistema1.Properties.Resources.off1;
            this.button6.Location = new System.Drawing.Point(0, 550);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(200, 45);
            this.button6.TabIndex = 1;
            this.button6.Text = " ";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Image = global::AppSistema1.Properties.Resources.relatorio1;
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(0, 295);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(200, 45);
            this.button7.TabIndex = 0;
            this.button7.Text = "Relatório";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // BemVindo
            // 
            this.BemVindo.AutoSize = true;
            this.BemVindo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BemVindo.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.BemVindo.Location = new System.Drawing.Point(3, 16);
            this.BemVindo.Name = "BemVindo";
            this.BemVindo.Size = new System.Drawing.Size(260, 29);
            this.BemVindo.TabIndex = 1;
            this.BemVindo.Text = "Bem-vindo, Jefferson";
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmMenu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Gestão";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label TxtSystem;
        private System.Windows.Forms.Label LabelRelogio;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label LabelData;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnSair0;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label BemVindo;
    }
}

