using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Negocios;
using Negocios.TIPO;
using Negocios.BO;
using Negocios.RVTipo;
using Negocios.RVBo;
using Negocios.RVDao;

namespace LavaJato
{
    public partial class frmBaseTodosClientes : Form
    {
        int countRow = 0;

        public frmBaseTodosClientes()
        {
            InitializeComponent();
        }

        private void HabilitaTitulos()
        {
            foreach (ToolStripItem item in toolStrip1.Items)
            {
                item.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            }
        }

        private void CarregaClientes()
        {
            DataTable dt = new DataTable();
            CadastroClientes cliente = new CadastroClientes();
            CadastroClientesDAO clienteDAO = new CadastroClientesDAO();

            dt = clienteDAO.CriaDataTableSelecionaTodosClientes(txtBusca.Text);

            if (dt != null)
            {
                listViewClientes.Items.Clear();

                foreach (DataRow row in dt.Rows)
                {
                    //Adiciona os itens do list view
                    listViewClientes.Items.Add(row.ItemArray[0].ToString());//0
                    listViewClientes.Items[countRow].SubItems.Add((row.ItemArray[2]).ToString());//1
                    listViewClientes.Items[countRow].SubItems.Add(row.ItemArray[3].ToString());//2
                    listViewClientes.Items[countRow].SubItems.Add(row.ItemArray[1].ToString());//3
                    listViewClientes.Items[countRow].SubItems.Add((row.ItemArray[4]).ToString());//4
                    listViewClientes.Items[countRow].SubItems.Add((row.ItemArray[12]).ToString());//5
                    listViewClientes.Items[countRow].SubItems.Add((row.ItemArray[13]).ToString());//6

                    countRow++;
                }
                countRow = 0;
            }
        }

        private void frmBaseTodosClientes_Load(object sender, EventArgs e)
        {
            txtBusca.Focus();
            CarregaClientes();
            HabilitaTitulos();
        }

        private void toolStripSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButtono_Click(object sender, EventArgs e)
        {
            frmCliente fcliente = new frmCliente();
            fcliente.ShowDialog();
            CarregaClientes();
        }

        private void btnLimparBusca_Click_1(object sender, EventArgs e)
        {
            txtBusca.Clear();
            txtBusca.Focus();
            CarregaClientes();
        }

        private void txtBusca_TextChanged_1(object sender, EventArgs e)
        {
            CarregaClientes();
        }

        private void ExcluirToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (listViewClientes.Items.Count > 0)
            {
                if (MessageBox.Show("Confirma exclusão deste cliente: " + listViewClientes.FocusedItem.SubItems[1].Text + " ?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    CadastroFornecedoresBO fornecerdorBO = new CadastroFornecedoresBO();
                    int cod = int.Parse(listViewClientes.FocusedItem.SubItems[0].Text);

                    if (ConsultaContaReceberClienteCod(cod)== false)
                    {
                        fornecerdorBO.ExcluirFornecedor(cod);
                        MessageBox.Show("Cliente excluido com sucesso", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtBusca.Clear();
                        CarregaClientes();
                    }
                    else
                    {
                        MessageBox.Show("Este cliente não pode ser excluido pois ele encontra-se vinculado a um evento no sistema", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                }
            }
        }

        private bool ConsultaContaReceberClienteCod(int cod)
        {
            bool resp = false;

            if (cod > 0)
            {
                RealizarVendasTipos realizaVenda = new RealizarVendasTipos();
                RealizarVendasBO realizaVendaBO = new RealizarVendasBO();

                realizaVenda = realizaVendaBO.RetornaVendaClienteId(cod);

                if (realizaVenda != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            return resp;
        }

        private void listViewClientes_DoubleClick(object sender, EventArgs e)
        {
            int codigoCliente = int.Parse(listViewClientes.FocusedItem.SubItems[0].Text);

            frmCliente fCliente = new frmCliente();
            fCliente.CarregaClienteSelecionado(codigoCliente);
            fCliente.ShowDialog();

            CarregaClientes();
        }
    }
}
