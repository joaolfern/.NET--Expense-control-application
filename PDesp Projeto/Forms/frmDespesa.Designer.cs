namespace PDesp_Projeto
{
    partial class frmDespesa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDespesa));
            this.bnvDespesa = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvDespesa = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.MaskedTextBox();
            this.txtData = new System.Windows.Forms.MaskedTextBox();
            this.cbxMembro = new System.Windows.Forms.ComboBox();
            this.cbxTipoDespesa = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.rtxtObservacao = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bnvDespesa)).BeginInit();
            this.bnvDespesa.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDespesa)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bnvDespesa
            // 
            this.bnvDespesa.AddNewItem = null;
            this.bnvDespesa.CountItem = this.bindingNavigatorCountItem;
            this.bnvDespesa.CountItemFormat = "";
            this.bnvDespesa.DeleteItem = null;
            this.bnvDespesa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnvDespesa.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
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
            this.bnvDespesa.Location = new System.Drawing.Point(0, 0);
            this.bnvDespesa.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnvDespesa.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnvDespesa.MoveNextItem = null;
            this.bnvDespesa.MovePreviousItem = this.bindingNavigatorCountItem;
            this.bnvDespesa.Name = "bnvDespesa";
            this.bnvDespesa.PositionItem = null;
            this.bnvDespesa.Size = new System.Drawing.Size(800, 25);
            this.bnvDespesa.TabIndex = 3;
            this.bnvDespesa.Text = "bnvDespesa";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(0, 22);
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
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
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
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
            this.tbtnAdicionar.Text = "Adicionar";
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
            // 
            // tbtnExcluir
            // 
            this.tbtnExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnExcluir.Image = global::PDesp_Projeto.Properties.Resources.Trash_Email_Bin_5121;
            this.tbtnExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnExcluir.Name = "tbtnExcluir";
            this.tbtnExcluir.Size = new System.Drawing.Size(23, 22);
            this.tbtnExcluir.Text = "Excluir";
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 410);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvDespesa);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 384);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dados";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvDespesa
            // 
            this.dgvDespesa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDespesa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDespesa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDespesa.Location = new System.Drawing.Point(3, 3);
            this.dgvDespesa.Name = "dgvDespesa";
            this.dgvDespesa.Size = new System.Drawing.Size(762, 378);
            this.dgvDespesa.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.txtValor);
            this.tabPage2.Controls.Add(this.txtData);
            this.tabPage2.Controls.Add(this.cbxMembro);
            this.tabPage2.Controls.Add(this.cbxTipoDespesa);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.rtxtObservacao);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.txtId);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Tipo da despesa:";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(170, 232);
            this.txtValor.Mask = "00000,99";
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(79, 26);
            this.txtValor.TabIndex = 19;
            this.txtValor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtValor_KeyDown);
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(170, 189);
            this.txtData.Mask = "00/00/0000";
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(100, 26);
            this.txtData.TabIndex = 18;
            this.txtData.ValidatingType = typeof(System.DateTime);
            this.txtData.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtData_KeyDown);
            // 
            // cbxMembro
            // 
            this.cbxMembro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMembro.FormattingEnabled = true;
            this.cbxMembro.Location = new System.Drawing.Point(170, 144);
            this.cbxMembro.Name = "cbxMembro";
            this.cbxMembro.Size = new System.Drawing.Size(192, 28);
            this.cbxMembro.TabIndex = 17;
            this.cbxMembro.SelectedIndexChanged += new System.EventHandler(this.CbxMembro_SelectedIndexChanged);
            // 
            // cbxTipoDespesa
            // 
            this.cbxTipoDespesa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoDespesa.FormattingEnabled = true;
            this.cbxTipoDespesa.Location = new System.Drawing.Point(170, 97);
            this.cbxTipoDespesa.Name = "cbxTipoDespesa";
            this.cbxTipoDespesa.Size = new System.Drawing.Size(192, 28);
            this.cbxTipoDespesa.TabIndex = 16;
            this.cbxTipoDespesa.SelectedValueChanged += new System.EventHandler(this.CbxTipoDespesa_SelectedValueChanged);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::PDesp_Projeto.Properties.Resources.expense_account_696565;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.ForeColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(540, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(142, 120);
            this.panel1.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(407, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Observação:";
            // 
            // rtxtObservacao
            // 
            this.rtxtObservacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxtObservacao.Location = new System.Drawing.Point(511, 180);
            this.rtxtObservacao.Name = "rtxtObservacao";
            this.rtxtObservacao.Size = new System.Drawing.Size(206, 146);
            this.rtxtObservacao.TabIndex = 11;
            this.rtxtObservacao.Text = "";
            this.rtxtObservacao.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RtxtObservacao_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(116, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Valor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(116, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Data:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Membro:";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(170, 56);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(100, 26);
            this.txtId.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id:";
            // 
            // frmDespesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.bnvDespesa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDespesa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDespesa";
            this.Load += new System.EventHandler(this.FrmDespesa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bnvDespesa)).EndInit();
            this.bnvDespesa.ResumeLayout(false);
            this.bnvDespesa.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDespesa)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator bnvDespesa;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tbtnAdicionar;
        private System.Windows.Forms.ToolStripButton ttbtnSalvar;
        private System.Windows.Forms.ToolStripButton tbtnAlterar;
        private System.Windows.Forms.ToolStripButton tbtnExcluir;
        private System.Windows.Forms.ToolStripButton tbtnCancelar;
        private System.Windows.Forms.ToolStripButton tbtnSair;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvDespesa;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox rtxtObservacao;
        private System.Windows.Forms.ComboBox cbxMembro;
        private System.Windows.Forms.ComboBox cbxTipoDespesa;
        private System.Windows.Forms.MaskedTextBox txtValor;
        private System.Windows.Forms.MaskedTextBox txtData;
        private System.Windows.Forms.Label label3;
    }
}