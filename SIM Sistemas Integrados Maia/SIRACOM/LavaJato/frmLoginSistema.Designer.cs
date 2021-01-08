namespace LavaJato
{
    partial class frmLoginSistema
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoginSistema));
            this.GbLogin = new System.Windows.Forms.GroupBox();
            this.lblSobre = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblErro = new System.Windows.Forms.Label();
            this.btnImagen1 = new System.Windows.Forms.Button();
            this.txtLogin = new LavaJato.TextBoxPersonalizado();
            this.btnErro = new System.Windows.Forms.Button();
            this.txtUsuario = new LavaJato.TextBoxPersonalizado();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnImagen2 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.viewRealizarVendaTableAdapter1 = new LavaJato.dsSiradTableAdapters.ViewRealizarVendaTableAdapter();
            this.GbLogin.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GbLogin
            // 
            this.GbLogin.BackColor = System.Drawing.Color.Transparent;
            this.GbLogin.Controls.Add(this.lblSobre);
            this.GbLogin.Controls.Add(this.button1);
            this.GbLogin.Controls.Add(this.lblErro);
            this.GbLogin.Controls.Add(this.btnImagen1);
            this.GbLogin.Controls.Add(this.txtLogin);
            this.GbLogin.Controls.Add(this.btnErro);
            this.GbLogin.Controls.Add(this.txtUsuario);
            this.GbLogin.Controls.Add(this.lblLogin);
            this.GbLogin.Controls.Add(this.lblUsuario);
            this.GbLogin.Controls.Add(this.btnEntrar);
            this.GbLogin.Controls.Add(this.btnCancelar);
            resources.ApplyResources(this.GbLogin, "GbLogin");
            this.GbLogin.ForeColor = System.Drawing.Color.White;
            this.GbLogin.Name = "GbLogin";
            this.GbLogin.TabStop = false;
            // 
            // lblSobre
            // 
            resources.ApplyResources(this.lblSobre, "lblSobre");
            this.lblSobre.ForeColor = System.Drawing.Color.White;
            this.lblSobre.Name = "lblSobre";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.button1, "button1");
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Beige;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // lblErro
            // 
            resources.ApplyResources(this.lblErro, "lblErro");
            this.lblErro.ForeColor = System.Drawing.Color.White;
            this.lblErro.Name = "lblErro";
            // 
            // btnImagen1
            // 
            this.btnImagen1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnImagen1, "btnImagen1");
            this.btnImagen1.FlatAppearance.BorderColor = System.Drawing.Color.Beige;
            this.btnImagen1.FlatAppearance.BorderSize = 0;
            this.btnImagen1.Name = "btnImagen1";
            this.btnImagen1.UseVisualStyleBackColor = false;
            // 
            // txtLogin
            // 
            this.txtLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.txtLogin, "txtLogin");
            this.txtLogin.Name = "txtLogin";
            this.toolTip1.SetToolTip(this.txtLogin, resources.GetString("txtLogin.ToolTip"));
            this.txtLogin.UseSystemPasswordChar = true;
            // 
            // btnErro
            // 
            this.btnErro.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnErro.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            resources.ApplyResources(this.btnErro, "btnErro");
            this.btnErro.ForeColor = System.Drawing.Color.White;
            this.btnErro.Name = "btnErro";
            this.btnErro.UseVisualStyleBackColor = false;
            this.btnErro.Click += new System.EventHandler(this.btnErro_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            resources.ApplyResources(this.txtUsuario, "txtUsuario");
            this.txtUsuario.Name = "txtUsuario";
            this.toolTip1.SetToolTip(this.txtUsuario, resources.GetString("txtUsuario.ToolTip"));
            // 
            // lblLogin
            // 
            resources.ApplyResources(this.lblLogin, "lblLogin");
            this.lblLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblLogin.ForeColor = System.Drawing.Color.White;
            this.lblLogin.Name = "lblLogin";
            // 
            // lblUsuario
            // 
            resources.ApplyResources(this.lblUsuario, "lblUsuario");
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Name = "lblUsuario";
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnEntrar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            resources.ApplyResources(this.btnEntrar, "btnEntrar");
            this.btnEntrar.ForeColor = System.Drawing.Color.White;
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            resources.ApplyResources(this.btnCancelar, "btnCancelar");
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnImagen2
            // 
            this.btnImagen2.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnImagen2, "btnImagen2");
            this.btnImagen2.FlatAppearance.BorderColor = System.Drawing.Color.Beige;
            this.btnImagen2.FlatAppearance.BorderSize = 0;
            this.btnImagen2.Name = "btnImagen2";
            this.btnImagen2.UseVisualStyleBackColor = false;
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnImagen2);
            this.panel1.Controls.Add(this.GbLogin);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // viewRealizarVendaTableAdapter1
            // 
            this.viewRealizarVendaTableAdapter1.ClearBeforeFill = true;
            // 
            // frmLoginSistema
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLoginSistema";
            this.Load += new System.EventHandler(this.frmLoginSistema_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmLoginSistema_KeyDown);
            this.GbLogin.ResumeLayout(false);
            this.GbLogin.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GbLogin;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblUsuario;
        private TextBoxPersonalizado txtLogin;
        private System.Windows.Forms.Label lblErro;
        private System.Windows.Forms.Button btnImagen2;
        private System.Windows.Forms.Button btnImagen1;
        public TextBoxPersonalizado txtUsuario;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnErro;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel panel1;
        private dsSiradTableAdapters.ViewRealizarVendaTableAdapter viewRealizarVendaTableAdapter1;
        private System.Windows.Forms.Label lblSobre;
        private System.Windows.Forms.Button button1;
    }
}