namespace LavaJato
{
    partial class frmManterProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManterProdutos));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnAdicionarCategoria = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonSalvar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtCaminhoImagem = new System.Windows.Forms.TextBox();
            this.btnSelecionarImagem = new System.Windows.Forms.Button();
            this.picItem = new System.Windows.Forms.PictureBox();
            this.g = new System.Windows.Forms.GroupBox();
            this.txtLucro = new LavaJato.TextBoxPersonalizado();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMargemLucro = new LavaJato.TextBoxPersonalizado();
            this.label14 = new System.Windows.Forms.Label();
            this.txtValorVenda = new LavaJato.TextBoxPersonalizado();
            this.label13 = new System.Windows.Forms.Label();
            this.txtValorCompra = new LavaJato.TextBoxPersonalizado();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtNomeProduto = new LavaJato.TextBoxPersonalizado();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCategoriaProduto = new LavaJato.ComboBoxPersonalizado();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQtdeMax = new LavaJato.TextBoxPersonalizado();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQtdeMin = new LavaJato.TextBoxPersonalizado();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUnidadeCompra = new LavaJato.ComboBoxPersonalizado();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCodigoBarra = new LavaJato.TextBoxPersonalizado();
            this.txtDataCadastro = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDescricaoProduto = new LavaJato.TextBoxPersonalizado();
            this.dsSirad = new LavaJato.dsSirad();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.toolStrip1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picItem)).BeginInit();
            this.g.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsSirad)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // btnAdicionarCategoria
            // 
            this.btnAdicionarCategoria.BackColor = System.Drawing.Color.White;
            this.btnAdicionarCategoria.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdicionarCategoria.BackgroundImage")));
            this.btnAdicionarCategoria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdicionarCategoria.Enabled = false;
            this.btnAdicionarCategoria.Location = new System.Drawing.Point(433, 143);
            this.btnAdicionarCategoria.Name = "btnAdicionarCategoria";
            this.btnAdicionarCategoria.Size = new System.Drawing.Size(28, 27);
            this.btnAdicionarCategoria.TabIndex = 80;
            this.btnAdicionarCategoria.TabStop = false;
            this.toolTip1.SetToolTip(this.btnAdicionarCategoria, "Adicionar Categoria");
            this.btnAdicionarCategoria.UseVisualStyleBackColor = false;
            this.btnAdicionarCategoria.Click += new System.EventHandler(this.btnAdicionarCategoria_Click_1);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.LightGray;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonSalvar,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(822, 39);
            this.toolStrip1.TabIndex = 84;
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
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton2.Text = "Cancelar";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.Controls.Add(this.txtCaminhoImagem);
            this.tabPage2.Controls.Add(this.btnSelecionarImagem);
            this.tabPage2.Controls.Add(this.picItem);
            this.tabPage2.Controls.Add(this.g);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(814, 526);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Produto";
            // 
            // txtCaminhoImagem
            // 
            this.txtCaminhoImagem.Location = new System.Drawing.Point(12, 394);
            this.txtCaminhoImagem.Name = "txtCaminhoImagem";
            this.txtCaminhoImagem.ReadOnly = true;
            this.txtCaminhoImagem.Size = new System.Drawing.Size(568, 25);
            this.txtCaminhoImagem.TabIndex = 59;
            // 
            // btnSelecionarImagem
            // 
            this.btnSelecionarImagem.Enabled = false;
            this.btnSelecionarImagem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecionarImagem.Image = ((System.Drawing.Image)(resources.GetObject("btnSelecionarImagem.Image")));
            this.btnSelecionarImagem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSelecionarImagem.Location = new System.Drawing.Point(599, 392);
            this.btnSelecionarImagem.Name = "btnSelecionarImagem";
            this.btnSelecionarImagem.Size = new System.Drawing.Size(198, 27);
            this.btnSelecionarImagem.TabIndex = 58;
            this.btnSelecionarImagem.Text = "Selecione imagem produto";
            this.btnSelecionarImagem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelecionarImagem.UseVisualStyleBackColor = true;
            this.btnSelecionarImagem.Click += new System.EventHandler(this.btnSelecionarImagem_Click_1);
            // 
            // picItem
            // 
            this.picItem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picItem.Location = new System.Drawing.Point(599, 251);
            this.picItem.Margin = new System.Windows.Forms.Padding(4);
            this.picItem.Name = "picItem";
            this.picItem.Size = new System.Drawing.Size(198, 134);
            this.picItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picItem.TabIndex = 57;
            this.picItem.TabStop = false;
            // 
            // g
            // 
            this.g.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.g.Controls.Add(this.txtLucro);
            this.g.Controls.Add(this.label11);
            this.g.Controls.Add(this.txtMargemLucro);
            this.g.Controls.Add(this.label14);
            this.g.Controls.Add(this.txtValorVenda);
            this.g.Controls.Add(this.label13);
            this.g.Controls.Add(this.txtValorCompra);
            this.g.Controls.Add(this.label12);
            this.g.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.g.ForeColor = System.Drawing.Color.White;
            this.g.Location = new System.Drawing.Point(11, 245);
            this.g.Name = "g";
            this.g.Size = new System.Drawing.Size(569, 139);
            this.g.TabIndex = 56;
            this.g.TabStop = false;
            this.g.Text = "Preço";
            // 
            // txtLucro
            // 
            this.txtLucro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLucro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLucro.Enabled = false;
            this.txtLucro.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLucro.Location = new System.Drawing.Point(17, 97);
            this.txtLucro.Name = "txtLucro";
            this.txtLucro.Size = new System.Drawing.Size(188, 27);
            this.txtLucro.TabIndex = 32;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(13, 82);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 13);
            this.label11.TabIndex = 33;
            this.label11.Text = "Lucro real($) :";
            // 
            // txtMargemLucro
            // 
            this.txtMargemLucro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMargemLucro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMargemLucro.Enabled = false;
            this.txtMargemLucro.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMargemLucro.Location = new System.Drawing.Point(409, 50);
            this.txtMargemLucro.Name = "txtMargemLucro";
            this.txtMargemLucro.Size = new System.Drawing.Size(116, 27);
            this.txtMargemLucro.TabIndex = 30;
            this.txtMargemLucro.Leave += new System.EventHandler(this.txtMargemLucro_Leave);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(406, 34);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(129, 13);
            this.label14.TabIndex = 31;
            this.label14.Text = "Margem Lucro(%):";
            // 
            // txtValorVenda
            // 
            this.txtValorVenda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValorVenda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtValorVenda.Enabled = false;
            this.txtValorVenda.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorVenda.Location = new System.Drawing.Point(213, 50);
            this.txtValorVenda.Name = "txtValorVenda";
            this.txtValorVenda.Size = new System.Drawing.Size(190, 27);
            this.txtValorVenda.TabIndex = 8;
            this.txtValorVenda.Leave += new System.EventHandler(this.txtValorVenda_Leave_1);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(209, 34);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(109, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "Valor de Venda:";
            // 
            // txtValorCompra
            // 
            this.txtValorCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValorCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtValorCompra.Enabled = false;
            this.txtValorCompra.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorCompra.Location = new System.Drawing.Point(15, 50);
            this.txtValorCompra.Name = "txtValorCompra";
            this.txtValorCompra.Size = new System.Drawing.Size(190, 27);
            this.txtValorCompra.TabIndex = 7;
            this.txtValorCompra.Leave += new System.EventHandler(this.txtValorCompra_Leave_1);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(12, 34);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(119, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Valor de Compra:";
            // 
            // groupBox3
            // 
            this.groupBox3.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.groupBox3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox3.Controls.Add(this.btnAdicionarCategoria);
            this.groupBox3.Controls.Add(this.txtNomeProduto);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtCategoriaProduto);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtQtdeMax);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtQtdeMin);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtUnidadeCompra);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtCodigoBarra);
            this.groupBox3.Controls.Add(this.txtDataCadastro);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtDescricaoProduto);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(11, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(792, 236);
            this.groupBox3.TabIndex = 54;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Informações do produto";
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeProduto.Enabled = false;
            this.txtNomeProduto.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeProduto.Location = new System.Drawing.Point(16, 93);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(357, 27);
            this.txtNomeProduto.TabIndex = 1;
            this.txtNomeProduto.TextChanged += new System.EventHandler(this.txtNomeProduto_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Data Cadastro:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(14, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 13);
            this.label10.TabIndex = 35;
            this.label10.Text = "Nome Produto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(131, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Código Barra:";
            // 
            // txtCategoriaProduto
            // 
            this.txtCategoriaProduto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtCategoriaProduto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtCategoriaProduto.DisplayMember = "categoriaID";
            this.txtCategoriaProduto.Enabled = false;
            this.txtCategoriaProduto.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoriaProduto.FormattingEnabled = true;
            this.txtCategoriaProduto.Items.AddRange(new object[] {
            "teste"});
            this.txtCategoriaProduto.Location = new System.Drawing.Point(15, 143);
            this.txtCategoriaProduto.Name = "txtCategoriaProduto";
            this.txtCategoriaProduto.Size = new System.Drawing.Size(415, 28);
            this.txtCategoriaProduto.TabIndex = 3;
            this.txtCategoriaProduto.Text = "Selecione...";
            this.txtCategoriaProduto.ValueMember = "categoriaID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(379, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Descrição Produto:";
            // 
            // txtQtdeMax
            // 
            this.txtQtdeMax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQtdeMax.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtQtdeMax.Enabled = false;
            this.txtQtdeMax.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtdeMax.Location = new System.Drawing.Point(15, 192);
            this.txtQtdeMax.Name = "txtQtdeMax";
            this.txtQtdeMax.Size = new System.Drawing.Size(446, 27);
            this.txtQtdeMax.TabIndex = 5;
            this.txtQtdeMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQtdeMax_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Categoria:";
            // 
            // txtQtdeMin
            // 
            this.txtQtdeMin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQtdeMin.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtQtdeMin.Enabled = false;
            this.txtQtdeMin.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtdeMin.Location = new System.Drawing.Point(484, 192);
            this.txtQtdeMin.Name = "txtQtdeMin";
            this.txtQtdeMin.Size = new System.Drawing.Size(301, 27);
            this.txtQtdeMin.TabIndex = 6;
            this.txtQtdeMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQtdeMin_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(483, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Unidade Compra:";
            // 
            // txtUnidadeCompra
            // 
            this.txtUnidadeCompra.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtUnidadeCompra.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtUnidadeCompra.Enabled = false;
            this.txtUnidadeCompra.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnidadeCompra.FormattingEnabled = true;
            this.txtUnidadeCompra.Items.AddRange(new object[] {
            "Unidade Unidade",
            "Unidade Volume",
            "Unidade Peça",
            "Unidade Tambor",
            "Unidade Kilo Grama",
            "Indefinido"});
            this.txtUnidadeCompra.Location = new System.Drawing.Point(484, 143);
            this.txtUnidadeCompra.Name = "txtUnidadeCompra";
            this.txtUnidadeCompra.Size = new System.Drawing.Size(301, 28);
            this.txtUnidadeCompra.TabIndex = 4;
            this.txtUnidadeCompra.Text = "Selecione...";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(481, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Estoque Mínimo:";
            // 
            // txtCodigoBarra
            // 
            this.txtCodigoBarra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigoBarra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigoBarra.Enabled = false;
            this.txtCodigoBarra.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoBarra.Location = new System.Drawing.Point(133, 43);
            this.txtCodigoBarra.Name = "txtCodigoBarra";
            this.txtCodigoBarra.Size = new System.Drawing.Size(652, 27);
            this.txtCodigoBarra.TabIndex = 0;
            this.txtCodigoBarra.Leave += new System.EventHandler(this.txtCodigoBarra_Leave_1);
            // 
            // txtDataCadastro
            // 
            this.txtDataCadastro.Enabled = false;
            this.txtDataCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataCadastro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataCadastro.Location = new System.Drawing.Point(15, 44);
            this.txtDataCadastro.Name = "txtDataCadastro";
            this.txtDataCadastro.Size = new System.Drawing.Size(111, 26);
            this.txtDataCadastro.TabIndex = 31;
            this.txtDataCadastro.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(14, 176);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "Estoque Máximo";
            // 
            // txtDescricaoProduto
            // 
            this.txtDescricaoProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescricaoProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescricaoProduto.Enabled = false;
            this.txtDescricaoProduto.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricaoProduto.Location = new System.Drawing.Point(379, 93);
            this.txtDescricaoProduto.Name = "txtDescricaoProduto";
            this.txtDescricaoProduto.Size = new System.Drawing.Size(406, 27);
            this.txtDescricaoProduto.TabIndex = 2;
            // 
            // dsSirad
            // 
            this.dsSirad.DataSetName = "dsSirad";
            this.dsSirad.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 46);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(50, 7);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(822, 564);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.TabStop = false;
            // 
            // frmManterProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(822, 512);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tabControl1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmManterProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar - Produtos";
            this.Load += new System.EventHandler(this.frmManterProdutos_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmManterProdutos_KeyDown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picItem)).EndInit();
            this.g.ResumeLayout(false);
            this.g.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsSirad)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonSalvar;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.OpenFileDialog dlgOpen;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtCaminhoImagem;
        private System.Windows.Forms.Button btnSelecionarImagem;
        private System.Windows.Forms.PictureBox picItem;
        private System.Windows.Forms.GroupBox g;
        private TextBoxPersonalizado txtLucro;
        private System.Windows.Forms.Label label11;
        private TextBoxPersonalizado txtMargemLucro;
        private System.Windows.Forms.Label label14;
        private TextBoxPersonalizado txtValorVenda;
        private System.Windows.Forms.Label label13;
        private TextBoxPersonalizado txtValorCompra;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAdicionarCategoria;
        private TextBoxPersonalizado txtNomeProduto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private ComboBoxPersonalizado txtCategoriaProduto;
        private System.Windows.Forms.Label label3;
        private TextBoxPersonalizado txtQtdeMax;
        private System.Windows.Forms.Label label4;
        private TextBoxPersonalizado txtQtdeMin;
        private System.Windows.Forms.Label label7;
        private ComboBoxPersonalizado txtUnidadeCompra;
        private System.Windows.Forms.Label label8;
        private TextBoxPersonalizado txtCodigoBarra;
        private System.Windows.Forms.DateTimePicker txtDataCadastro;
        private System.Windows.Forms.Label label9;
        private TextBoxPersonalizado txtDescricaoProduto;
        private System.Windows.Forms.TabControl tabControl1;
        private dsSirad dsSirad;
    }
}