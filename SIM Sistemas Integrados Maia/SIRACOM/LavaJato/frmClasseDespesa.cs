using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Negocios.TIPO;
using Negocios.BO;

namespace LavaJato
{
    public partial class frmClasseDespesa : Form
    {
        public frmClasseDespesa()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lblClasseDespesaID.Text))
            {
                AlterarClasseDespesa();
            }
            else
            {
                GravarClasseDespesa();
            }
        }

        private void AlterarClasseDespesa()
        {
            ClasseDespesa classeDespesa = new ClasseDespesa();
            ClasseDespesaBO classeDespesaBo = new ClasseDespesaBO();

            if (!string.IsNullOrEmpty(txtClasseDespesa.Text))
            {
                classeDespesa.ClasseDespesaID = int.Parse(lblClasseDespesaID.Text);
                classeDespesa.NomeClasse = txtClasseDespesa.Text;
                classeDespesaBo.AlterarClasseDespesa(classeDespesa);

                MessageBox.Show("Classe despesa alterado com sucesso", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtClasseDespesa.Clear();
                txtClasseDespesa.Focus();
            }
            else
            {
                MessageBox.Show("Informe o nome da classe", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtClasseDespesa.Focus();
            }
        }

        private void GravarClasseDespesa()
        {
            ClasseDespesa classeDespesa = new ClasseDespesa();
            ClasseDespesaBO classeDespesaBo = new ClasseDespesaBO();

            if (!string.IsNullOrEmpty(txtClasseDespesa.Text))
            {
                classeDespesa.NomeClasse = txtClasseDespesa.Text;
                classeDespesaBo.GravarClasseDespesa(classeDespesa);

                MessageBox.Show("Classe despesa gravado com sucesso", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (MessageBox.Show("Deseja cadastrar uma nova classe de despesa ? ", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    txtClasseDespesa.Focus();
                    txtClasseDespesa.Clear();
                }
                else
                {
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Informe o nome da classe", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtClasseDespesa.Focus();
            }
        }

        public void CarregaDadosClasseDespesa(int classeDespesaID)
        {
            if (classeDespesaID > 0)
            {
                ClasseDespesa classeDespesa = new ClasseDespesa();
                ClasseDespesaBO classeDespesaBo = new ClasseDespesaBO();

                classeDespesa = classeDespesaBo.SelecionarClasseDespesaID(classeDespesaID);

                if (classeDespesa != null)
                {
                    lblClasseDespesaID.Text = classeDespesa.ClasseDespesaID.ToString();
                    txtClasseDespesa.Text = classeDespesa.NomeClasse;
                }
            }
        }

        private void frmClasseDespesa_Load(object sender, EventArgs e)
        {
            txtClasseDespesa.Focus();
        }
    }
}
