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
    public partial class frmMembro : Form
    {
        private BindingSource bnMembro = new BindingSource();
        private bool bInclusao = false;
        private DataSet dsMembro = new DataSet();

        public frmMembro()
        {
            InitializeComponent();
            LeaveMyLabelsAloneMicrosoft();
            txtNome.MaxLength = 20;
            txtPapel.MaxLength = 10;
        }
        private void LeaveMyLabelsAloneMicrosoft()
        {
            dgvMembro.ForeColor = Color.Black;
            label1.ForeColor = Color.Black;
            label2.ForeColor = Color.Black;
            label3.ForeColor = Color.Black;
        }
        private void Label1_Click(object sender, EventArgs e)
        {

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
            bnMembro.AddNew();
            txtNome.Enabled = true;
            txtPapel.Enabled = true;
            txtNome.Focus();
            ttbtnSalvar.Enabled = true;
            tbtnAlterar.Enabled = false;
            tbtnAdicionar.Enabled = false;
            tbtnExcluir.Enabled = false;
            tbtnCancelar.Enabled = true;
           
            bInclusao = true;
        }

        private void TtbtnSalvar_Click(object sender, EventArgs e)
        {
            bool vazio = false;
            foreach (Control item in this.Controls)
            {
                if (item == null)
                {
                    vazio = true;
                    break;
                }
            }
            if (vazio)
            {
                MessageBox.Show("Preencha devidamente todos os campos.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Membro RegMembro = new Membro();

                RegMembro.Idmembro = Convert.ToInt16(txtId.Text);
                RegMembro.Nomemembro = txtNome.Text;
                RegMembro.Papelmembro = txtPapel.Text;

                if (bInclusao)
                {
                    if (RegMembro.Salvar() > 0)
                    {
                        MessageBox.Show("Membro adicionado com sucesso!");

                        ttbtnSalvar.Enabled = false;
                        txtId.Enabled = false;
                        txtNome.Enabled = false;
                        txtPapel.Enabled = false;
                        ttbtnSalvar.Enabled = false;
                        tbtnAlterar.Enabled = true;
                        tbtnAdicionar.Enabled = true;
                        tbtnExcluir.Enabled = true;
                        tbtnCancelar.Enabled = false;

                        bInclusao = false;

                        dsMembro.Tables.Clear();
                        dsMembro.Tables.Add(RegMembro.Listar());
                        bnMembro.DataSource = dsMembro.Tables["Membro"];
                    }
                    else
                    {
                        MessageBox.Show("Erro ao gravar membro!");
                    }
                }
                else
                {
                    if (RegMembro.Alterar() > 0)
                    {
                        MessageBox.Show("Membro alterado com sucesso!");

                        dsMembro.Tables.Clear();
                        dsMembro.Tables.Add(RegMembro.Listar());
                        txtId.Enabled = false;
                        txtNome.Enabled = false;
                        txtPapel.Enabled = false;
                        ttbtnSalvar.Enabled = false;
                        tbtnAlterar.Enabled = true;
                        tbtnAdicionar.Enabled = true;
                        tbtnExcluir.Enabled = true;
                        tbtnCancelar.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Erro ao gravar membro!");
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

            txtNome.Enabled = true;
            txtPapel.Enabled = true;
            txtNome.Focus();
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
                Membro RegMembro = new Membro();

                RegMembro.Idmembro = Convert.ToInt16(txtId.Text);
                RegMembro.Nomemembro = txtNome.Text;
                RegMembro.Papelmembro = txtPapel.Text;

                if (RegMembro.Excluir() > 0)
                {
                    MessageBox.Show("Membro excluído com sucesso!");
                    Membro M = new Membro();
                    dsMembro.Tables.Clear();
                    dsMembro.Tables.Add(M.Listar());
                    bnMembro.DataSource = dsMembro.Tables["Membro"];
                }
                else
                {
                    MessageBox.Show("Erro ao excluir membro!");
                }
            }
        }

        private void TbtnCancelar_Click(object sender, EventArgs e)
        {

            bnMembro.CancelEdit();

            ttbtnSalvar.Enabled = false;
            txtNome.Enabled = false;
            txtPapel.Enabled = false;
            tbtnAlterar.Enabled = true;
            tbtnAdicionar.Enabled = true;
            tbtnExcluir.Enabled = true;
        }

        private void FrmMembro_Load(object sender, EventArgs e)
        {
            tbtnAdicionar.Enabled = true;
            tbtnAlterar.Enabled = true;
            tbtnCancelar.Enabled = false;
            ttbtnSalvar.Enabled = false;
            tbtnExcluir.Enabled = true;
            tbtnSair.Enabled = true;
               try
               {
                   Membro Membro = new Membro();
                   dsMembro.Tables.Add(Membro.Listar());
                   bnMembro.DataSource = dsMembro.Tables["Membro"];
                   dgvMembro.DataSource = bnMembro;
                   bnvMembro.BindingSource = bnMembro;

                   txtId.DataBindings.Add("TEXT", bnMembro, "id_membro");
                   txtNome.DataBindings.Add("TEXT", bnMembro, "nome_membro");
                   txtPapel.DataBindings.Add("TEXT", bnMembro, "papel_membro");
               }
               catch (Exception ex)
               {
                   MessageBox.Show(ex.Message);
               }
        }
    }
}
