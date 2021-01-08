namespace LavaJato
{
    partial class frmDespesa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDespesa));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSalvar = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCodigoContaCorrente = new LavaJato.TextBoxPersonalizado();
            this.txtDescricaoContaCorrent = new LavaJato.TextBoxPersonalizado();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddConta = new System.Windows.Forms.Button();
            this.btnAddTipoDespesa = new System.Windows.Forms.Button();
            this.btnAddClasseDespesa = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.DateTimePicker();
            this.txtValor = new LavaJato.TextBoxPersonalizado();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTipoDespesas = new LavaJato.ComboBoxPersonalizado();
            this.lblDespesaID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescricao = new LavaJato.TextBoxPersonalizado();
            this.label7 = new System.Windows.Forms.Label();
            this.txtClasseDespesas = new LavaJato.ComboBoxPersonalizado();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSalvar,
            this.btnCancelar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(614, 39);
            this.toolStrip1.TabIndex = 6;
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
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtCodigoContaCorrente);
            this.panel1.Controls.Add(this.txtDescricaoContaCorrent);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnAddConta);
            this.panel1.Controls.Add(this.btnAddTipoDespesa);
            this.panel1.Controls.Add(this.btnAddClasseDespesa);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtData);
            this.panel1.Controls.Add(this.txtValor);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtTipoDespesas);
            this.panel1.Controls.Add(this.lblDespesaID);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtDescricao);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtClasseDespesas);
            this.panel1.Location = new System.Drawing.Point(12, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(588, 342);
            this.panel1.TabIndex = 89;
            // 
            // txtCodigoContaCorrente
            // 
            this.txtCodigoContaCorrente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigoContaCorrente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigoContaCorrente.Enabled = false;
            this.txtCodigoContaCorrente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoContaCorrente.Location = new System.Drawing.Point(17, 297);
            this.txtCodigoContaCorrente.Name = "txtCodigoContaCorrente";
            this.txtCodigoContaCorrente.Size = new System.Drawing.Size(67, 29);
            this.txtCodigoContaCorrente.TabIndex = 52;
            // 
            // txtDescricaoContaCorrent
            // 
            this.txtDescricaoContaCorrent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescricaoContaCorrent.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescricaoContaCorrent.Enabled = false;
            this.txtDescricaoContaCorrent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricaoContaCorrent.Location = new System.Drawing.Point(89, 297);
            this.txtDescricaoContaCorrent.Name = "txtDescricaoContaCorrent";
            this.txtDescricaoContaCorrent.Size = new System.Drawing.Size(447, 29);
            this.txtDescricaoContaCorrent.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(14, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 51;
            this.label4.Text = "Conta Corrente:";
            // 
            // btnAddConta
            // 
            this.btnAddConta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddConta.BackgroundImage")));
            this.btnAddConta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddConta.Location = new System.Drawing.Point(542, 297);
            this.btnAddConta.Name = "btnAddConta";
            this.btnAddConta.Size = new System.Drawing.Size(28, 29);
            this.btnAddConta.TabIndex = 49;
            this.btnAddConta.TabStop = false;
            this.btnAddConta.UseVisualStyleBackColor = true;
            this.btnAddConta.Click += new System.EventHandler(this.btnAddConta_Click);
            // 
            // btnAddTipoDespesa
            // 
            this.btnAddTipoDespesa.Image = ((System.Drawing.Image)(resources.GetObject("btnAddTipoDespesa.Image")));
            this.btnAddTipoDespesa.Location = new System.Drawing.Point(542, 88);
            this.btnAddTipoDespesa.Name = "btnAddTipoDespesa";
            this.btnAddTipoDespesa.Size = new System.Drawing.Size(28, 28);
            this.btnAddTipoDespesa.TabIndex = 48;
            this.btnAddTipoDespesa.TabStop = false;
            this.btnAddTipoDespesa.UseVisualStyleBackColor = true;
            this.btnAddTipoDespesa.Click += new System.EventHandler(this.btnAddTipoDespesa_Click);
            // 
            // btnAddClasseDespesa
            // 
            this.btnAddClasseDespesa.Image = ((System.Drawing.Image)(resources.GetObject("btnAddClasseDespesa.Image")));
            this.btnAddClasseDespesa.Location = new System.Drawing.Point(542, 32);
            this.btnAddClasseDespesa.Name = "btnAddClasseDespesa";
            this.btnAddClasseDespesa.Size = new System.Drawing.Size(28, 28);
            this.btnAddClasseDespesa.TabIndex = 47;
            this.btnAddClasseDespesa.TabStop = false;
            this.btnAddClasseDespesa.UseVisualStyleBackColor = true;
            this.btnAddClasseDespesa.Click += new System.EventHandler(this.btnAddClasseDespesa_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(14, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "Data:";
            // 
            // txtData
            // 
            this.txtData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtData.Location = new System.Drawing.Point(17, 140);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(135, 26);
            this.txtData.TabIndex = 2;
            // 
            // txtValor
            // 
            this.txtValor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtValor.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(424, 139);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(146, 27);
            this.txtValor.TabIndex = 3;
            this.txtValor.Leave += new System.EventHandler(this.txtValor_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(421, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Valor($):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(14, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Tipo Despesas:";
            // 
            // txtTipoDespesas
            // 
            this.txtTipoDespesas.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtTipoDespesas.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtTipoDespesas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.txtTipoDespesas.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoDespesas.FormattingEnabled = true;
            this.txtTipoDespesas.Location = new System.Drawing.Point(17, 88);
            this.txtTipoDespesas.Name = "txtTipoDespesas";
            this.txtTipoDespesas.Size = new System.Drawing.Size(519, 28);
            this.txtTipoDespesas.TabIndex = 1;
            // 
            // lblDespesaID
            // 
            this.lblDespesaID.AutoSize = true;
            this.lblDespesaID.Location = new System.Drawing.Point(146, 15);
            this.lblDespesaID.Name = "lblDespesaID";
            this.lblDespesaID.Size = new System.Drawing.Size(13, 13);
            this.lblDespesaID.TabIndex = 40;
            this.lblDespesaID.Text = "0";
            this.lblDespesaID.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(14, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Classe Depesas:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescricao.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(17, 193);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(553, 78);
            this.txtDescricao.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(14, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Descrição:";
            // 
            // txtClasseDespesas
            // 
            this.txtClasseDespesas.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtClasseDespesas.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtClasseDespesas.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClasseDespesas.FormattingEnabled = true;
            this.txtClasseDespesas.Location = new System.Drawing.Point(17, 32);
            this.txtClasseDespesas.Name = "txtClasseDespesas";
            this.txtClasseDespesas.Size = new System.Drawing.Size(519, 28);
            this.txtClasseDespesas.TabIndex = 0;
            this.txtClasseDespesas.SelectionChangeCommitted += new System.EventHandler(this.txtClasseDespesas_SelectionChangeCommitted);
            // 
            // frmDespesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(614, 408);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDespesa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Despesa";
            this.Load += new System.EventHandler(this.frmDespesa_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSalvar;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDespesaID;
        private System.Windows.Forms.Label label3;
        private TextBoxPersonalizado txtValor;
        private System.Windows.Forms.Label label2;
        private TextBoxPersonalizado txtDescricao;
        private System.Windows.Forms.Label label7;
        private ComboBoxPersonalizado txtClasseDespesas;
        private System.Windows.Forms.Button btnAddConta;
        private System.Windows.Forms.Button btnAddTipoDespesa;
        private System.Windows.Forms.Button btnAddClasseDespesa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker txtData;
        private System.Windows.Forms.Label label1;
        private ComboBoxPersonalizado txtTipoDespesas;
        private TextBoxPersonalizado txtCodigoContaCorrente;
        private TextBoxPersonalizado txtDescricaoContaCorrent;
        private System.Windows.Forms.Label label4;
    }
}