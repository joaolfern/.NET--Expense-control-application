namespace PDesp_Projeto
{
    partial class frmMembro
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMembro));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvMembro = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPapel = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bnvMembro = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tbtnAdicionar = new System.Windows.Forms.ToolStripButton();
            this.ttbtnSalvar = new System.Windows.Forms.ToolStripButton();
            this.tbtnAlterar = new System.Windows.Forms.ToolStripButton();
            this.tbtnExcluir = new System.Windows.Forms.ToolStripButton();
            this.tbtnCancelar = new System.Windows.Forms.ToolStripButton();
            this.tbtnSair = new System.Windows.Forms.ToolStripButton();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembro)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnvMembro)).BeginInit();
            this.bnvMembro.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 410);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvMembro);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 384);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dados";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvMembro
            // 
            this.dgvMembro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMembro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMembro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMembro.Location = new System.Drawing.Point(3, 3);
            this.dgvMembro.Name = "dgvMembro";
            this.dgvMembro.Size = new System.Drawing.Size(762, 378);
            this.dgvMembro.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.txtPapel);
            this.tabPage2.Controls.Add(this.txtNome);
            this.tabPage2.Controls.Add(this.txtId);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 384);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Detalhes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::PDesp_Projeto.Properties.Resources.img_297675;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.ForeColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(578, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(102, 107);
            this.panel1.TabIndex = 16;
            // 
            // txtPapel
            // 
            this.txtPapel.Enabled = false;
            this.txtPapel.Location = new System.Drawing.Point(253, 202);
            this.txtPapel.Name = "txtPapel";
            this.txtPapel.Size = new System.Drawing.Size(219, 26);
            this.txtPapel.TabIndex = 5;
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Location = new System.Drawing.Point(253, 137);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(192, 26);
            this.txtNome.TabIndex = 4;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(253, 75);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(100, 26);
            this.txtId.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Papel do membro:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome do membro:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id:";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // bnvMembro
            // 
            this.bnvMembro.AddNewItem = null;
            this.bnvMembro.CountItem = null;
            this.bnvMembro.DeleteItem = null;
            this.bnvMembro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnvMembro.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.tbtnAdicionar,
            this.ttbtnSalvar,
            this.tbtnAlterar,
            this.tbtnExcluir,
            this.tbtnCancelar,
            this.tbtnSair});
            this.bnvMembro.Location = new System.Drawing.Point(0, 0);
            this.bnvMembro.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnvMembro.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnvMembro.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnvMembro.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnvMembro.Name = "bnvMembro";
            this.bnvMembro.PositionItem = this.bindingNavigatorPositionItem;
            this.bnvMembro.Size = new System.Drawing.Size(800, 25);
            this.bnvMembro.TabIndex = 2;
            this.bnvMembro.Text = "bnvMembro";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "of {0}";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "of {0}";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "of {0}";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "of {0}";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tbtnAdicionar
            // 
            this.tbtnAdicionar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnAdicionar.Image = global::PDesp_Projeto.Properties.Resources._13787;
            this.tbtnAdicionar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnAdicionar.Name = "tbtnAdicionar";
            this.tbtnAdicionar.Size = new System.Drawing.Size(23, 22);
            this.tbtnAdicionar.Text = "of {0}";
            this.tbtnAdicionar.Click += new System.EventHandler(this.TbtnAdicionar_Click);
            // 
            // ttbtnSalvar
            // 
            this.ttbtnSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ttbtnSalvar.Image = global::PDesp_Projeto.Properties.Resources._9016_200;
            this.ttbtnSalvar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ttbtnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ttbtnSalvar.Name = "ttbtnSalvar";
            this.ttbtnSalvar.Size = new System.Drawing.Size(23, 22);
            this.ttbtnSalvar.Text = "Salvar";
            this.ttbtnSalvar.Click += new System.EventHandler(this.TtbtnSalvar_Click);
            // 
            // tbtnAlterar
            // 
            this.tbtnAlterar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnAlterar.Image = global::PDesp_Projeto.Properties.Resources.icon_edit_1_jpg;
            this.tbtnAlterar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnAlterar.Name = "tbtnAlterar";
            this.tbtnAlterar.Size = new System.Drawing.Size(23, 22);
            this.tbtnAlterar.Text = "Alterar";
            this.tbtnAlterar.Click += new System.EventHandler(this.TbtnAlterar_Click);
            // 
            // tbtnExcluir
            // 
            this.tbtnExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnExcluir.Image = global::PDesp_Projeto.Properties.Resources.Trash_Email_Bin_5121;
            this.tbtnExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnExcluir.Name = "tbtnExcluir";
            this.tbtnExcluir.Size = new System.Drawing.Size(23, 22);
            this.tbtnExcluir.Text = "Excluir";
            this.tbtnExcluir.Click += new System.EventHandler(this.TbtnExcluir_Click);
            // 
            // tbtnCancelar
            // 
            this.tbtnCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnCancelar.Image = global::PDesp_Projeto.Properties.Resources.Files_Cancel_File_icon;
            this.tbtnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnCancelar.Name = "tbtnCancelar";
            this.tbtnCancelar.Size = new System.Drawing.Size(23, 22);
            this.tbtnCancelar.Text = "Cancelar";
            this.tbtnCancelar.Click += new System.EventHandler(this.TbtnCancelar_Click);
            // 
            // tbtnSair
            // 
            this.tbtnSair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnSair.Image = global::PDesp_Projeto.Properties.Resources.indice;
            this.tbtnSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnSair.Name = "tbtnSair";
            this.tbtnSair.Size = new System.Drawing.Size(23, 22);
            this.tbtnSair.Text = "Sair";
            this.tbtnSair.Click += new System.EventHandler(this.TbtnSair_Click);
            // 
            // frmMembro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bnvMembro);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMembro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMembro";
            this.Load += new System.EventHandler(this.FrmMembro_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembro)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnvMembro)).EndInit();
            this.bnvMembro.ResumeLayout(false);
            this.bnvMembro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingNavigator bnvMembro;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton ttbtnSalvar;
        private System.Windows.Forms.TextBox txtPapel;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripButton tbtnAdicionar;
        private System.Windows.Forms.ToolStripButton tbtnAlterar;
        private System.Windows.Forms.ToolStripButton tbtnExcluir;
        private System.Windows.Forms.ToolStripButton tbtnCancelar;
        private System.Windows.Forms.ToolStripButton tbtnSair;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvMembro;
    }
}