using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Windows.Forms;
using Negocios;

namespace LavaJato
{
    public partial class frmPesquisarFornecedores : Form
    {
        public frmPesquisarFornecedores()
        {
            InitializeComponent();

            DetalhesLista();
            CarregaLista();
        }

        ConexaoBanco conexaoBanco = new ConexaoBanco();
        DataSet ds;
        OleDbDataAdapter da;
        public string nomeFornecedor;
        public int codigoFornecedor;
        public string cnpj;
        public string cidade;
        public string uf;

        private void txtParametro_TextChanged(object sender, EventArgs e)
        {
            CarregaLista();
        }

        public void DetalhesLista()
        {
            //Detalhes Lista
            ListaFornecedores.Columns.Add("Código", 70, HorizontalAlignment.Center);
            ListaFornecedores.Columns.Add("Razão Social",250, HorizontalAlignment.Left);
            ListaFornecedores.Columns.Add("Nome Fantasia", 350, HorizontalAlignment.Left);
            ListaFornecedores.Columns.Add("CNPJ", 150, HorizontalAlignment.Left);
            ListaFornecedores.Columns.Add("Cidade", 250, HorizontalAlignment.Left);
            ListaFornecedores.Columns.Add("UF", 50, HorizontalAlignment.Left);
        }

        public void CarregaLista()
        {
            try
            {
                string campo;

                if (rbCpfCnpj.Checked == true)
                {
                    campo = "CNPJ";
                }
                else if (rbNomeFantasia.Checked == true)
                {
                    campo = "Nome_Fantasia";
                }
                else
                {
                    campo = "Razao_Social";
                }

                //Carrega Lista de dados
                ds = new DataSet();
                da = new OleDbDataAdapter("SELECT * FROM tblFornecedor WHERE " + campo + " LIKE '%" + txtParametro.Text + "%' ORDER BY " + campo, conexaoBanco.conectar());
                da.Fill(ds, "tblFornecedor");

                //Obtem os dados do dataSet
                DataTable tabelaVendas = ds.Tables["tblFornecedor"];

                //Limpa o ListView
                ListaFornecedores.Items.Clear();

                //Exibe os itens da Lista
                for (int i = 0; i < tabelaVendas.Rows.Count; i++)
                {
                    DataRow dr = tabelaVendas.Rows[i];

                    //Somente  as linhas que não foram deletadas
                    if (dr.RowState != DataRowState.Deleted)
                    {
                        //Define itens da lista
                        ListViewItem itensLista = new ListViewItem(dr["CodigoFornecedor"].ToString());
                        itensLista.SubItems.Add(dr["Razao_Social"].ToString());
                        itensLista.SubItems.Add(dr["Nome_Fantasia"].ToString());
                        itensLista.SubItems.Add(dr["CNPJ"].ToString());
                        itensLista.SubItems.Add(dr["Cidade"].ToString());
                        itensLista.SubItems.Add(dr["UF"].ToString());
                        //Inclui os itens na lista
                        ListaFornecedores.Items.Add(itensLista);
                    }
                }
            }
            catch (Exception msgErro)
            {
                MessageBox.Show(msgErro.Message, "Atenção usuário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmPesquisarFornecedores_KeyDown(object sender, KeyEventArgs e)
        {
             if (e.KeyCode == Keys.Enter)
             {
                 ListaFornecedores.Focus();
                 codigoFornecedor = int.Parse(ListaFornecedores.FocusedItem.SubItems[0].Text);
                 nomeFornecedor = ListaFornecedores.FocusedItem.SubItems[1].Text;
                 cnpj = ListaFornecedores.FocusedItem.SubItems[3].Text;
                 cidade = ListaFornecedores.FocusedItem.SubItems[4].Text;
                 uf = ListaFornecedores.FocusedItem.SubItems[5].Text;
                 this.Close();
             }
        }

        private void rbCpfCnpj_CheckedChanged(object sender, EventArgs e)
        {
            txtParametro.Focus();
            txtParametro.Clear();
        }

        private void rbSobreNomeRazao_CheckedChanged(object sender, EventArgs e)
        {
            txtParametro.Focus();
            txtParametro.Clear();
        }

        private void rbNomeFantasia_CheckedChanged(object sender, EventArgs e)
        {
            txtParametro.Focus();
            txtParametro.Clear();
        }

        private void btnAddNovo_Click(object sender, EventArgs e)
        {
            frmCadastroFornecedores frmFornecedores = new frmCadastroFornecedores();
            frmFornecedores.ShowDialog();
            CarregaLista();
        }

        private void ListaFornecedores_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListaFornecedores.Focus();
            codigoFornecedor = int.Parse(ListaFornecedores.FocusedItem.SubItems[0].Text);
            nomeFornecedor = ListaFornecedores.FocusedItem.SubItems[1].Text;
            cnpj = ListaFornecedores.FocusedItem.SubItems[3].Text;
            cidade = ListaFornecedores.FocusedItem.SubItems[4].Text;
            uf = ListaFornecedores.FocusedItem.SubItems[5].Text;
            this.Close();
        }
    }
}
