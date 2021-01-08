namespace LavaJato
{
    partial class frmParametroRelProdutoDataVcto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmParametroRelProdutoDataVcto));
            this.g = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.txtDiasOuMes = new LavaJato.TextBoxPersonalizado();
            this.lblTipoRelatorio = new System.Windows.Forms.Label();
            this.rbVencimentoMes = new System.Windows.Forms.RadioButton();
            this.rbVencimentoDia = new System.Windows.Forms.RadioButton();
            this.g.SuspendLayout();
            this.SuspendLayout();
            // 
            // g
            // 
            this.g.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.g.Controls.Add(this.button2);
            this.g.Controls.Add(this.btnVisualizar);
            this.g.Controls.Add(this.txtDiasOuMes);
            this.g.Controls.Add(this.lblTipoRelatorio);
            this.g.Controls.Add(this.rbVencimentoMes);
            this.g.Controls.Add(this.rbVencimentoDia);
            this.g.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.g.ForeColor = System.Drawing.Color.White;
            this.g.Location = new System.Drawing.Point(12, 12);
            this.g.Name = "g";
            this.g.Size = new System.Drawing.Size(370, 193);
            this.g.TabIndex = 57;
            this.g.TabStop = false;
            this.g.Text = "Informe tipo de relatório";
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(230, 146);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 34);
            this.button2.TabIndex = 35;
            this.button2.Text = "Cancelar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.ForeColor = System.Drawing.Color.Black;
            this.btnVisualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnVisualizar.Image")));
            this.btnVisualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVisualizar.Location = new System.Drawing.Point(19, 146);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(113, 34);
            this.btnVisualizar.TabIndex = 34;
            this.btnVisualizar.Text = "Visualizar";
            this.btnVisualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVisualizar.UseVisualStyleBackColor = true;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // txtDiasOuMes
            // 
            this.txtDiasOuMes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiasOuMes.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDiasOuMes.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiasOuMes.Location = new System.Drawing.Point(19, 91);
            this.txtDiasOuMes.Name = "txtDiasOuMes";
            this.txtDiasOuMes.Size = new System.Drawing.Size(97, 27);
            this.txtDiasOuMes.TabIndex = 32;
            this.txtDiasOuMes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTipoRelatorio
            // 
            this.lblTipoRelatorio.AutoSize = true;
            this.lblTipoRelatorio.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoRelatorio.ForeColor = System.Drawing.Color.White;
            this.lblTipoRelatorio.Location = new System.Drawing.Point(15, 68);
            this.lblTipoRelatorio.Name = "lblTipoRelatorio";
            this.lblTipoRelatorio.Size = new System.Drawing.Size(101, 20);
            this.lblTipoRelatorio.TabIndex = 33;
            this.lblTipoRelatorio.Text = "tipo relatorio";
            // 
            // rbVencimentoMes
            // 
            this.rbVencimentoMes.AutoSize = true;
            this.rbVencimentoMes.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbVencimentoMes.Location = new System.Drawing.Point(190, 34);
            this.rbVencimentoMes.Name = "rbVencimentoMes";
            this.rbVencimentoMes.Size = new System.Drawing.Size(171, 24);
            this.rbVencimentoMes.TabIndex = 1;
            this.rbVencimentoMes.TabStop = true;
            this.rbVencimentoMes.Text = "Vencimento por Mês";
            this.rbVencimentoMes.UseVisualStyleBackColor = true;
            this.rbVencimentoMes.CheckedChanged += new System.EventHandler(this.rbVencimentoMes_CheckedChanged);
            // 
            // rbVencimentoDia
            // 
            this.rbVencimentoDia.AutoSize = true;
            this.rbVencimentoDia.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbVencimentoDia.Location = new System.Drawing.Point(19, 34);
            this.rbVencimentoDia.Name = "rbVencimentoDia";
            this.rbVencimentoDia.Size = new System.Drawing.Size(165, 24);
            this.rbVencimentoDia.TabIndex = 0;
            this.rbVencimentoDia.TabStop = true;
            this.rbVencimentoDia.Text = "Vencimento por Dia";
            this.rbVencimentoDia.UseVisualStyleBackColor = true;
            this.rbVencimentoDia.CheckedChanged += new System.EventHandler(this.rbVencimentoDia_CheckedChanged);
            // 
            // frmParametroRelProdutoDataVcto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(397, 218);
            this.Controls.Add(this.g);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmParametroRelProdutoDataVcto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parametro para consulta";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmParametroRelProdutoDataVcto_KeyDown);
            this.g.ResumeLayout(false);
            this.g.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox g;
        private System.Windows.Forms.RadioButton rbVencimentoMes;
        private System.Windows.Forms.RadioButton rbVencimentoDia;
        private TextBoxPersonalizado txtDiasOuMes;
        private System.Windows.Forms.Label lblTipoRelatorio;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnVisualizar;
    }
}