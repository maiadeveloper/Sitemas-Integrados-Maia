namespace LavaJato
{
    partial class frmRealizarNegociacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRealizarNegociacao));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listItensNegociacao = new System.Windows.Forms.ListView();
            this.columnCod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnParcela = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDtVc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtVencimentoInicial = new System.Windows.Forms.DateTimePicker();
            this.lwParcelamento = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtParcelas = new System.Windows.Forms.ComboBox();
            this.toolStripButtonSalvar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCancelar = new System.Windows.Forms.ToolStripButton();
            this.btnGerarParcelas = new LavaJato.btnPesonalizado();
            this.txtTotalNegociado = new LavaJato.TextBoxPersonalizado();
            this.txtTotalCobrado = new LavaJato.TextBoxPersonalizado();
            this.txtNomeFantasia = new LavaJato.TextBoxPersonalizado();
            this.txtCPFCNPJ = new LavaJato.TextBoxPersonalizado();
            this.toolStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.LightGray;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonSalvar,
            this.toolStripSeparator5,
            this.toolStripButtonCancelar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(808, 39);
            this.toolStrip1.TabIndex = 17;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 39);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txtNomeFantasia);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtCPFCNPJ);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(12, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(784, 80);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informações do cliente";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(187, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 20);
            this.label11.TabIndex = 8;
            this.label11.Text = "Nome/Fantasia";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(15, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 20);
            this.label12.TabIndex = 6;
            this.label12.Text = "CPF/CNPJ:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTotalNegociado);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtTotalCobrado);
            this.groupBox1.Controls.Add(this.listItensNegociacao);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(429, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 407);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações da conta receber";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(97, 374);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 21);
            this.label2.TabIndex = 45;
            this.label2.Text = "Total negociado:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "Total divida:";
            // 
            // listItensNegociacao
            // 
            this.listItensNegociacao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listItensNegociacao.BackColor = System.Drawing.Color.WhiteSmoke;
            this.listItensNegociacao.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnCod,
            this.columnParcela,
            this.columnDtVc,
            this.columnHeader1});
            this.listItensNegociacao.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listItensNegociacao.FullRowSelect = true;
            this.listItensNegociacao.GridLines = true;
            this.listItensNegociacao.Location = new System.Drawing.Point(10, 32);
            this.listItensNegociacao.Name = "listItensNegociacao";
            this.listItensNegociacao.Size = new System.Drawing.Size(346, 297);
            this.listItensNegociacao.TabIndex = 44;
            this.listItensNegociacao.TabStop = false;
            this.listItensNegociacao.UseCompatibleStateImageBehavior = false;
            this.listItensNegociacao.View = System.Windows.Forms.View.Details;
            // 
            // columnCod
            // 
            this.columnCod.Text = "Cod";
            // 
            // columnParcela
            // 
            this.columnParcela.Text = "Parcela";
            this.columnParcela.Width = 70;
            // 
            // columnDtVc
            // 
            this.columnDtVc.Text = "Data Vcto";
            this.columnDtVc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnDtVc.Width = 100;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Vlr Cobrado";
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader1.Width = 100;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtVencimentoInicial);
            this.groupBox3.Controls.Add(this.lwParcelamento);
            this.groupBox3.Controls.Add(this.btnGerarParcelas);
            this.groupBox3.Controls.Add(this.txtParcelas);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(12, 131);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(411, 405);
            this.groupBox3.TabIndex = 59;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Parcelas";
            // 
            // txtVencimentoInicial
            // 
            this.txtVencimentoInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVencimentoInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtVencimentoInicial.Location = new System.Drawing.Point(75, 22);
            this.txtVencimentoInicial.Name = "txtVencimentoInicial";
            this.txtVencimentoInicial.Size = new System.Drawing.Size(110, 26);
            this.txtVencimentoInicial.TabIndex = 94;
            // 
            // lwParcelamento
            // 
            this.lwParcelamento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lwParcelamento.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lwParcelamento.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lwParcelamento.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lwParcelamento.FullRowSelect = true;
            this.lwParcelamento.GridLines = true;
            this.lwParcelamento.Location = new System.Drawing.Point(19, 62);
            this.lwParcelamento.Name = "lwParcelamento";
            this.lwParcelamento.Size = new System.Drawing.Size(382, 330);
            this.lwParcelamento.TabIndex = 45;
            this.lwParcelamento.TabStop = false;
            this.lwParcelamento.UseCompatibleStateImageBehavior = false;
            this.lwParcelamento.View = System.Windows.Forms.View.Details;
            this.lwParcelamento.DoubleClick += new System.EventHandler(this.lwParcelamento_DoubleClick);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Parcela";
            this.columnHeader3.Width = 65;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Data Vcto";
            this.columnHeader4.Width = 210;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Vlr Parcela";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader5.Width = 95;
            // 
            // txtParcelas
            // 
            this.txtParcelas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtParcelas.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParcelas.FormattingEnabled = true;
            this.txtParcelas.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.txtParcelas.Location = new System.Drawing.Point(18, 21);
            this.txtParcelas.Name = "txtParcelas";
            this.txtParcelas.Size = new System.Drawing.Size(51, 27);
            this.txtParcelas.TabIndex = 1;
            // 
            // toolStripButtonSalvar
            // 
            this.toolStripButtonSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSalvar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSalvar.Image")));
            this.toolStripButtonSalvar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSalvar.Name = "toolStripButtonSalvar";
            this.toolStripButtonSalvar.Size = new System.Drawing.Size(36, 36);
            this.toolStripButtonSalvar.Text = "Salvar";
            this.toolStripButtonSalvar.ToolTipText = "Salvar";
            this.toolStripButtonSalvar.Click += new System.EventHandler(this.toolStripButtonSalvar_Click);
            // 
            // toolStripButtonCancelar
            // 
            this.toolStripButtonCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonCancelar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCancelar.Image")));
            this.toolStripButtonCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCancelar.Name = "toolStripButtonCancelar";
            this.toolStripButtonCancelar.Size = new System.Drawing.Size(36, 36);
            this.toolStripButtonCancelar.Text = "Cancelar";
            this.toolStripButtonCancelar.ToolTipText = "Cancelar";
            this.toolStripButtonCancelar.Click += new System.EventHandler(this.toolStripButtonCancelar_Click);
            // 
            // btnGerarParcelas
            // 
            this.btnGerarParcelas.ForeColor = System.Drawing.Color.Black;
            this.btnGerarParcelas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGerarParcelas.Location = new System.Drawing.Point(191, 20);
            this.btnGerarParcelas.Name = "btnGerarParcelas";
            this.btnGerarParcelas.Size = new System.Drawing.Size(135, 29);
            this.btnGerarParcelas.TabIndex = 19;
            this.btnGerarParcelas.Text = "Gerar parcelas";
            this.btnGerarParcelas.UseVisualStyleBackColor = true;
            this.btnGerarParcelas.Click += new System.EventHandler(this.btnGerarParcelas_Click);
            // 
            // txtTotalNegociado
            // 
            this.txtTotalNegociado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalNegociado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalNegociado.Location = new System.Drawing.Point(235, 367);
            this.txtTotalNegociado.Name = "txtTotalNegociado";
            this.txtTotalNegociado.Size = new System.Drawing.Size(121, 29);
            this.txtTotalNegociado.TabIndex = 46;
            this.txtTotalNegociado.TabStop = false;
            this.txtTotalNegociado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotalNegociado.Enter += new System.EventHandler(this.txtTotalNegociado_Enter);
            this.txtTotalNegociado.Leave += new System.EventHandler(this.txtTotalNegociado_Leave);
            // 
            // txtTotalCobrado
            // 
            this.txtTotalCobrado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalCobrado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalCobrado.Location = new System.Drawing.Point(235, 334);
            this.txtTotalCobrado.Name = "txtTotalCobrado";
            this.txtTotalCobrado.ReadOnly = true;
            this.txtTotalCobrado.Size = new System.Drawing.Size(121, 29);
            this.txtTotalCobrado.TabIndex = 10;
            this.txtTotalCobrado.TabStop = false;
            this.txtTotalCobrado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotalCobrado.DoubleClick += new System.EventHandler(this.txtTotalCobrado_DoubleClick);
            // 
            // txtNomeFantasia
            // 
            this.txtNomeFantasia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeFantasia.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeFantasia.Location = new System.Drawing.Point(191, 44);
            this.txtNomeFantasia.Name = "txtNomeFantasia";
            this.txtNomeFantasia.ReadOnly = true;
            this.txtNomeFantasia.Size = new System.Drawing.Size(582, 27);
            this.txtNomeFantasia.TabIndex = 9;
            this.txtNomeFantasia.TabStop = false;
            // 
            // txtCPFCNPJ
            // 
            this.txtCPFCNPJ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCPFCNPJ.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPFCNPJ.Location = new System.Drawing.Point(18, 44);
            this.txtCPFCNPJ.Name = "txtCPFCNPJ";
            this.txtCPFCNPJ.ReadOnly = true;
            this.txtCPFCNPJ.Size = new System.Drawing.Size(167, 27);
            this.txtCPFCNPJ.TabIndex = 7;
            this.txtCPFCNPJ.TabStop = false;
            // 
            // frmRealizarNegociacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(808, 547);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRealizarNegociacao";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Realizar negociação";
            this.Load += new System.EventHandler(this.frmRealizarNegociacao_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmRealizarNegociacao_KeyDown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonSalvar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolStripButtonCancelar;
        private System.Windows.Forms.GroupBox groupBox2;
        private TextBoxPersonalizado txtNomeFantasia;
        private System.Windows.Forms.Label label11;
        private TextBoxPersonalizado txtCPFCNPJ;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listItensNegociacao;
        private System.Windows.Forms.ColumnHeader columnCod;
        private System.Windows.Forms.ColumnHeader columnParcela;
        private System.Windows.Forms.ColumnHeader columnDtVc;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private TextBoxPersonalizado txtTotalCobrado;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox txtParcelas;
        private System.Windows.Forms.ListView lwParcelamento;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private btnPesonalizado btnGerarParcelas;
        private System.Windows.Forms.DateTimePicker txtVencimentoInicial;
        private System.Windows.Forms.Label label2;
        private TextBoxPersonalizado txtTotalNegociado;
        private System.Windows.Forms.Label label1;
    }
}