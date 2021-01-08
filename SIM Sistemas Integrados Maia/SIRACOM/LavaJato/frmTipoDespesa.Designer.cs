namespace LavaJato
{
    partial class frmTipoDespesa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTipoDespesa));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddClasseDespesa = new System.Windows.Forms.Button();
            this.lblTipoDespesaID = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtClasseDespesa = new LavaJato.ComboBoxPersonalizado();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTipoDespesa = new LavaJato.TextBoxPersonalizado();
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
            this.panel1.Controls.Add(this.btnAddClasseDespesa);
            this.panel1.Controls.Add(this.lblTipoDespesaID);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtClasseDespesa);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtTipoDespesa);
            this.panel1.Location = new System.Drawing.Point(12, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(456, 142);
            this.panel1.TabIndex = 88;
            // 
            // btnAddClasseDespesa
            // 
            this.btnAddClasseDespesa.Image = ((System.Drawing.Image)(resources.GetObject("btnAddClasseDespesa.Image")));
            this.btnAddClasseDespesa.Location = new System.Drawing.Point(415, 38);
            this.btnAddClasseDespesa.Name = "btnAddClasseDespesa";
            this.btnAddClasseDespesa.Size = new System.Drawing.Size(28, 28);
            this.btnAddClasseDespesa.TabIndex = 51;
            this.btnAddClasseDespesa.TabStop = false;
            this.btnAddClasseDespesa.UseVisualStyleBackColor = true;
            this.btnAddClasseDespesa.Click += new System.EventHandler(this.btnAddClasseDespesa_Click);
            // 
            // lblTipoDespesaID
            // 
            this.lblTipoDespesaID.AutoSize = true;
            this.lblTipoDespesaID.Location = new System.Drawing.Point(15, 6);
            this.lblTipoDespesaID.Name = "lblTipoDespesaID";
            this.lblTipoDespesaID.Size = new System.Drawing.Size(0, 13);
            this.lblTipoDespesaID.TabIndex = 32;
            this.lblTipoDespesaID.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(12, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Classe Despesa";
            // 
            // txtClasseDespesa
            // 
            this.txtClasseDespesa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtClasseDespesa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtClasseDespesa.DisplayMember = "ClasseDespesaID";
            this.txtClasseDespesa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.txtClasseDespesa.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClasseDespesa.FormattingEnabled = true;
            this.txtClasseDespesa.Location = new System.Drawing.Point(13, 38);
            this.txtClasseDespesa.Name = "txtClasseDespesa";
            this.txtClasseDespesa.Size = new System.Drawing.Size(396, 28);
            this.txtClasseDespesa.TabIndex = 30;
            this.txtClasseDespesa.ValueMember = "ClasseDespesaID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(10, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Tipo Despesa:";
            // 
            // txtTipoDespesa
            // 
            this.txtTipoDespesa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTipoDespesa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTipoDespesa.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoDespesa.Location = new System.Drawing.Point(12, 89);
            this.txtTipoDespesa.Name = "txtTipoDespesa";
            this.txtTipoDespesa.Size = new System.Drawing.Size(397, 27);
            this.txtTipoDespesa.TabIndex = 25;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSalvar,
            this.btnCancelar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(480, 39);
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
            // frmTipoDespesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(480, 217);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTipoDespesa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tipo Despesa";
            this.Load += new System.EventHandler(this.frmTipoDespesa_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private TextBoxPersonalizado txtTipoDespesa;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSalvar;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.Label label7;
        private ComboBoxPersonalizado txtClasseDespesa;
        private System.Windows.Forms.Label lblTipoDespesaID;
        private System.Windows.Forms.Button btnAddClasseDespesa;
    }
}