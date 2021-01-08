namespace LavaJato
{
    partial class frmContaCorrente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmContaCorrente));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddBanco = new System.Windows.Forms.Button();
            this.lblContaCorrente = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSaldo = new LavaJato.TextBoxPersonalizado();
            this.label1 = new System.Windows.Forms.Label();
            this.txtContaCorrente = new LavaJato.TextBoxPersonalizado();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAgencia = new LavaJato.TextBoxPersonalizado();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBanco = new LavaJato.ComboBoxPersonalizado();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSalvar = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnAddBanco);
            this.panel1.Controls.Add(this.lblContaCorrente);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtSaldo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtContaCorrente);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtAgencia);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtBanco);
            this.panel1.Location = new System.Drawing.Point(12, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(489, 133);
            this.panel1.TabIndex = 88;
            // 
            // btnAddBanco
            // 
            this.btnAddBanco.Image = ((System.Drawing.Image)(resources.GetObject("btnAddBanco.Image")));
            this.btnAddBanco.Location = new System.Drawing.Point(450, 31);
            this.btnAddBanco.Name = "btnAddBanco";
            this.btnAddBanco.Size = new System.Drawing.Size(28, 28);
            this.btnAddBanco.TabIndex = 50;
            this.btnAddBanco.TabStop = false;
            this.btnAddBanco.UseVisualStyleBackColor = true;
            this.btnAddBanco.Click += new System.EventHandler(this.btnAddBanco_Click);
            // 
            // lblContaCorrente
            // 
            this.lblContaCorrente.AutoSize = true;
            this.lblContaCorrente.Location = new System.Drawing.Point(65, 15);
            this.lblContaCorrente.Name = "lblContaCorrente";
            this.lblContaCorrente.Size = new System.Drawing.Size(13, 13);
            this.lblContaCorrente.TabIndex = 40;
            this.lblContaCorrente.Text = "0";
            this.lblContaCorrente.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(303, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Saldo($)";
            // 
            // txtSaldo
            // 
            this.txtSaldo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSaldo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSaldo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaldo.Location = new System.Drawing.Point(305, 84);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(139, 27);
            this.txtSaldo.TabIndex = 38;
            this.txtSaldo.Leave += new System.EventHandler(this.txtSaldo_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(158, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Conta Corrente:";
            // 
            // txtContaCorrente
            // 
            this.txtContaCorrente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContaCorrente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtContaCorrente.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContaCorrente.Location = new System.Drawing.Point(160, 84);
            this.txtContaCorrente.Name = "txtContaCorrente";
            this.txtContaCorrente.Size = new System.Drawing.Size(139, 27);
            this.txtContaCorrente.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(13, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Agência:";
            // 
            // txtAgencia
            // 
            this.txtAgencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAgencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAgencia.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgencia.Location = new System.Drawing.Point(15, 84);
            this.txtAgencia.Name = "txtAgencia";
            this.txtAgencia.Size = new System.Drawing.Size(139, 27);
            this.txtAgencia.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(12, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Banco";
            // 
            // txtBanco
            // 
            this.txtBanco.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtBanco.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtBanco.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.txtBanco.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBanco.FormattingEnabled = true;
            this.txtBanco.Location = new System.Drawing.Point(13, 31);
            this.txtBanco.Name = "txtBanco";
            this.txtBanco.Size = new System.Drawing.Size(431, 28);
            this.txtBanco.TabIndex = 32;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSalvar,
            this.btnCancelar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(512, 39);
            this.toolStrip1.TabIndex = 87;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnSalvar
            // 
            this.btnSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(36, 36);
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.ToolTipText = "Salvar";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(36, 36);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmContaCorrente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(512, 197);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmContaCorrente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conta Corrente";
            this.Load += new System.EventHandler(this.frmContaCorrente_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSalvar;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.Label label7;
        private ComboBoxPersonalizado txtBanco;
        private System.Windows.Forms.Label label3;
        private TextBoxPersonalizado txtSaldo;
        private System.Windows.Forms.Label label1;
        private TextBoxPersonalizado txtContaCorrente;
        private System.Windows.Forms.Label label2;
        private TextBoxPersonalizado txtAgencia;
        private System.Windows.Forms.Label lblContaCorrente;
        private System.Windows.Forms.Button btnAddBanco;
    }
}