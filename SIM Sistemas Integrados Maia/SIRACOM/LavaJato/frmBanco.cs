using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Negocios.manterBancoTipo;
using Negocios.manterBancoBo;
using Negocios.manterBancoDao;

namespace LavaJato
{
    public partial class frmBanco : Form
    {
        public frmBanco()
        {
            InitializeComponent();
        }


        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            ManterBancoTipo objBancoTipo = new ManterBancoTipo();
            ManterBancoBO objBancoBo = new ManterBancoBO();

            if (!string.IsNullOrEmpty(txtNomeBanco.Text))
            {
                objBancoTipo._NomeBanco = txtNomeBanco.Text;
                objBancoBo.GravarBanco(objBancoTipo);

                MessageBox.Show("Banco cadastrado com sucesso", "Gravação Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (MessageBox.Show("Deseja cadastrar um novo banco ? ", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    txtNomeBanco.Clear();
                    txtNomeBanco.Focus();
                }
                else
                {
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Digite o nome do banco que deseja cadastrar", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNomeBanco.Focus();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmBanco_Load(object sender, EventArgs e)
        {
            txtNomeBanco.Focus();
        }
    }
}
