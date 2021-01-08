using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using Negocios.TIPO;
using Negocios.BO;

namespace LavaJato
{
    public partial class frmBaseTodasClasseDespesas : Form
    {
        public frmBaseTodasClasseDespesas()
        {
            InitializeComponent();
        }

        int countRow = 0;

        private void frmClasseDespesas_Load(object sender, EventArgs e)
        {
            CarregaClasseDespesas();
            txtBusca.Focus();
        }

        private void CarregaClasseDespesas()
        {
            DataTable dt = new DataTable();
            ClasseDespesaBO classeDespesaBo = new ClasseDespesaBO();

            dt = classeDespesaBo.CriaDataTableClasseDespesas(txtBusca.Text);

            if (dt != null)
            {
                listViewClasseDepesa.Items.Clear();

                foreach (DataRow row in dt.Rows)
                {
                    //Adiciona os itens do list view
                    listViewClasseDepesa.Items.Add(row.ItemArray[0].ToString());//0
                    listViewClasseDepesa.Items[countRow].SubItems.Add((row.ItemArray[1]).ToString());//1
                    countRow++;
                }
                countRow = 0;
            }
        }

        private void btnLimparBusca_Click(object sender, EventArgs e)
        {
            txtBusca.Clear();
            txtBusca.Focus();
            CarregaClasseDespesas();
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            CarregaClasseDespesas();
        }

        private void toolStripSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            frmClasseDespesa frm = new frmClasseDespesa();
            frm.ShowDialog();
            CarregaClasseDespesas();
        }

        private void listViewClasseDepesa_DoubleClick(object sender, EventArgs e)
        {
            int classeDespesaID = int.Parse(listViewClasseDepesa.FocusedItem.SubItems[0].Text);
            frmClasseDespesa frm = new frmClasseDespesa();
            frm.CarregaDadosClasseDespesa(classeDespesaID);
            frm.ShowDialog();
            CarregaClasseDespesas();
        }
    }
}
