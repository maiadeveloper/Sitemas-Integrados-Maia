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
    public partial class frmBaseTodasDespesas : Form
    {
        public frmBaseTodasDespesas()
        {
            InitializeComponent();
        }

        private void frmBaseTodasDespesas_Load(object sender, EventArgs e)
        {
            txtDateInicial.Value = Convert.ToDateTime("01/01/2013");
            txtDataFinal.Value = Convert.ToDateTime("01/01/2020");

            CarregaTodasDespesas();

            HabilitaTitulos();
        }

        int countRow;
        decimal total;

        private void HabilitaTitulos()
        {
            foreach (ToolStripItem item in toolStrip1.Items)
            {
                item.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            }
        }

        private void CarregaTodasDespesas()
        {
            DataSet ds = new DataSet();
            DespesasBO despesasBO = new DespesasBO();
            countRow = 0;

            ds = despesasBO.TodasDespesas(DateTime.Parse(txtDateInicial.Text), DateTime.Parse(txtDataFinal.Text));

            if (ds != null)
            {
                countRow = 0;
                listViewDespesas.Items.Clear();
                total = 0;

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    listViewDespesas.Items.Add(row.ItemArray[0].ToString());
                    listViewDespesas.Items[countRow].SubItems.Add(Convert.ToDateTime(row.ItemArray[1]).ToString("dd/MM/yyyy"));
                    listViewDespesas.Items[countRow].SubItems.Add((row.ItemArray[2]).ToString());
                    listViewDespesas.Items[countRow].SubItems.Add((row.ItemArray[5]).ToString());
                    listViewDespesas.Items[countRow].SubItems.Add((row.ItemArray[7  ]).ToString());
                    listViewDespesas.Items[countRow].SubItems.Add(Convert.ToDecimal(row.ItemArray[3]).ToString("C"));
                    countRow++;
                    total += Convert.ToDecimal(row.ItemArray[3].ToString());
                }

                txtTotal.Text = total.ToString("C");
                txtQtde.Text = listViewDespesas.Items.Count.ToString();
            }
        }

        private void toolStripSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButtono_Click(object sender, EventArgs e)
        {
            frmDespesa frm = new frmDespesa();
            frm.ShowDialog();
            CarregaTodasDespesas();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            CarregaTodasDespesas();
        }

        private void frmBaseTodasDespesas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CarregaTodasDespesas();
            }
        }

        private void btnLimparBusca_Click(object sender, EventArgs e)
        {
            txtDateInicial.Value = Convert.ToDateTime("01/01/2013");
            txtDataFinal.Value = Convert.ToDateTime("01/01/2020");
            CarregaTodasDespesas();
        }
    }
}
