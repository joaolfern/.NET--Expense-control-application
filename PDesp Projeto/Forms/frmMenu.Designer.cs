namespace PDesp_Projeto
{
    partial class btnMax
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(btnMax));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDespesasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.membroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.despesasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.despesasToolStripMenuItem,
            this.sobreToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 27);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1200, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tipoDespesasToolStripMenuItem,
            this.membroToolStripMenuItem});
            this.cadastroToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            this.cadastroToolStripMenuItem.Click += new System.EventHandler(this.CadastroToolStripMenuItem_Click);
            // 
            // tipoDespesasToolStripMenuItem
            // 
            this.tipoDespesasToolStripMenuItem.Name = "tipoDespesasToolStripMenuItem";
            this.tipoDespesasToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.tipoDespesasToolStripMenuItem.Text = "Tipo de despesas";
            this.tipoDespesasToolStripMenuItem.Click += new System.EventHandler(this.TipoDespesasToolStripMenuItem_Click);
            // 
            // membroToolStripMenuItem
            // 
            this.membroToolStripMenuItem.Name = "membroToolStripMenuItem";
            this.membroToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.membroToolStripMenuItem.Text = "Membro";
            this.membroToolStripMenuItem.Click += new System.EventHandler(this.MembroToolStripMenuItem_Click);
            // 
            // despesasToolStripMenuItem
            // 
            this.despesasToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.despesasToolStripMenuItem.Name = "despesasToolStripMenuItem";
            this.despesasToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.despesasToolStripMenuItem.Text = "Despesas";
            this.despesasToolStripMenuItem.Click += new System.EventHandler(this.DespesasToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.SobreToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.SairToolStripMenuItem_Click);
            // 
            // pnlTitle
            // 
            this.pnlTitle.AllowDrop = true;
            this.pnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.pnlTitle.Controls.Add(this.label1);
            this.pnlTitle.Controls.Add(this.button2);
            this.pnlTitle.Controls.Add(this.button1);
            this.pnlTitle.Controls.Add(this.btnFechar);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(1200, 27);
            this.pnlTitle.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Controle de gastos";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::PDesp_Projeto.Properties.Resources.maximize_window_48;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(1141, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(24, 21);
            this.button2.TabIndex = 10;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::PDesp_Projeto.Properties.Resources.minimize_window_48;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1111, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 21);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.BackColor = System.Drawing.Color.Transparent;
            this.btnFechar.BackgroundImage = global::PDesp_Projeto.Properties.Resources.close_window_48_1_;
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Location = new System.Drawing.Point(1171, 3);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(26, 21);
            this.btnFechar.TabIndex = 8;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // btnMax
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.pnlTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "btnMax";
            this.Text = "Controle de Gastos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MdiChildActivate += new System.EventHandler(this.FrmMenu_MdiChildActivate);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoDespesasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem membroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem despesasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}

