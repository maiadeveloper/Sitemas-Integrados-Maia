namespace LavaJato
{
    partial class frmBaseTodasEntradasProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBaseTodasEntradasProdutos));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtono = new System.Windows.Forms.ToolStripButton();
            this.toolStripSair = new System.Windows.Forms.ToolStripButton();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txtTotalItem = new LavaJato.TextBoxPersonalizado();
            this.txtTotalVlrFrete = new LavaJato.TextBoxPersonalizado();
            this.txtVlrTotalDespesas = new LavaJato.TextBoxPersonalizado();
            this.txtVlrTotalDesconto = new LavaJato.TextBoxPersonalizado();
            this.txtVlrTotalGeral = new LavaJato.TextBoxPersonalizado();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lwEntradaMercadorias = new System.Windows.Forms.ListView();
            this.colCod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDataEntrada = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCnpj = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFonecedor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNumeroNfe = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFrete = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDespesas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDesconto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTotalNotaFiscal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ExcluirVendatoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnConsultar = new LavaJato.btnPesonalizado();
            this.txtDataFinal = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDateInicial = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNomeFornecedor = new LavaJato.ComboBoxPersonalizado();
            this.label11 = new System.Windows.Forms.Label();
            this.btnLimparBusca = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.LightGray;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtono,
            this.toolStripSair});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1231, 39);
            this.toolStrip1.TabIndex = 29;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtono
            // 
            this.toolStripButtono.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtono.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtono.Image")));
            this.toolStripButtono.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtono.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtono.Name = "toolStripButtono";
            this.toolStripButtono.Size = new System.Drawing.Size(36, 36);
            this.toolStripButtono.Text = "Novo";
            this.toolStripButtono.Click += new System.EventHandler(this.toolStripButtono_Click);
            // 
            // toolStripSair
            // 
            this.toolStripSair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSair.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSair.Image")));
            this.toolStripSair.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripSair.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSair.Name = "toolStripSair";
            this.toolStripSair.RightToLeftAutoMirrorImage = true;
            this.toolStripSair.Size = new System.Drawing.Size(36, 36);
            this.toolStripSair.Text = "Cancelar";
            this.toolStripSair.ToolTipText = "Cancelar";
            this.toolStripSair.Click += new System.EventHandler(this.toolStripSair_Click);
            // 
            // panel9
            // 
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel9.Controls.Add(this.txtTotalItem);
            this.panel9.Controls.Add(this.txtTotalVlrFrete);
            this.panel9.Controls.Add(this.txtVlrTotalDespesas);
            this.panel9.Controls.Add(this.txtVlrTotalDesconto);
            this.panel9.Controls.Add(this.txtVlrTotalGeral);
            this.panel9.Controls.Add(this.panel4);
            this.panel9.Controls.Add(this.lwEntradaMercadorias);
            this.panel9.Controls.Add(this.panel7);
            this.panel9.Controls.Add(this.panel6);
            this.panel9.Controls.Add(this.panel8);
            this.panel9.Controls.Add(this.panel1);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel9.Location = new System.Drawing.Point(0, 39);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1231, 343);
            this.panel9.TabIndex = 73;
            // 
            // txtTotalItem
            // 
            this.txtTotalItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTotalItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalItem.Location = new System.Drawing.Point(11, 303);
            this.txtTotalItem.Name = "txtTotalItem";
            this.txtTotalItem.ReadOnly = true;
            this.txtTotalItem.Size = new System.Drawing.Size(41, 24);
            this.txtTotalItem.TabIndex = 87;
            this.txtTotalItem.TabStop = false;
            this.txtTotalItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTotalVlrFrete
            // 
            this.txtTotalVlrFrete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalVlrFrete.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalVlrFrete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalVlrFrete.Location = new System.Drawing.Point(708, 303);
            this.txtTotalVlrFrete.Name = "txtTotalVlrFrete";
            this.txtTotalVlrFrete.ReadOnly = true;
            this.txtTotalVlrFrete.Size = new System.Drawing.Size(120, 24);
            this.txtTotalVlrFrete.TabIndex = 84;
            this.txtTotalVlrFrete.TabStop = false;
            this.txtTotalVlrFrete.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtVlrTotalDespesas
            // 
            this.txtVlrTotalDespesas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVlrTotalDespesas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVlrTotalDespesas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVlrTotalDespesas.Location = new System.Drawing.Point(829, 303);
            this.txtVlrTotalDespesas.Name = "txtVlrTotalDespesas";
            this.txtVlrTotalDespesas.ReadOnly = true;
            this.txtVlrTotalDespesas.Size = new System.Drawing.Size(120, 24);
            this.txtVlrTotalDespesas.TabIndex = 83;
            this.txtVlrTotalDespesas.TabStop = false;
            this.txtVlrTotalDespesas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtVlrTotalDesconto
            // 
            this.txtVlrTotalDesconto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVlrTotalDesconto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVlrTotalDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVlrTotalDesconto.Location = new System.Drawing.Point(950, 303);
            this.txtVlrTotalDesconto.Name = "txtVlrTotalDesconto";
            this.txtVlrTotalDesconto.ReadOnly = true;
            this.txtVlrTotalDesconto.Size = new System.Drawing.Size(120, 24);
            this.txtVlrTotalDesconto.TabIndex = 82;
            this.txtVlrTotalDesconto.TabStop = false;
            this.txtVlrTotalDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtVlrTotalGeral
            // 
            this.txtVlrTotalGeral.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVlrTotalGeral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVlrTotalGeral.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVlrTotalGeral.Location = new System.Drawing.Point(1071, 303);
            this.txtVlrTotalGeral.Name = "txtVlrTotalGeral";
            this.txtVlrTotalGeral.ReadOnly = true;
            this.txtVlrTotalGeral.Size = new System.Drawing.Size(120, 24);
            this.txtVlrTotalGeral.TabIndex = 81;
            this.txtVlrTotalGeral.TabStop = false;
            this.txtVlrTotalGeral.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.LightGray;
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Location = new System.Drawing.Point(10, 119);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1207, 24);
            this.panel4.TabIndex = 80;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(37, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 20);
            this.label6.TabIndex = 51;
            this.label6.Text = "Entrada de Mercadorias";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 22);
            this.pictureBox2.TabIndex = 50;
            this.pictureBox2.TabStop = false;
            // 
            // lwEntradaMercadorias
            // 
            this.lwEntradaMercadorias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lwEntradaMercadorias.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lwEntradaMercadorias.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colCod,
            this.colDataEntrada,
            this.colCnpj,
            this.colFonecedor,
            this.colNumeroNfe,
            this.colFrete,
            this.colDespesas,
            this.colDesconto,
            this.colTotalNotaFiscal});
            this.lwEntradaMercadorias.ContextMenuStrip = this.contextMenuStrip1;
            this.lwEntradaMercadorias.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lwEntradaMercadorias.FullRowSelect = true;
            this.lwEntradaMercadorias.GridLines = true;
            this.lwEntradaMercadorias.Location = new System.Drawing.Point(10, 143);
            this.lwEntradaMercadorias.Name = "lwEntradaMercadorias";
            this.lwEntradaMercadorias.Size = new System.Drawing.Size(1207, 158);
            this.lwEntradaMercadorias.TabIndex = 79;
            this.lwEntradaMercadorias.UseCompatibleStateImageBehavior = false;
            this.lwEntradaMercadorias.View = System.Windows.Forms.View.Details;
            this.lwEntradaMercadorias.SelectedIndexChanged += new System.EventHandler(this.lwEntradaMercadorias_SelectedIndexChanged);
            this.lwEntradaMercadorias.DoubleClick += new System.EventHandler(this.lwEntradaMercadorias_DoubleClick);
            // 
            // colCod
            // 
            this.colCod.Text = "Cod";
            // 
            // colDataEntrada
            // 
            this.colDataEntrada.Text = "Data Entrada";
            this.colDataEntrada.Width = 120;
            // 
            // colCnpj
            // 
            this.colCnpj.Text = "CNPJ";
            this.colCnpj.Width = 150;
            // 
            // colFonecedor
            // 
            this.colFonecedor.Text = "Fornecedor";
            this.colFonecedor.Width = 400;
            // 
            // colNumeroNfe
            // 
            this.colNumeroNfe.Text = "Nº NFe";
            this.colNumeroNfe.Width = 100;
            // 
            // colFrete
            // 
            this.colFrete.Text = "Valor Frete";
            this.colFrete.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colFrete.Width = 120;
            // 
            // colDespesas
            // 
            this.colDespesas.Text = "Valor Despesas";
            this.colDespesas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colDespesas.Width = 120;
            // 
            // colDesconto
            // 
            this.colDesconto.Text = "Valor Desconto";
            this.colDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colDesconto.Width = 120;
            // 
            // colTotalNotaFiscal
            // 
            this.colTotalNotaFiscal.Text = "Valor Total";
            this.colTotalNotaFiscal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colTotalNotaFiscal.Width = 120;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExcluirVendatoolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(240, 26);
            this.contextMenuStrip1.Text = "Baixar conta";
            this.contextMenuStrip1.Click += new System.EventHandler(this.contextMenuStrip1_Click);
            // 
            // ExcluirVendatoolStripMenuItem
            // 
            this.ExcluirVendatoolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ExcluirVendatoolStripMenuItem.Image")));
            this.ExcluirVendatoolStripMenuItem.Name = "ExcluirVendatoolStripMenuItem";
            this.ExcluirVendatoolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.ExcluirVendatoolStripMenuItem.Text = "Estornar Entrada de Mercadoria";
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.BackColor = System.Drawing.Color.LightGray;
            this.panel7.Controls.Add(this.label9);
            this.panel7.Controls.Add(this.pictureBox3);
            this.panel7.Location = new System.Drawing.Point(666, 8);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(551, 24);
            this.panel7.TabIndex = 73;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(37, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 20);
            this.label9.TabIndex = 51;
            this.label9.Text = "Período consulta";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(2, 1);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(29, 22);
            this.pictureBox3.TabIndex = 50;
            this.pictureBox3.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.btnConsultar);
            this.panel6.Controls.Add(this.txtDataFinal);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.txtDateInicial);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel6.Location = new System.Drawing.Point(666, 32);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(551, 75);
            this.panel6.TabIndex = 72;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultar.Image")));
            this.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultar.Location = new System.Drawing.Point(400, 20);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(104, 29);
            this.btnConsultar.TabIndex = 18;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // txtDataFinal
            // 
            this.txtDataFinal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataFinal.Location = new System.Drawing.Point(291, 23);
            this.txtDataFinal.Name = "txtDataFinal";
            this.txtDataFinal.Size = new System.Drawing.Size(103, 25);
            this.txtDataFinal.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(210, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 21);
            this.label7.TabIndex = 16;
            this.label7.Text = "Data Final:";
            // 
            // txtDateInicial
            // 
            this.txtDateInicial.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDateInicial.Location = new System.Drawing.Point(100, 23);
            this.txtDateInicial.Name = "txtDateInicial";
            this.txtDateInicial.Size = new System.Drawing.Size(105, 25);
            this.txtDateInicial.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(14, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 21);
            this.label8.TabIndex = 14;
            this.label8.Text = "Data Inicial:";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.LightGray;
            this.panel8.Controls.Add(this.label10);
            this.panel8.Controls.Add(this.pictureBox4);
            this.panel8.Location = new System.Drawing.Point(11, 8);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(647, 24);
            this.panel8.TabIndex = 75;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(37, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 20);
            this.label10.TabIndex = 51;
            this.label10.Text = "Consulta";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Location = new System.Drawing.Point(2, 1);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(29, 22);
            this.pictureBox4.TabIndex = 50;
            this.pictureBox4.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtNomeFornecedor);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.btnLimparBusca);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(11, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(646, 75);
            this.panel1.TabIndex = 74;
            // 
            // txtNomeFornecedor
            // 
            this.txtNomeFornecedor.AutoCompleteCustomSource.AddRange(new string[] {
            "teste"});
            this.txtNomeFornecedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtNomeFornecedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtNomeFornecedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtNomeFornecedor.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeFornecedor.FormattingEnabled = true;
            this.txtNomeFornecedor.Items.AddRange(new object[] {
            "teste"});
            this.txtNomeFornecedor.Location = new System.Drawing.Point(12, 21);
            this.txtNomeFornecedor.Name = "txtNomeFornecedor";
            this.txtNomeFornecedor.Size = new System.Drawing.Size(487, 28);
            this.txtNomeFornecedor.TabIndex = 33;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(9, 5);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(138, 13);
            this.label11.TabIndex = 34;
            this.label11.Text = "Nome/Razão Social:";
            // 
            // btnLimparBusca
            // 
            this.btnLimparBusca.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnLimparBusca.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnLimparBusca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLimparBusca.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparBusca.Image = ((System.Drawing.Image)(resources.GetObject("btnLimparBusca.Image")));
            this.btnLimparBusca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimparBusca.Location = new System.Drawing.Point(505, 21);
            this.btnLimparBusca.Name = "btnLimparBusca";
            this.btnLimparBusca.Size = new System.Drawing.Size(83, 29);
            this.btnLimparBusca.TabIndex = 3;
            this.btnLimparBusca.Text = "Limpar";
            this.btnLimparBusca.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimparBusca.UseVisualStyleBackColor = false;
            this.btnLimparBusca.Click += new System.EventHandler(this.btnLimparBusca_Click);
            // 
            // frmBaseTodasEntradasProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1231, 382);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmBaseTodasEntradasProdutos";
            this.Text = "Consultar Entradas de Mercadorias";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmBaseTodasEntradasProdutos_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmBaseTodasEntradasProdutos_KeyDown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtono;
        private System.Windows.Forms.ToolStripButton toolStripSair;
        private System.Windows.Forms.Panel panel9;
        private TextBoxPersonalizado txtTotalItem;
        private TextBoxPersonalizado txtTotalVlrFrete;
        private TextBoxPersonalizado txtVlrTotalDespesas;
        private TextBoxPersonalizado txtVlrTotalDesconto;
        private TextBoxPersonalizado txtVlrTotalGeral;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ListView lwEntradaMercadorias;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel6;
        private btnPesonalizado btnConsultar;
        private System.Windows.Forms.DateTimePicker txtDataFinal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker txtDateInicial;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLimparBusca;
        private System.Windows.Forms.ColumnHeader colCod;
        private System.Windows.Forms.ColumnHeader colDataEntrada;
        private System.Windows.Forms.ColumnHeader colCnpj;
        private System.Windows.Forms.ColumnHeader colFonecedor;
        private System.Windows.Forms.ColumnHeader colNumeroNfe;
        private System.Windows.Forms.ColumnHeader colFrete;
        private System.Windows.Forms.ColumnHeader colDespesas;
        private System.Windows.Forms.ColumnHeader colDesconto;
        private System.Windows.Forms.ColumnHeader colTotalNotaFiscal;
        private ComboBoxPersonalizado txtNomeFornecedor;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ExcluirVendatoolStripMenuItem;
    }
}