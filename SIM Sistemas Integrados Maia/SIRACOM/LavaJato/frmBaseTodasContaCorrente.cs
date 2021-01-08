using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Negocios.BO;

namespace LavaJato
{
    public partial class frmBaseTodasContaCorrente : Form
    {
        public frmBaseTodasContaCorrente()
        {
            InitializeComponent();
            HabilitaTitulos();
        }



        public string NomeContaCorrente { get; set; }
        public int CodigoContaCorrente { get; set; }


        private void btnNovo_Click(object sender, EventArgs e)
        {
            frmContaCorrente frm = new frmContaCorrente();
            frm.ShowDialog();
            CarregaTodasContasCorrentes();
        }



        private void toolStripSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listViewContaCorrente_DoubleClick(object sender, EventArgs e)
        {
            EditarContaCorrente();

        }

        private void EditarContaCorrente()
        {
            if (listViewContaCorrente.Items.Count > 0)
            {
                int contaID = int.Parse(listViewContaCorrente.FocusedItem.SubItems[0].Text);
                frmContaCorrente frm = new frmContaCorrente();
                frm.CarregaDados(contaID);
                frm.ShowDialog();
                CarregaTodasContasCorrentes();
            }
        }

        private void frmBaseTodasContaCorrente_Load(object sender, EventArgs e)
        {
            CarregaTodasContasCorrentes();
        }

        private void HabilitaTitulos()
        {
            foreach (ToolStripItem item in toolStrip1.Items)
            {
                item.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            }
        }

        private void CarregaTodasContasCorrentes()
        {
            DataTable dt = new DataTable();
            ContaCorrenteBO contaCorrenteBo = new ContaCorrenteBO();
            int countRow = 0;

            dt = contaCorrenteBo.RetornaDataTableContaCorrente(txtBusca.Text);

            if (dt != null)
            {
                listViewContaCorrente.Items.Clear();

                foreach (DataRow row in dt.Rows)
                {
                    //Adiciona os itens do list view
                    listViewContaCorrente.Items.Add(row.ItemArray[0].ToString());//0
                    listViewContaCorrente.Items[countRow].SubItems.Add((row.ItemArray[1]).ToString());//1
                    listViewContaCorrente.Items[countRow].SubItems.Add((row.ItemArray[2]).ToString());//1
                    listViewContaCorrente.Items[countRow].SubItems.Add((row.ItemArray[3]).ToString());//1
                    listViewContaCorrente.Items[countRow].SubItems.Add(Convert.ToDecimal(row.ItemArray[4]).ToString("C"));//1
                    countRow++;
                }
            }
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            CarregaTodasContasCorrentes();
        }

        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ContaCorrenteBO contaCorrenteBO = new ContaCorrenteBO();

            if (listViewContaCorrente.Items.Count > 0)
            {
                if (e.ClickedItem.Name == "excluirContaCorrenteToolStripMenuItem")
                {
                    if (MessageBox.Show("Confirma exclusão da conta corrente ? ", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        contaCorrenteBO.DeletarContaCorrente(int.Parse(listViewContaCorrente.FocusedItem.SubItems[0].Text));
                        CarregaTodasContasCorrentes();
                        MessageBox.Show("Conta excluída com sucesso", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    EditarContaCorrente();
                }
            }
        }

        private void btnLimparBusca_Click(object sender, EventArgs e)
        {
            txtBusca.Focus();
            txtBusca.Clear();
            CarregaTodasContasCorrentes();
        }

        private void listViewContaCorrente_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void frmBaseTodasContaCorrente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (listViewContaCorrente.Items.Count > 0)
                {
                    listViewContaCorrente.Focus();
                    CodigoContaCorrente = int.Parse(listViewContaCorrente.FocusedItem.SubItems[0].Text);
                    NomeContaCorrente = "Banco: " + listViewContaCorrente.FocusedItem.SubItems[1].Text + "|  Agência: " + listViewContaCorrente.FocusedItem.SubItems[2].Text + "|  CC: " + listViewContaCorrente.FocusedItem.SubItems[3].Text;
                    this.Close();
                }
            }
        }
    }
}
