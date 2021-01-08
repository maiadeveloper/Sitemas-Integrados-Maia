using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LavaJato
{
    public partial class frmApresentacao : Form
    {
        int valor;//Cria uma variavel

        public frmApresentacao()
        {
            InitializeComponent();
        }

        bool increase = true;

        private void frmApresentacao_Load(object sender, EventArgs e)
        {
            Tempo.Interval = 300;//intervalo
            Tempo.Tick += new EventHandler(this.Tempo_Tick);
            Tempo.Enabled = true;
            this.Opacity = 0;
            lblTextoVesao.Text = "Copyright © " + DateTime.Now.Year + " SIM Sistemas Integrados Maia | Todos os direitos reservados"; 
        }

        private void Tempo_Tick(object sender, EventArgs e)
        {
            if (increase)
            {
                this.Opacity += 0.05D;

                if (this.Opacity == 1)
                {
                    increase = false;

                    this.DialogResult = DialogResult.OK;
                }
            }
        }
    }
}
