using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using Negocios;

namespace LavaJato
{
    public partial class frmPesquisarProduto : Form
    {
        public frmPesquisarProduto()
        {
            InitializeComponent();
            DetalhesLista();
            CarregaLista();
            txtBusca.Focus();
        }


        ConexaoBanco conexaoBanco = new ConexaoBanco();
        DataSet ds;
        OleDbDataAdapter da;
        public string nomeProduto;
        public int codigoProduto;
        public int qtde;
        public decimal valorUnitario;
        public string codigoBarra;
        public string categoria;

        public void DetalhesLista()
        {
            //Detalhes Lista
            ListaProduto.Columns.Add("Código", 60, HorizontalAlignment.Right);
            ListaProduto.Columns.Add("Código Barra", 130, HorizontalAlignment.Right);
            ListaProduto.Columns.Add("Produto", 320, HorizontalAlignment.Left);
            ListaProduto.Columns.Add("Categoria", 130, HorizontalAlignment.Center);
            ListaProduto.Columns.Add("Qtde Estoque", 125, HorizontalAlignment.Center);
            ListaProduto.Columns.Add("Vlr Revenda", 110, HorizontalAlignment.Right);
            ListaProduto.Columns.Add("Vlr Compra", 110, HorizontalAlignment.Right); 
        }

        public void CarregaLista()
        {
            try
            {
                //Carrega Lista de dados
                ds = new DataSet();

                StringBuilder sb = new StringBuilder();

                if (string.IsNullOrEmpty(txtBusca.Text))
                {
                    sb.Append("SELECT * FROM tblProduto");
                }
                else
                {
                    sb.Append("SELECT * FROM tblProduto WHERE CategoriaProduto LIKE '%" + txtBusca.Text + "%'");
                    sb.Append(" OR NomeProduto LIKE '%" + txtBusca.Text + "%'");
                    sb.Append(" OR CodigoBarra LIKE '%" + txtBusca.Text + "%'");
                    sb.Append(" OR DescricaoProduto LIKE '%" + txtBusca.Text + "%'");
                }

                da = new OleDbDataAdapter(sb.ToString(), conexaoBanco.conectar());
                da.Fill(ds, "tblProduto");

                //Obtem os dados do dataSet
                DataTable tabelaVendas = ds.Tables["tblProduto"];

                //Limpa o ListView
                ListaProduto.Items.Clear();

                //Exibe os itens da Lista
                for (int i = 0; i < tabelaVendas.Rows.Count; i++)
                {
                    DataRow dr = tabelaVendas.Rows[i];

                    //Somente  as linhas que não foram deletadas
                    if (dr.RowState != DataRowState.Deleted)
                    {
                        //Define itens da lista
                        ListViewItem itensLista = new ListViewItem(dr["CodigoProduto"].ToString());
                        itensLista.SubItems.Add(dr["CodigoBarra"].ToString());
                        itensLista.SubItems.Add(dr["NomeProduto"].ToString());
                        itensLista.SubItems.Add(dr["CategoriaProduto"].ToString());
                        itensLista.SubItems.Add(dr["QtdeEstoque"].ToString());
                        itensLista.SubItems.Add(Convert.ToDecimal(dr["PrecoUnitario"]).ToString("C"));
                        itensLista.SubItems.Add(Convert.ToDecimal(dr["PrecoCompra"]).ToString("C"));
                        //Inclui os itens na lista
                        ListaProduto.Items.Add(itensLista);
                    }
                }
            }
            catch (Exception msgErro)
            {
                MessageBox.Show(msgErro.Message, "Atenção usuário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmPesquisarProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ListaProduto.Focus();
                codigoProduto = int.Parse(ListaProduto.FocusedItem.SubItems[0].Text);
                codigoBarra = ListaProduto.FocusedItem.SubItems[1].Text;
                nomeProduto = ListaProduto.FocusedItem.SubItems[2].Text;
                qtde = int.Parse(ListaProduto.FocusedItem.SubItems[4].Text);
                valorUnitario = decimal.Parse(ListaProduto.FocusedItem.SubItems[5].Text.Substring(3));
                categoria = ListaProduto.FocusedItem.SubItems[3].Text;

                this.Close();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void ListaProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListaProduto.Focus();
            codigoProduto = int.Parse(ListaProduto.FocusedItem.SubItems[0].Text);
            codigoBarra = ListaProduto.FocusedItem.SubItems[1].Text;
            nomeProduto = ListaProduto.FocusedItem.SubItems[2].Text;
            qtde = int.Parse(ListaProduto.FocusedItem.SubItems[4].Text);
            valorUnitario = decimal.Parse(ListaProduto.FocusedItem.SubItems[5].Text.Substring(3));
            categoria = ListaProduto.FocusedItem.SubItems[3].Text;

            this.Close();
        }

        private void btnLimparBusca_Click(object sender, EventArgs e)
        {
            txtBusca.Clear();
            txtBusca.Focus();
            CarregaLista();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPesquisarProduto_Load(object sender, EventArgs e)
        {
            txtBusca.Focus();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmManterProdutos frm = new frmManterProdutos();
            frm.ShowDialog();

            DetalhesLista();
            CarregaLista();
        }

        private void txtBusca_TextChanged_1(object sender, EventArgs e)
        {
            CarregaLista();
        }
    }
}
