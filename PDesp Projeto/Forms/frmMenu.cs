using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace PDesp_Projeto
{

    public partial class btnMax : Form
    {
        public static SqlConnection conexao;
        public btnMax()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            pnlTitle.BackColor = Color.FromArgb(48,51,48);
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is MdiClient)
                {
                    ctrl.BackColor = Color.FromKnownColor(KnownColor.Control);
                }
            }
            try
            {
                conexao = new SqlConnection("Data Source = DUSNIK; Initial Catalog = LP2; Integrated Security = True");
                conexao.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro de banco de dados: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Outros errors: " + ex.Message);
            }
        }

        private void TsbtnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void MembroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMembro membro = new frmMembro
            {
                MdiParent = this
            };
            membro.Show();
        }

        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TipoDespesasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTipoDespesa tipodespesa = new frmTipoDespesa();
            tipodespesa.MdiParent = this;
            tipodespesa.Show();
        }

        private void FrmMenu_MdiChildActivate(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (this.ActiveMdiChild != f)
                    f.Hide();
            }
        }

        private void SobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSobre sobre = new frmSobre();
            sobre.MdiParent = this;
            sobre.Show();
        }

        private void DespesasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDespesa despesa = new frmDespesa();
            despesa.MdiParent = this;
            despesa.Show();
        }

        private void Panel1_Click(object sender, EventArgs e)
        {
        }

        private void Panel2_Click(object sender, EventArgs e)
        {
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
            else
            {
                WindowState = FormWindowState.Maximized;
            }
        }
    }
}
