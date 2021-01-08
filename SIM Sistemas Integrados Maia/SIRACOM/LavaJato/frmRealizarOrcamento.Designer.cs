namespace LavaJato
{
    partial class frmRealizarOrcamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRealizarOrcamento));
            this.panel1 = new System.Windows.Forms.Panel();
            this.listViewProdutos = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.codigoBarra = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSubtotalProduto = new LavaJato.TextBoxPersonalizado();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQtde = new LavaJato.TextBoxPersonalizado();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrecoUnitario = new LavaJato.TextBoxPersonalizado();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescricaoProduto = new LavaJato.TextBoxPersonalizado();
            this.txtCodigoBarra = new LavaJato.TextBoxPersonalizado();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNumeroOrcamento = new LavaJato.TextBoxPersonalizado();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDataOrcamento = new LavaJato.TextBoxPersonalizado();
            this.label11 = new System.Windows.Forms.Label();
            this.g = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCpfCNPJ = new LavaJato.TextBoxPersonalizado();
            this.txtNomeCliente = new LavaJato.TextBoxPersonalizado();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCodigoCliente = new LavaJato.TextBoxPersonalizado();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonSalvar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCancelar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.lblQtdeItem = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotalFinalPagar = new LavaJato.TextBoxPersonalizado();
            this.txtDesconto = new LavaJato.TextBoxPersonalizado();
            this.txtTotalOrcamento = new LavaJato.TextBoxPersonalizado();
            this.viewRealizarVendaTableAdapter1 = new LavaJato.dsSiradTableAdapters.ViewRealizarVendaTableAdapter();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.g.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.listViewProdutos);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(932, 482);
            this.panel1.TabIndex = 0;
            // 
            // listViewProdutos
            // 
            this.listViewProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewProdutos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.listViewProdutos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewProdutos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader7,
            this.codigoBarra,
            this.columnHeader8,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewProdutos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewProdutos.FullRowSelect = true;
            this.listViewProdutos.GridLines = true;
            this.listViewProdutos.Location = new System.Drawing.Point(9, 239);
            this.listViewProdutos.Name = "listViewProdutos";
            this.listViewProdutos.Size = new System.Drawing.Size(909, 231);
            this.listViewProdutos.TabIndex = 59;
            this.listViewProdutos.TabStop = false;
            this.listViewProdutos.UseCompatibleStateImageBehavior = false;
            this.listViewProdutos.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Item";
            this.columnHeader1.Width = 45;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Código";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader7.Width = 65;
            // 
            // codigoBarra
            // 
            this.codigoBarra.Text = "Código Barra";
            this.codigoBarra.Width = 120;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Produto";
            this.columnHeader8.Width = 350;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Preço Unitário";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader2.Width = 110;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Qtde";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader3.Width = 70;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Total";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader4.Width = 135;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Location = new System.Drawing.Point(9, 123);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(909, 100);
            this.panel3.TabIndex = 58;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtSubtotalProduto);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtQtde);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtPrecoUnitario);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtDescricaoProduto);
            this.groupBox2.Controls.Add(this.txtCodigoBarra);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox2.Location = new System.Drawing.Point(9, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(881, 80);
            this.groupBox2.TabIndex = 57;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informações do produto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(781, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Total:";
            // 
            // txtSubtotalProduto
            // 
            this.txtSubtotalProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubtotalProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSubtotalProduto.Enabled = false;
            this.txtSubtotalProduto.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubtotalProduto.Location = new System.Drawing.Point(784, 42);
            this.txtSubtotalProduto.Name = "txtSubtotalProduto";
            this.txtSubtotalProduto.Size = new System.Drawing.Size(85, 27);
            this.txtSubtotalProduto.TabIndex = 34;
            this.txtSubtotalProduto.TabStop = false;
            this.txtSubtotalProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(599, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Qtde:";
            // 
            // txtQtde
            // 
            this.txtQtde.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQtde.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtQtde.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtde.Location = new System.Drawing.Point(602, 42);
            this.txtQtde.MaxLength = 4;
            this.txtQtde.Name = "txtQtde";
            this.txtQtde.Size = new System.Drawing.Size(85, 27);
            this.txtQtde.TabIndex = 32;
            this.txtQtde.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(691, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Preço Unit:";
            // 
            // txtPrecoUnitario
            // 
            this.txtPrecoUnitario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecoUnitario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPrecoUnitario.Enabled = false;
            this.txtPrecoUnitario.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoUnitario.Location = new System.Drawing.Point(694, 42);
            this.txtPrecoUnitario.Name = "txtPrecoUnitario";
            this.txtPrecoUnitario.Size = new System.Drawing.Size(85, 27);
            this.txtPrecoUnitario.TabIndex = 30;
            this.txtPrecoUnitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrecoUnitario.Leave += new System.EventHandler(this.txtPrecoUnitario_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(224, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Descrição produto:";
            // 
            // txtDescricaoProduto
            // 
            this.txtDescricaoProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescricaoProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescricaoProduto.Enabled = false;
            this.txtDescricaoProduto.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricaoProduto.Location = new System.Drawing.Point(227, 42);
            this.txtDescricaoProduto.Name = "txtDescricaoProduto";
            this.txtDescricaoProduto.Size = new System.Drawing.Size(369, 27);
            this.txtDescricaoProduto.TabIndex = 28;
            this.txtDescricaoProduto.TabStop = false;
            // 
            // txtCodigoBarra
            // 
            this.txtCodigoBarra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigoBarra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigoBarra.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoBarra.Location = new System.Drawing.Point(15, 42);
            this.txtCodigoBarra.Name = "txtCodigoBarra";
            this.txtCodigoBarra.Size = new System.Drawing.Size(206, 27);
            this.txtCodigoBarra.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(12, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Código Barra:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.g);
            this.panel2.Location = new System.Drawing.Point(9, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(909, 101);
            this.panel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.txtNumeroOrcamento);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtDataOrcamento);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox1.Location = new System.Drawing.Point(9, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 85);
            this.groupBox1.TabIndex = 58;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações do orçamento";
            // 
            // txtNumeroOrcamento
            // 
            this.txtNumeroOrcamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumeroOrcamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumeroOrcamento.Enabled = false;
            this.txtNumeroOrcamento.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroOrcamento.Location = new System.Drawing.Point(120, 45);
            this.txtNumeroOrcamento.Name = "txtNumeroOrcamento";
            this.txtNumeroOrcamento.Size = new System.Drawing.Size(101, 27);
            this.txtNumeroOrcamento.TabIndex = 32;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(117, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "Número Orc:";
            // 
            // txtDataOrcamento
            // 
            this.txtDataOrcamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDataOrcamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDataOrcamento.Enabled = false;
            this.txtDataOrcamento.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataOrcamento.Location = new System.Drawing.Point(15, 45);
            this.txtDataOrcamento.Name = "txtDataOrcamento";
            this.txtDataOrcamento.Size = new System.Drawing.Size(97, 27);
            this.txtDataOrcamento.TabIndex = 30;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(12, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "Data:";
            // 
            // g
            // 
            this.g.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.g.Controls.Add(this.label9);
            this.g.Controls.Add(this.txtCpfCNPJ);
            this.g.Controls.Add(this.txtNomeCliente);
            this.g.Controls.Add(this.label13);
            this.g.Controls.Add(this.txtCodigoCliente);
            this.g.Controls.Add(this.label12);
            this.g.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.g.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.g.Location = new System.Drawing.Point(253, 3);
            this.g.Name = "g";
            this.g.Size = new System.Drawing.Size(637, 85);
            this.g.TabIndex = 57;
            this.g.TabStop = false;
            this.g.Text = "Informações do cliente";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(456, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "CPF/CNPJ:";
            // 
            // txtCpfCNPJ
            // 
            this.txtCpfCNPJ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCpfCNPJ.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCpfCNPJ.Enabled = false;
            this.txtCpfCNPJ.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpfCNPJ.Location = new System.Drawing.Point(459, 45);
            this.txtCpfCNPJ.Name = "txtCpfCNPJ";
            this.txtCpfCNPJ.Size = new System.Drawing.Size(169, 27);
            this.txtCpfCNPJ.TabIndex = 30;
            this.txtCpfCNPJ.TabStop = false;
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeCliente.Enabled = false;
            this.txtNomeCliente.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCliente.Location = new System.Drawing.Point(87, 45);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(366, 27);
            this.txtNomeCliente.TabIndex = 8;
            this.txtNomeCliente.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label13.Location = new System.Drawing.Point(84, 29);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "Cliente:";
            // 
            // txtCodigoCliente
            // 
            this.txtCodigoCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigoCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigoCliente.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoCliente.Location = new System.Drawing.Point(14, 45);
            this.txtCodigoCliente.Name = "txtCodigoCliente";
            this.txtCodigoCliente.Size = new System.Drawing.Size(66, 27);
            this.txtCodigoCliente.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label12.Location = new System.Drawing.Point(11, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Código:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(771, 562);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 40;
            this.label8.Text = "Total:";
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
            this.toolStripLabel5,
            this.toolStripSeparator5,
            this.toolStripLabel3,
            this.toolStripSeparator4,
            this.toolStripLabel4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(956, 39);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
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
            this.toolStripLabel2.Size = new System.Drawing.Size(150, 36);
            this.toolStripLabel2.Text = "F3 - Pesquisar Cliente";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(101, 36);
            this.toolStripLabel5.Text = "F4 - Desconto";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(156, 36);
            this.toolStripLabel3.Text = "F5 - Salvar Orçamento";
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
            this.toolStripLabel4.Size = new System.Drawing.Size(152, 36);
            this.toolStripLabel4.Text = "F6 - Novo Orçamento";
            // 
            // lblQtdeItem
            // 
            this.lblQtdeItem.AutoSize = true;
            this.lblQtdeItem.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdeItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblQtdeItem.Location = new System.Drawing.Point(19, 562);
            this.lblQtdeItem.Name = "lblQtdeItem";
            this.lblQtdeItem.Size = new System.Drawing.Size(37, 13);
            this.lblQtdeItem.TabIndex = 42;
            this.lblQtdeItem.Text = "Qtde";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(583, 562);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "Desconto:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(693, 596);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 13);
            this.label7.TabIndex = 46;
            this.label7.Text = "Total Final Pagar:";
            // 
            // txtTotalFinalPagar
            // 
            this.txtTotalFinalPagar.BackColor = System.Drawing.Color.Silver;
            this.txtTotalFinalPagar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalFinalPagar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTotalFinalPagar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalFinalPagar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtTotalFinalPagar.Location = new System.Drawing.Point(818, 587);
            this.txtTotalFinalPagar.Name = "txtTotalFinalPagar";
            this.txtTotalFinalPagar.ReadOnly = true;
            this.txtTotalFinalPagar.Size = new System.Drawing.Size(113, 27);
            this.txtTotalFinalPagar.TabIndex = 45;
            this.txtTotalFinalPagar.TabStop = false;
            this.txtTotalFinalPagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDesconto
            // 
            this.txtDesconto.BackColor = System.Drawing.Color.Silver;
            this.txtDesconto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDesconto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDesconto.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesconto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtDesconto.Location = new System.Drawing.Point(657, 554);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(113, 27);
            this.txtDesconto.TabIndex = 43;
            this.txtDesconto.TabStop = false;
            this.txtDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDesconto.Enter += new System.EventHandler(this.txtDesconto_Enter);
            // 
            // txtTotalOrcamento
            // 
            this.txtTotalOrcamento.BackColor = System.Drawing.Color.Silver;
            this.txtTotalOrcamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalOrcamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTotalOrcamento.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalOrcamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtTotalOrcamento.Location = new System.Drawing.Point(818, 554);
            this.txtTotalOrcamento.Name = "txtTotalOrcamento";
            this.txtTotalOrcamento.ReadOnly = true;
            this.txtTotalOrcamento.Size = new System.Drawing.Size(113, 27);
            this.txtTotalOrcamento.TabIndex = 38;
            this.txtTotalOrcamento.TabStop = false;
            this.txtTotalOrcamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // viewRealizarVendaTableAdapter1
            // 
            this.viewRealizarVendaTableAdapter1.ClearBeforeFill = true;
            // 
            // frmRealizarOrcamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(956, 623);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTotalFinalPagar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDesconto);
            this.Controls.Add(this.lblQtdeItem);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTotalOrcamento);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRealizarOrcamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Realizar Orçamento";
            this.Load += new System.EventHandler(this.frmRealizarOrcamento_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmRealizarOrcamento_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.g.ResumeLayout(false);
            this.g.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox g;
        private TextBoxPersonalizado txtNomeCliente;
        private System.Windows.Forms.Label label13;
        private TextBoxPersonalizado txtCodigoCliente;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox2;
        private TextBoxPersonalizado txtCodigoBarra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private TextBoxPersonalizado txtQtde;
        private System.Windows.Forms.Label label3;
        private TextBoxPersonalizado txtPrecoUnitario;
        private System.Windows.Forms.Label label1;
        private TextBoxPersonalizado txtDescricaoProduto;
        private TextBoxPersonalizado txtTotalOrcamento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListView listViewProdutos;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonSalvar;
        private System.Windows.Forms.ToolStripButton toolStripButtonCancelar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private TextBoxPersonalizado txtSubtotalProduto;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.Label label9;
        private TextBoxPersonalizado txtCpfCNPJ;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private TextBoxPersonalizado txtNumeroOrcamento;
        private System.Windows.Forms.Label label10;
        private TextBoxPersonalizado txtDataOrcamento;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ColumnHeader codigoBarra;
        private System.Windows.Forms.Label lblQtdeItem;
        private System.Windows.Forms.Label label6;
        private TextBoxPersonalizado txtDesconto;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.Label label7;
        private TextBoxPersonalizado txtTotalFinalPagar;
        private dsSiradTableAdapters.ViewRealizarVendaTableAdapter viewRealizarVendaTableAdapter1;
    }
}