using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LavaJato
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //frmApresentacao frm = new frmApresentacao();
            //frm.ShowDialog();

            frmLoginSistema loginSistema = new frmLoginSistema();//Instancia o formulario Login

            if (loginSistema.ShowDialog() == DialogResult.OK)//Condição 
            {
                Application.Run(new frmTelaInicial(loginSistema));
            }
        }
    }
}
