using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Negocios.RVBo;
using Negocios.RVTipo;
using Negocios.TIPO;
using Negocios.BO;
using Negocios;

namespace LavaJato
{
    public partial class frmDetalhamentoProdutosContasReceber : Form
    {
        public frmDetalhamentoProdutosContasReceber()
        {
            InitializeComponent();
        }

        int cont = 0;
        decimal totalItens = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void CarregaItensVendas(int cod)
        {
            DataTable dt = new DataTable();

            RealizarVendasBO realizaVendasBO = new RealizarVendasBO();

            //Pega conta receber
            ContasReceber contaReceber = new ContasReceber();
            ContasReceberBO contaReceberBO = new ContasReceberBO();

            contaReceber = contaReceberBO.RetornaContaReceberID(cod);

            dt = realizaVendasBO.CriaDataTableSelecionaItensVendaRealizada(contaReceber._NumeroVenda);
            totalItens = 0;

            if (dt != null)
            {
                listViewItensProdutos.Items.Clear();

                foreach (DataRow row in dt.Rows)
                {
                    //Adiciona os itens do list view
                    listViewItensProdutos.Items.Add(row.ItemArray[1].ToString());//0
                    listViewItensProdutos.Items[cont].SubItems.Add(row.ItemArray[3].ToString());//3
                    listViewItensProdutos.Items[cont].SubItems.Add((row.ItemArray[4]).ToString());//4
                    listViewItensProdutos.Items[cont].SubItems.Add(Convert.ToDecimal((row.ItemArray[5])).ToString("C"));//5
                    listViewItensProdutos.Items[cont].SubItems.Add(Convert.ToDecimal((row.ItemArray[6])).ToString("C"));//5

                    totalItens += Convert.ToDecimal(row.ItemArray[6]);

                    cont++;
                }
                cont = 0;
                txtQtdeItens.Text = dt.Rows.Count.ToString();
                txtTotalItens.Text = totalItens.ToString("C");

                CarregaDadosVendas(contaReceber._NumeroVenda);

            }
        }

        public void CarregaDadosVendas(int vendaId)
        {
            RealizarVendasBO vendasBO = new RealizarVendasBO();
            RealizarVendasTipos vendas = new RealizarVendasTipos();

            //Pega venda
            vendas = vendasBO.RetornaNumeroVenda(vendaId);

            if (vendas != null)
            {
                lblNumeroVenda.Text = vendas._NumeroVenda.ToString();
                lblTotal.Text = Convert.ToDecimal(vendas._TotalPagar).ToString("C");
                lblDataVenda.Text = vendas._DataVenda.ToString("dd/MM/yyyy");

                //Pega cliente
                CadastroClientes cliente = new CadastroClientes();
                CadastroClientesDAO clienteDao = new CadastroClientesDAO();

                cliente = clienteDao.SelecionaClientePorID(vendas._CodigoCliente);

                if (cliente != null)
                {
                    lblCliente.Text = cliente._Nome;
                    lblCpf.Text = cliente._CPF;
                    lblFone.Text = cliente._Telefone_Celular;
                }
            }
        }
    }
}
