using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDesp_Projeto
{
    public partial class frmTipoDespesa : Form
    {
        private BindingSource bnTipoDespesa = new BindingSource();
        private bool bInclusao = false;
        private DataSet dsTipoDespesa = new DataSet();

        public frmTipoDespesa()
        {
            InitializeComponent();
            txtTipoDespesa.MaxLength = 20;
        }

        private void TbtnSair_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void TbtnAdicionar_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                tabControl1.SelectTab(1);
            }

            bnTipoDespesa.AddNew();
            txtTipoDespesa.Enabled = true;
            txtTipoDespesa.Focus();
            ttbtnSalvar.Enabled = true;
            tbtnAlterar.Enabled = false;
            tbtnAdicionar.Enabled = false;
            tbtnExcluir.Enabled = false;
            tbtnCancelar.Enabled = true;

            bInclusao = true;
        }

        private void FrmTipoDespesa_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(242, 245, 242);
            tabControl1.TabPages[1].BackColor = Color.FromArgb(255, 255, 255);
            tabControl1.SelectedIndex = 1;
            txtId.Enabled = false;
            txtTipoDespesa.Enabled = false;
            tbtnAdicionar.Enabled = true;
            tbtnAlterar.Enabled = true;
            tbtnCancelar.Enabled = false;
            ttbtnSalvar.Enabled = false;
            tbtnExcluir.Enabled = true;
            tbtnSair.Enabled = true;
            try
            {
                TipoDespesa TipoDespesa = new TipoDespesa();
                dsTipoDespesa.Tables.Add(TipoDespesa.Listar());
                bnTipoDespesa.DataSource = dsTipoDespesa.Tables["TipoDespesa"];
                dgvTipoDespesa.DataSource = bnTipoDespesa;
                bnvTipoDespesa.BindingSource = bnTipoDespesa;

                txtId.DataBindings.Add("TEXT", bnTipoDespesa, "id_tipodespesa");
                txtTipoDespesa.DataBindings.Add("TEXT", bnTipoDespesa, "nome_tipodespesa");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TtbtnSalvar_Click(object sender, EventArgs e)
        {
            if (txtTipoDespesa.Text == "")
            {
                MessageBox.Show("Preencha devidamente todos os campos.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                TipoDespesa RegTipoDespesa = new TipoDespesa();

                RegTipoDespesa.Idtipodespesa = Convert.ToInt16(txtId.Text);
                RegTipoDespesa.Nometipodespesa = txtTipoDespesa.Text;

                if (bInclusao)
                {
                    if (RegTipoDespesa.Salvar() > 0)
                    {
                        MessageBox.Show("Tipo de despesa adicionada com sucesso!");

                        ttbtnSalvar.Enabled = false;
                        txtId.Enabled = false;
                        txtTipoDespesa.Enabled = false;
                        ttbtnSalvar.Enabled = false;
                        tbtnAlterar.Enabled = true;
                        tbtnAdicionar.Enabled = true;
                        tbtnExcluir.Enabled = true;
                        tbtnCancelar.Enabled = false;

                        bInclusao = false;

                        // recarrega o grid
                        dsTipoDespesa.Tables.Clear();
                        dsTipoDespesa.Tables.Add(RegTipoDespesa.Listar());
                        bnTipoDespesa.DataSource = dsTipoDespesa.Tables["TipoDespesa"];
                    }
                    else
                    {
                        MessageBox.Show("Erro ao gravar o tipo de despesa!");
                    }
                }
                else
                {
                    if (RegTipoDespesa.Alterar() > 0)
                    {
                        MessageBox.Show("Tipo de despesa alterada com sucesso!");

                        dsTipoDespesa.Tables.Clear();
                        dsTipoDespesa.Tables.Add(RegTipoDespesa.Listar());
                        txtId.Enabled = false;
                        txtTipoDespesa.Enabled = false;
                        ttbtnSalvar.Enabled = false;
                        tbtnAlterar.Enabled = true;
                        tbtnAdicionar.Enabled = true;
                        tbtnExcluir.Enabled = true;
                        tbtnCancelar.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Erro ao gravar TipoDespesa!");
                    }
                }
            }
        }

        private void TbtnAlterar_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                tabControl1.SelectTab(1);
            }

            txtTipoDespesa.Enabled = true;
            txtTipoDespesa.Focus();
            ttbtnSalvar.Enabled = true;
            tbtnAlterar.Enabled = false;
            tbtnAdicionar.Enabled = false;
            tbtnExcluir.Enabled = false;
            tbtnCancelar.Enabled = true;
            bInclusao = false;
        }

        private void TbtnExcluir_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                tabControl1.SelectTab(1);
            }


            if (MessageBox.Show("Confirma exclusão?", "Yes or No", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                TipoDespesa RegTipoDespesa = new TipoDespesa();

                RegTipoDespesa.Idtipodespesa = Convert.ToInt16(txtId.Text);
                RegTipoDespesa.Nometipodespesa = txtTipoDespesa.Text;

                if (RegTipoDespesa.Excluir() > 0)
                {
                    MessageBox.Show("Tipo de despesa excluída com sucesso!");
                    TipoDespesa M = new TipoDespesa();
                    dsTipoDespesa.Tables.Clear();
                    dsTipoDespesa.Tables.Add(M.Listar());
                    bnTipoDespesa.DataSource = dsTipoDespesa.Tables["TipoDespesa"];
                }
                else
                {
                    MessageBox.Show("Erro ao excluir tipo de despesa!");
                }
            }
        }

        private void TbtnCancelar_Click(object sender, EventArgs e)
        {
            bnTipoDespesa.CancelEdit();

            ttbtnSalvar.Enabled = false;
            txtTipoDespesa.Enabled = false;
            tbtnAlterar.Enabled = true;
            tbtnAdicionar.Enabled = true;
            tbtnExcluir.Enabled = true;
        }
    }
}

