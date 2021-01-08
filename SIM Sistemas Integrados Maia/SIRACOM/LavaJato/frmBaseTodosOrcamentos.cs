using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Negocios.TIPO;
using Negocios.BO;

namespace LavaJato
{
    public partial class frmBaseTodosOrcamentos : Form
    {
        public frmBaseTodosOrcamentos()
        {
            InitializeComponent();
        }

        int countRow = 0;
        decimal total = 0;

        private void HabilitaTitulos()
        {
            foreach (ToolStripItem item in toolStrip1.Items)
            {
                item.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            }
        }

        public void CarregaOrcamentos()
        {
            DataSet ds = new DataSet();
            OrcamentoBO orcamentoBO = new OrcamentoBO();

            ds = orcamentoBO.SelecionaOrcamentos(DateTime.Parse(txtDateInicial.Text), DateTime.Parse(txtDataFinal.Text));

            if (ds != null)
            {
                listViewOrcamento.Items.Clear();
                countRow = 0;
                total = 0;

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    listViewOrcamento.Items.Add(row.ItemArray[0].ToString());
                    listViewOrcamento.Items[countRow].SubItems.Add(string.Format("{0:dd/MM/yyyy}", row.ItemArray[1]));
                    listViewOrcamento.Items[countRow].SubItems.Add(row.ItemArray[7].ToString());
                    listViewOrcamento.Items[countRow].SubItems.Add(row.ItemArray[8].ToString());
                    listViewOrcamento.Items[countRow].SubItems.Add(string.Format("{0:C2}", row.ItemArray[3]));
                    listViewOrcamento.Items[countRow].SubItems.Add(string.Format("{0:C2}", row.ItemArray[4]));
                    countRow++;

                    total += Convert.ToDecimal(row.ItemArray[4]);
                }

                countRow = 0;
                txtQtde.Text = ds.Tables[0].Rows.Count.ToString();
                txtTotal.Text = string.Format("{0:C2}", total);
            }
        }

        private void frmBaseTodosOrcamentos_Load(object sender, EventArgs e)
        {
            txtDateInicial.Text = "01/01/2013";
            txtDataFinal.Text = DateTime.Now.ToString();

            HabilitaTitulos();

            CarregaOrcamentos();
        }

        private void frmBaseTodosOrcamentos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CarregaOrcamentos();
            }
        }

        private void listViewOrcamento_DoubleClick(object sender, EventArgs e)
        {
              FrmRelatorioOrcamento frmRO = new FrmRelatorioOrcamento();
              frmRO.SelecionaOrcamentoPorID(Convert.ToInt32(listViewOrcamento.FocusedItem.SubItems[0].Text));
              frmRO.ShowDialog();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            CarregaOrcamentos();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmRealizarOrcamento frmRO = new frmRealizarOrcamento();
            frmRO.ShowDialog();
            CarregaOrcamentos();
        }
    }
}
