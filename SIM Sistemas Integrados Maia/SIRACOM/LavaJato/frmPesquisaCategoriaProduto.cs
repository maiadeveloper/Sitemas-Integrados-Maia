using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Negocios;

namespace LavaJato
{
    public partial class frmPesquisaCategoriaProduto : Form
    {
        public frmPesquisaCategoriaProduto()
        {
            InitializeComponent();

            DetalhesLista();
            CarregaLista();
        }

        ConexaoBanco conexaoBanco = new ConexaoBanco();
        DataSet ds;
        OleDbDataAdapter da;

        public void DetalhesLista()
        {
            //Detalhes Lista
            ListaCategoria.Columns.Add("Código", 57, HorizontalAlignment.Center);
            ListaCategoria.Columns.Add("Descrição", 500, HorizontalAlignment.Left);
        }

        public void CarregaLista()
        {
            try
            {
                string campo;

                if (rbCodigoCategoria.Checked == true)
                {
                    campo = "categoriaID";
                    txtParametro.Focus();
                }
                else
                {
                    campo = "nome";
                    txtParametro.Focus();
                }
                //Carrega Lista de dados
                ds = new DataSet();
                da = new OleDbDataAdapter("SELECT * FROM tblCategoria WHERE " + campo + " LIKE '%" + txtParametro.Text + "%' ORDER BY " + campo, conexaoBanco.conectar());
                da.Fill(ds, "tblCategoriaProduto");

                //Obtem os dados do dataSet
                DataTable tabelaVendas = ds.Tables["tblCategoria"];

                //Limpa o ListView
                ListaCategoria.Items.Clear();

                //Exibe os itens da Lista
                for (int i = 0; i < tabelaVendas.Rows.Count; i++)
                {
                    DataRow dr = tabelaVendas.Rows[i];

                    //Somente  as linhas que não foram deletadas
                    if (dr.RowState != DataRowState.Deleted)
                    {
                        //Define itens da lista
                        ListViewItem itensLista = new ListViewItem(dr["categoriaID"].ToString());

                        itensLista.SubItems.Add(dr["nome"].ToString());

                        //Inclui os itens na lista
                        ListaCategoria.Items.Add(itensLista);
                    }
                }
            }
            catch (Exception msgErro)
            {
                MessageBox.Show(msgErro.Message, "Atenção usuário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void rbCodigoCategoria_CheckedChanged(object sender, EventArgs e)
        {
            txtParametro.Focus();
            txtParametro.Clear();
        }

        private void rbDescricao_CheckedChanged(object sender, EventArgs e)
        {
            txtParametro.Focus();
            txtParametro.Clear();
        }

        private void txtParametro_TextChanged(object sender, EventArgs e)
        {
            CarregaLista();
        }
    }
}
