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
    public partial class frmDespesa : Form
    {
        private BindingSource bnDespesa = new BindingSource();
        private bool bInclusao = false;
        private DataSet dsDespesa = new DataSet();
        private DataSet dsMembro = new DataSet();
        private DataSet dsTipoDespesa = new DataSet();
        public frmDespesa()
        {
            InitializeComponent();
            LeaveMyLabelsAloneMicrosoft();

            rtxtObservacao.MaxLength = 50;
            txtValor.MaxLength = 10;
        }

        private void TbtnSair_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void TbtnAdicionar_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
            EnableOrDisable(true);
            bnDespesa.AddNew();
            bInclusao = true;

            EnableOrDisableButtons(true, false, false, false, true);
        }
        private void LeaveMyLabelsAloneMicrosoft()
        {
            dgvDespesa.ForeColor = Color.Black;
            label1.ForeColor = Color.Black;
            label3.ForeColor = Color.Black;
            label4.ForeColor = Color.Black;
            label5.ForeColor = Color.Black;
            label6.ForeColor = Color.Black;
            label7.ForeColor = Color.Black;
        }
        private void FrmDespesa_Load(object sender, EventArgs e)
        {
            EnableOrDisable(false);
            EnableOrDisableButtons(false, true, true, true, false);
            try
            {
                Despesa despesa = new Despesa();
                dsDespesa.Tables.Add(despesa.Listar());
                bnDespesa.DataSource = dsDespesa.Tables["Despesa"];
                dgvDespesa.DataSource = bnDespesa;
                bnvDespesa.BindingSource = bnDespesa;

                txtId.DataBindings.Add("TEXT", bnDespesa, "id_despesa");
                txtData.DataBindings.Add("TEXT", bnDespesa, "data_despesa"); //is it though?
                txtValor.DataBindings.Add("TEXT", bnDespesa, "valor_despesa");
                rtxtObservacao.DataBindings.Add("TEXT", bnDespesa, "obs_despesa");
                //^
                Membro membro = new Membro();
                dsMembro.Tables.Add(membro.Listar());

                cbxMembro.DataSource = dsMembro.Tables["Membro"];
                cbxMembro.DisplayMember = "nome_membro";
                cbxMembro.ValueMember = "id_membro";

                cbxMembro.DataBindings.Add("SelectedValue", bnDespesa, "membro_id_membro");

                TipoDespesa tipoDespesa = new TipoDespesa();
                dsTipoDespesa.Tables.Add(tipoDespesa.Listar());

                cbxTipoDespesa.DataSource = dsTipoDespesa.Tables["TipoDespesa"];
                cbxTipoDespesa.DisplayMember = "nome_tipodespesa";
                cbxTipoDespesa.ValueMember = "id_tipodespesa";

                cbxTipoDespesa.DataBindings.Add("SelectedValue", bnDespesa, "tipodespesa_id_tipodespesa");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
         private void EnableOrDisable(bool x)
        {
            txtData.Enabled = x;
            txtValor.Enabled = x;
            cbxMembro.Enabled = x;
            cbxTipoDespesa.Enabled = x;
            rtxtObservacao.Enabled = x;
            if (x)
            {
                cbxTipoDespesa.DroppedDown = true;
            }
        }
        private void EnableOrDisableButtons(bool a, bool b, bool c, bool d, bool e)
        {
            ttbtnSalvar.Enabled = a;
            tbtnAlterar.Enabled = b;
            tbtnAdicionar.Enabled = c;
            tbtnExcluir.Enabled = d;
            tbtnCancelar.Enabled = e;
        }

        private void TbtnCancelar_Click(object sender, EventArgs e)
        {
            EnableOrDisable(false);
            EnableOrDisableButtons(false, true, true, true, false);
            bnDespesa.CancelEdit();
        }

        private void TtbtnSalvar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cbxMembro.SelectedItem.ToString());
            bool vazio = false;
            double valor;
            DateTime data;
            foreach (Control item in this.Controls)
            {
                if (item == null)
                {
                    vazio = true;
                    break;
                }
            }
            if (!(double.TryParse(txtValor.Text, out valor)) || vazio || !(DateTime.TryParse(txtData.Text, out data)))
            {
                MessageBox.Show("Preencha devidamente todos os campos.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Information);
        
            }
            else
            {
                Despesa RegDespesa = new Despesa();

                RegDespesa.Iddespesa = Convert.ToInt16(txtId.Text);
                RegDespesa.Idmembro = Convert.ToInt16(cbxMembro.SelectedValue); //erros em potêncial
                RegDespesa.Idtipodespesa = Convert.ToInt16(cbxTipoDespesa.SelectedValue);
                RegDespesa.Obsdespesa = rtxtObservacao.Text;
                RegDespesa.Valordespesa = Convert.ToDouble(txtValor.Text);
                RegDespesa.Datadespesa = Convert.ToDateTime(txtData.Text);

                if (bInclusao)
                {
                    if (RegDespesa.Salvar() > 0)
                    {
                        MessageBox.Show("Despesa adicionada com sucesso.", "Entrada Realizada");
                        EnableOrDisable(false);
                        EnableOrDisableButtons(false, true, true, true, false);

                        bInclusao = false;

                        dsDespesa.Tables.Clear();
                        dsDespesa.Tables.Add(RegDespesa.Listar());
                        bnDespesa.DataSource = dsDespesa.Tables["Despesa"];
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível gravar a despesa.", "Erro", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (RegDespesa.Alterar() > 0)
                    {
                        MessageBox.Show("Despesa alterada com sucesso.", "Entrada Realizada");
                        EnableOrDisable(false);
                        EnableOrDisableButtons(false, true, true, true, false);
                        dsDespesa.Tables.Clear();
                        dsDespesa.Tables.Add(RegDespesa.Listar());
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível gravar a despesa.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void RtxtObservacao_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void RtxtObservacao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ttbtnSalvar.PerformClick();
            }
        }

        private void CbxTipoDespesa_SelectedValueChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1 && !(cbxTipoDespesa.DroppedDown))
            {
                cbxMembro.DroppedDown = true;
            }
        }

        private void CbxMembro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1 && !(cbxMembro.DroppedDown) && !(cbxTipoDespesa.DroppedDown))
            {
                txtData.Focus();
            }
        }

        private void TxtData_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtValor.Focus();
            }
        }

        private void TxtValor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                rtxtObservacao.Focus();
            }
        }
    }
}
