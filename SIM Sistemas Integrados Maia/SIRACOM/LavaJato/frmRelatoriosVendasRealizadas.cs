using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using Negocios.RVBo;
using Negocios.RVDao;

namespace LavaJato
{
    public partial class frmRelatoriosVendasRealizadas : Form
    {
        public frmRelatoriosVendasRealizadas()
        {
            InitializeComponent();
        }

        OleDbDataAdapter da;
        DataSet ds;
        OleDbCommand cmd;
        RealizarVendasBO realizaVendasBO = new RealizarVendasBO();

        private void CarregaRelatorioVendasRealizadas()
        {
            try
            {
                ds = new DataSet();

                da = realizaVendasBO.ExibeTodasVendas(26);
                da.Fill(ds, "tblRealizarVenda");

                RelatorioVendasRealizadas rv = new RelatorioVendasRealizadas();
                rv.SetDataSource(ds);
                crv.ReportSource = rv;
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CarregaRelatorioItensVendasRealizadas()
        {
            try
            {
                ds = new DataSet();

                da = realizaVendasBO.ExibeItensVendasRealizadas(26);
                da.Fill(ds, "tblItemVenda");

                RelatorioItensVendas rv = new RelatorioItensVendas();

                rv.SetDataSource(ds);
                crv.ReportSource = rv;
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmRelatoriosVendasRealizadas_Load(object sender, EventArgs e)
        {
            CarregaRelatorioVendasRealizadas();
            CarregaRelatorioItensVendasRealizadas();
        }
    }
}
