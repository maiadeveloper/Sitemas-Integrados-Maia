using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Negocios.BO;
using Negocios.TIPO;

namespace LavaJato
{
    public partial class frmItemContaRecebidaTipoRecebimento : Form
    {
        public frmItemContaRecebidaTipoRecebimento()
        {
            InitializeComponent();
        }

        int countRow = 0;
        decimal totalRecebimento = 0;

        public void CarregaItensTipoRecebimento(string tipo, int codigo)
        {
            DataTable dt = new DataTable();
            ItemContaReceberFormaRecebimentoBO itemFormaRecebimentoBO = new ItemContaReceberFormaRecebimentoBO();
            ItemTipoRecebimentoVendaBO itemTipoRecebimentoVendaBO = new ItemTipoRecebimentoVendaBO();

            if (tipo.StartsWith("contaRecebida"))
            {
                dt = itemFormaRecebimentoBO.CriaDataTableSelecionaItemContasReceberFormaRecebimenoto(codigo);
            }
            else
            {
                dt = itemTipoRecebimentoVendaBO.CriaDataTableSelecionaItemVendaFormaRecebimenoto(codigo);
            }

            if (dt.Rows.Count > 0)
            {
                listItenFormaRecebimento.Items.Clear();

                foreach (DataRow row in dt.Rows)
                {
                    //Adiciona os itens do list view
                    listItenFormaRecebimento.Items.Add(row["formaRecebimento"].ToString());
                    listItenFormaRecebimento.Items[countRow].SubItems.Add(Convert.ToDecimal(row["vlrPago"]).ToString("C"));

                    countRow++;

                    totalRecebimento += Convert.ToDecimal(row["vlrPago"]);
                }
                countRow = 0;
                txtTotal.Text = totalRecebimento.ToString("C");

            }
            else
            {
                listItenFormaRecebimento.Items.Add("Crédiario Loja");
            }
        }
    }
}
