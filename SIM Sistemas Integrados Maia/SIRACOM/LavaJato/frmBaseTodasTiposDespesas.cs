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
    public partial class frmBaseTodasTiposDespesas : Form
    {
        public frmBaseTodasTiposDespesas()
        {
            InitializeComponent();
        }

        int countRow = 0;

        private void btnNovo_Click(object sender, EventArgs e)
        {
            frmTipoDespesa frm = new frmTipoDespesa();
            frm.ShowDialog();
            CarregaTipoDespesas();
        }

        private void toolStripSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CarregaTipoDespesas()
        {
            DataTable dt = new DataTable();
            TipoDespesaBO tipoDespesasBO = new TipoDespesaBO();

            dt = tipoDespesasBO.CriaDataTableTipoDespesa(txtBusca.Text);

            if (dt != null)
            {
                listViewTipoDespesas.Items.Clear();

                foreach (DataRow row in dt.Rows)
                {
                    //Adiciona os itens do list view
                    listViewTipoDespesas.Items.Add(row.ItemArray[0].ToString());//0
                    listViewTipoDespesas.Items[countRow].SubItems.Add((row.ItemArray[1]).ToString());//1
                    listViewTipoDespesas.Items[countRow].SubItems.Add(row.ItemArray[2].ToString());//2
                    countRow++;
                }
                countRow = 0;
            }
        }

        private void frmBaseTodasTiposDespesas_Load(object sender, EventArgs e)
        {
            CarregaTipoDespesas();
        }

        private void listViewTipoDespesas_DoubleClick(object sender, EventArgs e)
        {
            int tipoDespesaID = int.Parse(listViewTipoDespesas.FocusedItem.SubItems[0].Text);

            frmTipoDespesa frm = new frmTipoDespesa();
            frm.CarregaDados(tipoDespesaID);
            frm.ShowDialog();
            CarregaTipoDespesas();
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            CarregaTipoDespesas();
        }

        private void btnLimparBusca_Click(object sender, EventArgs e)
        {
            CarregaTipoDespesas();
            txtBusca.Clear();
            txtBusca.Focus();
        }
    }
}
