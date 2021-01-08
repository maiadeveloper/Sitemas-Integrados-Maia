namespace LavaJato
{
    partial class frmImportarOrcamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImportarOrcamento));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnImportar = new System.Windows.Forms.Button();
            this.txtNumeroOrcamento = new LavaJato.TextBoxPersonalizado();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnImportar);
            this.panel1.Controls.Add(this.txtNumeroOrcamento);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Location = new System.Drawing.Point(9, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(315, 117);
            this.panel1.TabIndex = 1;
            // 
            // btnImportar
            // 
            this.btnImportar.Image = ((System.Drawing.Image)(resources.GetObject("btnImportar.Image")));
            this.btnImportar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImportar.Location = new System.Drawing.Point(219, 50);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(86, 27);
            this.btnImportar.TabIndex = 33;
            this.btnImportar.Text = "Importar";
            this.btnImportar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImportar.UseVisualStyleBackColor = true;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // txtNumeroOrcamento
            // 
            this.txtNumeroOrcamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumeroOrcamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumeroOrcamento.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroOrcamento.Location = new System.Drawing.Point(9, 50);
            this.txtNumeroOrcamento.Name = "txtNumeroOrcamento";
            this.txtNumeroOrcamento.Size = new System.Drawing.Size(204, 27);
            this.txtNumeroOrcamento.TabIndex = 32;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(6, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(169, 13);
            this.label11.TabIndex = 31;
            this.label11.Text = "Informe o nº orçamento:";
            // 
            // frmImportarOrcamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(332, 134);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmImportarOrcamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmImportarOrcamento";
            this.Load += new System.EventHandler(this.frmImportarOrcamento_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmImportarOrcamento_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnImportar;
        private TextBoxPersonalizado txtNumeroOrcamento;
        private System.Windows.Forms.Label label11;
    }
}