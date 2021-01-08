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
    public partial class frmPesquisarCliente : Form
    {
        public frmPesquisarCliente()
        {
            InitializeComponent();
            txtBusca.Focus();
            DetalhesLista();
            CarregaLista();
        }

        ConexaoBanco conexaoBanco = new ConexaoBanco();
        DataSet ds;
        OleDbDataAdapter da;
        public string nomeCliente;
        public int codigoCliente;
        public string cpfCnpj;
        public string fone;

        public void DetalhesLista()
        {
            //Detalhes Lista
            ListaClientes.Columns.Add("Código", 57, HorizontalAlignment.Center);
            ListaClientes.Columns.Add("Tipo Pessoa", 93, HorizontalAlignment.Center);
            ListaClientes.Columns.Add("CPF/CNPJ", 148, HorizontalAlignment.Left);
            ListaClientes.Columns.Add("Nome/Fantasia",350, HorizontalAlignment.Left);
            ListaClientes.Columns.Add("SobreNome/Razão Social", 300, HorizontalAlignment.Left);
            ListaClientes.Columns.Add("Telefone 01", 120, HorizontalAlignment.Left);
        }

        public void CarregaLista()
        {
            try
            {
                //Carrega Lista de dados
                StringBuilder sb;

                if (string.IsNullOrEmpty(txtBusca.Text))
                {
                    sb = new StringBuilder();
                    sb.Append("SELECT * FROM tblCliente");
                }
                else
                {
                    sb = new StringBuilder();
                    sb.Append("SELECT * FROM tblCliente WHERE CpfCnpj LIKE '%" + txtBusca.Text + "%'");
                    sb.Append(" OR NomeFantasia LIKE '%" + txtBusca.Text + "%'");
                    sb.Append(" OR RazaoSobreNome LIKE '%" + txtBusca.Text + "%'");
                }

                ds = new DataSet();
                da = new OleDbDataAdapter(sb.ToString(), conexaoBanco.conectar());
                da.Fill(ds, "tblCliente");

                //Obtem os dados do dataSet
                DataTable tabelaVendas = ds.Tables["tblCliente"];

                //Limpa o ListView
                ListaClientes.Items.Clear();

                //Exibe os itens da Lista
                for (int i = 0; i < tabelaVendas.Rows.Count; i++)
                {
                    DataRow dr = tabelaVendas.Rows[i];

                    //Somente  as linhas que não foram deletadas
                    if (dr.RowState != DataRowState.Deleted)
                    {
                        //Define itens da lista
                        ListViewItem itensLista = new ListViewItem(dr["CodigoCliente"].ToString());

                        itensLista.SubItems.Add(dr["TipoPessoa"].ToString());
                        itensLista.SubItems.Add(dr["CpfCnpj"].ToString());
                        itensLista.SubItems.Add(dr["NomeFantasia"].ToString());
                        itensLista.SubItems.Add(dr["RazaoSobreNome"].ToString());
                        itensLista.SubItems.Add(dr["Telefone01"].ToString());

                        //Inclui os itens na lista
                        ListaClientes.Items.Add(itensLista);
                    }
                }
            }
            catch (Exception msgErro)
            {
                MessageBox.Show(msgErro.Message, "Atenção usuário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmPesquisarCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ListaClientes.Focus();
                codigoCliente = int.Parse(ListaClientes.FocusedItem.SubItems[0].Text);
                cpfCnpj = ListaClientes.FocusedItem.SubItems[2].Text;
                nomeCliente = ListaClientes.FocusedItem.SubItems[3].Text;
                fone = ListaClientes.FocusedItem.SubItems[5].Text;

                this.Close();
            }
            else if(e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void btnAddNovo_Click(object sender, EventArgs e)
        {
            frmCliente frmC = new frmCliente();
            frmC.ShowDialog();
            CarregaLista();
        }

        private void ListaClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            codigoCliente = int.Parse(ListaClientes.FocusedItem.SubItems[0].Text);
            cpfCnpj = ListaClientes.FocusedItem.SubItems[2].Text;
            nomeCliente = ListaClientes.FocusedItem.SubItems[3].Text;
            fone = ListaClientes.FocusedItem.SubItems[5].Text;

            this.Close();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPesquisarCliente_Load(object sender, EventArgs e)
        {
            txtBusca.Focus();
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            CarregaLista();
        }

        private void btnLimparBusca_Click(object sender, EventArgs e)
        {
            CarregaLista();
        }
    }
}
