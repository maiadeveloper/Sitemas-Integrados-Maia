namespace LavaJato
{
    partial class frmEntradasProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEntradasProdutos));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonSalvar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCancelar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDataEmissao = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtDataVencimento = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lwItensEntrada = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.codigoBarra = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLote = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDataVencimento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removerItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnNovoFornecedor = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNNotaFiscal = new LavaJato.TextBoxPersonalizado();
            this.txtNomeFornecedor = new LavaJato.ComboBoxPersonalizado();
            this.txtLote = new LavaJato.TextBoxPersonalizado();
            this.txtQtdeItem = new LavaJato.TextBoxPersonalizado();
            this.txtVlrTotalGeral = new LavaJato.TextBoxPersonalizado();
            this.txtQtdeProduto = new LavaJato.TextBoxPersonalizado();
            this.txtTotalVlrUnitario = new LavaJato.TextBoxPersonalizado();
            this.txtSubtotalProduto = new LavaJato.TextBoxPersonalizado();
            this.txtQtde = new LavaJato.TextBoxPersonalizado();
            this.txtPrecoUnitario = new LavaJato.TextBoxPersonalizado();
            this.txtDescricaoProduto = new LavaJato.TextBoxPersonalizado();
            this.txtCodigoBarra = new LavaJato.TextBoxPersonalizado();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonSalvar,
            this.toolStripButtonCancelar,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.toolStripSeparator3,
            this.toolStripLabel2,
            this.toolStripSeparator2,
            this.toolStripLabel3,
            this.toolStripSeparator4,
            this.toolStripLabel4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(994, 39);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonSalvar
            // 
            this.toolStripButtonSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSalvar.Enabled = false;
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(157, 36);
            this.toolStripLabel1.Text = "F2 - Pesquisar Produto";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(179, 36);
            this.toolStripLabel2.Text = "F3 - Pesquisar Fornecedor";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(133, 36);
            this.toolStripLabel3.Text = "F5 - Salvar Entrada";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(128, 36);
            this.toolStripLabel4.Text = "F6 - Nova Entrada";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(12, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Data Emissão";
            // 
            // txtDataEmissao
            // 
            this.txtDataEmissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataEmissao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataEmissao.Location = new System.Drawing.Point(16, 39);
            this.txtDataEmissao.Name = "txtDataEmissao";
            this.txtDataEmissao.Size = new System.Drawing.Size(111, 26);
            this.txtDataEmissao.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txtDataVencimento);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtLote);
            this.groupBox1.Controls.Add(this.txtQtdeItem);
            this.groupBox1.Controls.Add(this.txtVlrTotalGeral);
            this.groupBox1.Controls.Add(this.txtQtdeProduto);
            this.groupBox1.Controls.Add(this.txtTotalVlrUnitario);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtSubtotalProduto);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtQtde);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtPrecoUnitario);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtDescricaoProduto);
            this.groupBox1.Controls.Add(this.txtCodigoBarra);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lwItensEntrada);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 154);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(968, 426);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Itens  - Produtos";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(588, 25);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(76, 14);
            this.label15.TabIndex = 78;
            this.label15.Text = "Data Vcto:";
            // 
            // txtDataVencimento
            // 
            this.txtDataVencimento.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataVencimento.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.txtDataVencimento.Location = new System.Drawing.Point(590, 42);
            this.txtDataVencimento.Mask = "00/00/0000";
            this.txtDataVencimento.Name = "txtDataVencimento";
            this.txtDataVencimento.Size = new System.Drawing.Size(95, 25);
            this.txtDataVencimento.TabIndex = 9;
            this.txtDataVencimento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDataVencimento.ValidatingType = typeof(System.DateTime);
            this.txtDataVencimento.Leave += new System.EventHandler(this.txtDataVencimento_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(512, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 14);
            this.label6.TabIndex = 76;
            this.label6.Text = "Lote:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(849, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 14);
            this.label5.TabIndex = 70;
            this.label5.Text = "Vlr Total:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(688, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 14);
            this.label4.TabIndex = 68;
            this.label4.Text = "Quant:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(743, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 14);
            this.label3.TabIndex = 66;
            this.label3.Text = "Vlr.Compra";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(153, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 14);
            this.label1.TabIndex = 64;
            this.label1.Text = "Descrição dos Produtos / Serviços";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 14);
            this.label2.TabIndex = 62;
            this.label2.Text = "Código Barra:";
            // 
            // lwItensEntrada
            // 
            this.lwItensEntrada.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lwItensEntrada.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lwItensEntrada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lwItensEntrada.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader7,
            this.codigoBarra,
            this.columnHeader8,
            this.colLote,
            this.colDataVencimento,
            this.columnHeader3,
            this.columnHeader2,
            this.columnHeader4});
            this.lwItensEntrada.ContextMenuStrip = this.contextMenuStrip1;
            this.lwItensEntrada.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lwItensEntrada.FullRowSelect = true;
            this.lwItensEntrada.GridLines = true;
            this.lwItensEntrada.Location = new System.Drawing.Point(16, 74);
            this.lwItensEntrada.Name = "lwItensEntrada";
            this.lwItensEntrada.Size = new System.Drawing.Size(937, 309);
            this.lwItensEntrada.TabIndex = 60;
            this.lwItensEntrada.TabStop = false;
            this.lwItensEntrada.UseCompatibleStateImageBehavior = false;
            this.lwItensEntrada.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Item";
            this.columnHeader1.Width = 42;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Cod";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader7.Width = 50;
            // 
            // codigoBarra
            // 
            this.codigoBarra.Text = "Código Barra";
            this.codigoBarra.Width = 120;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Descrição dos Produtos / Serviços";
            this.columnHeader8.Width = 302;
            // 
            // colLote
            // 
            this.colLote.Text = "Lote";
            this.colLote.Width = 80;
            // 
            // colDataVencimento
            // 
            this.colDataVencimento.Text = "Data Vcto";
            this.colDataVencimento.Width = 90;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Quant.";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader3.Width = 55;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Vlr Comp.";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader2.Width = 90;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Vlr Total";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader4.Width = 92;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removerItemToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(149, 26);
            this.contextMenuStrip1.Click += new System.EventHandler(this.contextMenuStrip1_Click);
            // 
            // removerItemToolStripMenuItem
            // 
            this.removerItemToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("removerItemToolStripMenuItem.Image")));
            this.removerItemToolStripMenuItem.Name = "removerItemToolStripMenuItem";
            this.removerItemToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.removerItemToolStripMenuItem.Text = "Remover item";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(130, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 13);
            this.label10.TabIndex = 58;
            this.label10.Text = "Nº Nota Fiscal:";
            // 
            // groupBox4
            // 
            this.groupBox4.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.groupBox4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox4.Controls.Add(this.txtNNotaFiscal);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.btnNovoFornecedor);
            this.groupBox4.Controls.Add(this.txtDataEmissao);
            this.groupBox4.Controls.Add(this.txtNomeFornecedor);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(12, 48);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(968, 88);
            this.groupBox4.TabIndex = 58;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Informações Gerais";
            // 
            // btnNovoFornecedor
            // 
            this.btnNovoFornecedor.BackColor = System.Drawing.Color.White;
            this.btnNovoFornecedor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNovoFornecedor.BackgroundImage")));
            this.btnNovoFornecedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNovoFornecedor.Location = new System.Drawing.Point(924, 38);
            this.btnNovoFornecedor.Name = "btnNovoFornecedor";
            this.btnNovoFornecedor.Size = new System.Drawing.Size(28, 27);
            this.btnNovoFornecedor.TabIndex = 1;
            this.btnNovoFornecedor.TabStop = false;
            this.btnNovoFornecedor.UseVisualStyleBackColor = false;
            this.btnNovoFornecedor.Click += new System.EventHandler(this.btnNovoFornecedor_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(249, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(138, 13);
            this.label11.TabIndex = 32;
            this.label11.Text = "Nome/Razão Social:";
            // 
            // txtNNotaFiscal
            // 
            this.txtNNotaFiscal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNNotaFiscal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNNotaFiscal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNNotaFiscal.Location = new System.Drawing.Point(133, 38);
            this.txtNNotaFiscal.Name = "txtNNotaFiscal";
            this.txtNNotaFiscal.Size = new System.Drawing.Size(113, 27);
            this.txtNNotaFiscal.TabIndex = 2;
            // 
            // txtNomeFornecedor
            // 
            this.txtNomeFornecedor.AccessibleRole = System.Windows.Forms.AccessibleRole.Dialog;
            this.txtNomeFornecedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtNomeFornecedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtNomeFornecedor.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeFornecedor.FormattingEnabled = true;
            this.txtNomeFornecedor.Location = new System.Drawing.Point(252, 37);
            this.txtNomeFornecedor.Name = "txtNomeFornecedor";
            this.txtNomeFornecedor.Size = new System.Drawing.Size(665, 28);
            this.txtNomeFornecedor.TabIndex = 0;
            this.txtNomeFornecedor.Text = "Selecione...";
            // 
            // txtLote
            // 
            this.txtLote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLote.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLote.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLote.Location = new System.Drawing.Point(515, 41);
            this.txtLote.MaxLength = 4;
            this.txtLote.Name = "txtLote";
            this.txtLote.Size = new System.Drawing.Size(69, 27);
            this.txtLote.TabIndex = 8;
            this.txtLote.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtQtdeItem
            // 
            this.txtQtdeItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQtdeItem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtQtdeItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtdeItem.Location = new System.Drawing.Point(16, 390);
            this.txtQtdeItem.MaxLength = 4;
            this.txtQtdeItem.Name = "txtQtdeItem";
            this.txtQtdeItem.ReadOnly = true;
            this.txtQtdeItem.Size = new System.Drawing.Size(46, 27);
            this.txtQtdeItem.TabIndex = 74;
            this.txtQtdeItem.TabStop = false;
            this.txtQtdeItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtVlrTotalGeral
            // 
            this.txtVlrTotalGeral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVlrTotalGeral.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtVlrTotalGeral.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVlrTotalGeral.Location = new System.Drawing.Point(852, 390);
            this.txtVlrTotalGeral.Name = "txtVlrTotalGeral";
            this.txtVlrTotalGeral.ReadOnly = true;
            this.txtVlrTotalGeral.Size = new System.Drawing.Size(100, 27);
            this.txtVlrTotalGeral.TabIndex = 73;
            this.txtVlrTotalGeral.TabStop = false;
            this.txtVlrTotalGeral.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtQtdeProduto
            // 
            this.txtQtdeProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQtdeProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtQtdeProduto.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtdeProduto.Location = new System.Drawing.Point(691, 390);
            this.txtQtdeProduto.MaxLength = 4;
            this.txtQtdeProduto.Name = "txtQtdeProduto";
            this.txtQtdeProduto.ReadOnly = true;
            this.txtQtdeProduto.Size = new System.Drawing.Size(50, 27);
            this.txtQtdeProduto.TabIndex = 72;
            this.txtQtdeProduto.TabStop = false;
            this.txtQtdeProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTotalVlrUnitario
            // 
            this.txtTotalVlrUnitario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalVlrUnitario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTotalVlrUnitario.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalVlrUnitario.Location = new System.Drawing.Point(746, 390);
            this.txtTotalVlrUnitario.Name = "txtTotalVlrUnitario";
            this.txtTotalVlrUnitario.ReadOnly = true;
            this.txtTotalVlrUnitario.Size = new System.Drawing.Size(100, 27);
            this.txtTotalVlrUnitario.TabIndex = 71;
            this.txtTotalVlrUnitario.TabStop = false;
            this.txtTotalVlrUnitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSubtotalProduto
            // 
            this.txtSubtotalProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubtotalProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSubtotalProduto.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubtotalProduto.Location = new System.Drawing.Point(852, 41);
            this.txtSubtotalProduto.Name = "txtSubtotalProduto";
            this.txtSubtotalProduto.ReadOnly = true;
            this.txtSubtotalProduto.Size = new System.Drawing.Size(100, 27);
            this.txtSubtotalProduto.TabIndex = 12;
            this.txtSubtotalProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSubtotalProduto.Enter += new System.EventHandler(this.txtSubtotalProduto_Enter);
            // 
            // txtQtde
            // 
            this.txtQtde.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQtde.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtQtde.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtde.Location = new System.Drawing.Point(691, 41);
            this.txtQtde.MaxLength = 4;
            this.txtQtde.Name = "txtQtde";
            this.txtQtde.Size = new System.Drawing.Size(49, 27);
            this.txtQtde.TabIndex = 10;
            this.txtQtde.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQtde.Enter += new System.EventHandler(this.txtQtde_Enter);
            this.txtQtde.Leave += new System.EventHandler(this.txtQtde_Leave);
            // 
            // txtPrecoUnitario
            // 
            this.txtPrecoUnitario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecoUnitario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPrecoUnitario.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoUnitario.Location = new System.Drawing.Point(746, 41);
            this.txtPrecoUnitario.Name = "txtPrecoUnitario";
            this.txtPrecoUnitario.Size = new System.Drawing.Size(100, 27);
            this.txtPrecoUnitario.TabIndex = 11;
            this.txtPrecoUnitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrecoUnitario.Enter += new System.EventHandler(this.txtPrecoUnitario_Enter);
            this.txtPrecoUnitario.Leave += new System.EventHandler(this.txtPrecoUnitario_Leave);
            // 
            // txtDescricaoProduto
            // 
            this.txtDescricaoProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescricaoProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescricaoProduto.Enabled = false;
            this.txtDescricaoProduto.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricaoProduto.Location = new System.Drawing.Point(153, 41);
            this.txtDescricaoProduto.Name = "txtDescricaoProduto";
            this.txtDescricaoProduto.Size = new System.Drawing.Size(356, 27);
            this.txtDescricaoProduto.TabIndex = 63;
            this.txtDescricaoProduto.TabStop = false;
            // 
            // txtCodigoBarra
            // 
            this.txtCodigoBarra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigoBarra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigoBarra.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoBarra.Location = new System.Drawing.Point(16, 41);
            this.txtCodigoBarra.Name = "txtCodigoBarra";
            this.txtCodigoBarra.Size = new System.Drawing.Size(131, 27);
            this.txtCodigoBarra.TabIndex = 7;
            this.txtCodigoBarra.Enter += new System.EventHandler(this.txtCodigoBarra_Enter);
            this.txtCodigoBarra.Leave += new System.EventHandler(this.txtCodigoBarra_Leave);
            // 
            // frmEntradasProdutos
            // 
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(994, 595);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEntradasProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmEntradasProdutos_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmEntradasProdutos_KeyDown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonSalvar;
        private System.Windows.Forms.ToolStripButton toolStripButtonCancelar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lwItensEntrada;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader codigoBarra;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private TextBoxPersonalizado txtVlrTotalGeral;
        private TextBoxPersonalizado txtQtdeProduto;
        private TextBoxPersonalizado txtTotalVlrUnitario;
        private System.Windows.Forms.Label label5;
        private TextBoxPersonalizado txtSubtotalProduto;
        private System.Windows.Forms.Label label4;
        private TextBoxPersonalizado txtQtde;
        private System.Windows.Forms.Label label3;
        private TextBoxPersonalizado txtPrecoUnitario;
        private System.Windows.Forms.Label label1;
        private TextBoxPersonalizado txtDescricaoProduto;
        private TextBoxPersonalizado txtCodigoBarra;
        private System.Windows.Forms.Label label2;
        private TextBoxPersonalizado txtQtdeItem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker txtDataEmissao;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label11;
        private ComboBoxPersonalizado txtNomeFornecedor;
        private System.Windows.Forms.Button btnNovoFornecedor;
        private TextBoxPersonalizado txtNNotaFiscal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.MaskedTextBox txtDataVencimento;
        private System.Windows.Forms.Label label6;
        private TextBoxPersonalizado txtLote;
        private System.Windows.Forms.ColumnHeader colLote;
        private System.Windows.Forms.ColumnHeader colDataVencimento;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem removerItemToolStripMenuItem;

    }
}