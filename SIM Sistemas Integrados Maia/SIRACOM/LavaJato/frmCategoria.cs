using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Negocios;

namespace LavaJato
{
    public partial class frmCategoria : Form
    {
        public frmCategoria()
        {
            InitializeComponent();

            NovaCategoria(false);
        }

        CategoriaBO categoriaBo;
        Categoria categoria;
        public string novaCategoria;

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            categoriaBo = new CategoriaBO();
            categoria = new Categoria();

            if (txtCategoria.Text.Trim() == string.Empty)
            {
                txtCategoria.Focus();
                MessageBox.Show("Informe a categoria do produto !!!", "Atenção - campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            categoria._Nome = txtCategoria.Text;
            novaCategoria = txtCategoria.Text;

            categoriaBo.GravarCategoria(categoria);
            

            MessageBox.Show("Categoria do produto foi gravado com sucesso", "Gravação OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtCategoria.Text = string.Empty;

            NovaCategoria(false);

            this.Close();
        }

        protected void NovaCategoria(Boolean trueFalse)
        {
            btnSalvar.Enabled = trueFalse;
            txtCategoria.Enabled = trueFalse;
            txtCategoria.Focus();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            NovaCategoria(true);
        }
    }
}
