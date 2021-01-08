namespace LavaJato
{
    partial class frmBaseTodasNegociacoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBaseTodasNegociacoes));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSair = new System.Windows.Forms.ToolStripButton();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLimparBusca = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lwNegociacoes = new System.Windows.Forms.ListView();
            this.columnCod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCnpjCpf = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnFantasia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnParc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnVlor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnRef = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.baixarContaReceberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rbAberto = new System.Windows.Forms.RadioButton();
            this.rbTodos = new System.Windows.Forms.RadioButton();
            this.rbFechado = new System.Windows.Forms.RadioButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.columnSituacao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotalAberto = new LavaJato.TextBoxPersonalizado();
            this.txtTotalFechado = new LavaJato.TextBoxPersonalizado();
            this.txtTotalItem = new LavaJato.TextBoxPersonalizado();
            this.txtTotal = new LavaJato.TextBoxPersonalizado();
            this.txtBusca = new LavaJato.TextBoxPersonalizado();
            this.toolStrip1.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.LightGray;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSair});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1221, 39);
            this.toolStrip1.TabIndex = 72;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSair
            // 
            this.toolStripSair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSair.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSair.Image")));
            this.toolStripSair.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSair.Name = "toolStripSair";
            this.toolStripSair.RightToLeftAutoMirrorImage = true;
            this.toolStripSair.Size = new System.Drawing.Size(36, 36);
            this.toolStripSair.Text = "Cancelar";
            this.toolStripSair.ToolTipText = "Cancelar";
            this.toolStripSair.Click += new System.EventHandler(this.toolStripSair_Click);
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel8.BackColor = System.Drawing.Color.LightGray;
            this.panel8.Controls.Add(this.label10);
            this.panel8.Controls.Add(this.pictureBox4);
            this.panel8.Location = new System.Drawing.Point(161, 51);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1049, 24);
            this.panel8.TabIndex = 77;
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
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtBusca);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnLimparBusca);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(161, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1049, 75);
            this.panel1.TabIndex = 76;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(425, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Pesquisar (Nome Fantasia,Razão Social,CPF,CNPJ ou Telefone) ";
            // 
            // btnLimparBusca
            // 
            this.btnLimparBusca.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnLimparBusca.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnLimparBusca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLimparBusca.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparBusca.Image = ((System.Drawing.Image)(resources.GetObject("btnLimparBusca.Image")));
            this.btnLimparBusca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimparBusca.Location = new System.Drawing.Point(493, 34);
            this.btnLimparBusca.Name = "btnLimparBusca";
            this.btnLimparBusca.Size = new System.Drawing.Size(83, 23);
            this.btnLimparBusca.TabIndex = 3;
            this.btnLimparBusca.Text = "Limpar";
            this.btnLimparBusca.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimparBusca.UseVisualStyleBackColor = false;
            this.btnLimparBusca.Click += new System.EventHandler(this.btnLimparBusca_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.LightGray;
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Location = new System.Drawing.Point(10, 157);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1200, 24);
            this.panel4.TabIndex = 89;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(37, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 20);
            this.label6.TabIndex = 51;
            this.label6.Text = "Negociações";
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
            // lwNegociacoes
            // 
            this.lwNegociacoes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lwNegociacoes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lwNegociacoes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnSituacao,
            this.columnCod,
            this.columnCnpjCpf,
            this.columnFantasia,
            this.columnParc,
            this.columnDV,
            this.columnVlor,
            this.columnRef});
            this.lwNegociacoes.ContextMenuStrip = this.contextMenuStrip2;
            this.lwNegociacoes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lwNegociacoes.FullRowSelect = true;
            this.lwNegociacoes.GridLines = true;
            this.lwNegociacoes.Location = new System.Drawing.Point(10, 181);
            this.lwNegociacoes.Name = "lwNegociacoes";
            this.lwNegociacoes.Size = new System.Drawing.Size(1199, 211);
            this.lwNegociacoes.SmallImageList = this.imageList1;
            this.lwNegociacoes.TabIndex = 88;
            this.lwNegociacoes.UseCompatibleStateImageBehavior = false;
            this.lwNegociacoes.View = System.Windows.Forms.View.Details;
            // 
            // columnCod
            // 
            this.columnCod.Text = "Cod";
            // 
            // columnCnpjCpf
            // 
            this.columnCnpjCpf.Text = "CPF/CNPJ";
            this.columnCnpjCpf.Width = 200;
            // 
            // columnFantasia
            // 
            this.columnFantasia.Text = "Cliente";
            this.columnFantasia.Width = 300;
            // 
            // columnParc
            // 
            this.columnParc.Text = "Parcela";
            this.columnParc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnParc.Width = 100;
            // 
            // columnDV
            // 
            this.columnDV.Text = "Data Vcto";
            this.columnDV.Width = 200;
            // 
            // columnVlor
            // 
            this.columnVlor.Text = "Valor";
            this.columnVlor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnVlor.Width = 120;
            // 
            // columnRef
            // 
            this.columnRef.Text = "Referente a conta";
            this.columnRef.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnRef.Width = 200;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.baixarContaReceberToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip1";
            this.contextMenuStrip2.Size = new System.Drawing.Size(180, 34);
            this.contextMenuStrip2.Text = "Baixar conta";
            // 
            // baixarContaReceberToolStripMenuItem
            // 
            this.baixarContaReceberToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("baixarContaReceberToolStripMenuItem.Image")));
            this.baixarContaReceberToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.baixarContaReceberToolStripMenuItem.Name = "baixarContaReceberToolStripMenuItem";
            this.baixarContaReceberToolStripMenuItem.Size = new System.Drawing.Size(179, 30);
            this.baixarContaReceberToolStripMenuItem.Text = "Baixar Negociação";
            this.baixarContaReceberToolStripMenuItem.Click += new System.EventHandler(this.baixarContaReceberToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(10, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(145, 24);
            this.panel2.TabIndex = 98;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(37, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 51;
            this.label2.Text = "Situação";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(2, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 22);
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.rbFechado);
            this.panel3.Controls.Add(this.rbAberto);
            this.panel3.Controls.Add(this.rbTodos);
            this.panel3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(10, 76);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(145, 74);
            this.panel3.TabIndex = 97;
            // 
            // rbAberto
            // 
            this.rbAberto.AutoSize = true;
            this.rbAberto.Location = new System.Drawing.Point(12, 23);
            this.rbAberto.Name = "rbAberto";
            this.rbAberto.Size = new System.Drawing.Size(73, 24);
            this.rbAberto.TabIndex = 49;
            this.rbAberto.Text = "Aberto";
            this.rbAberto.UseVisualStyleBackColor = true;
            this.rbAberto.CheckedChanged += new System.EventHandler(this.rbAberto_CheckedChanged);
            // 
            // rbTodos
            // 
            this.rbTodos.AutoSize = true;
            this.rbTodos.Checked = true;
            this.rbTodos.Location = new System.Drawing.Point(12, 3);
            this.rbTodos.Name = "rbTodos";
            this.rbTodos.Size = new System.Drawing.Size(68, 24);
            this.rbTodos.TabIndex = 47;
            this.rbTodos.TabStop = true;
            this.rbTodos.Text = "Todos";
            this.rbTodos.UseVisualStyleBackColor = true;
            this.rbTodos.CheckedChanged += new System.EventHandler(this.rbTodos_CheckedChanged);
            // 
            // rbFechado
            // 
            this.rbFechado.AutoSize = true;
            this.rbFechado.Location = new System.Drawing.Point(12, 44);
            this.rbFechado.Name = "rbFechado";
            this.rbFechado.Size = new System.Drawing.Size(83, 24);
            this.rbFechado.TabIndex = 50;
            this.rbFechado.Text = "Fechado";
            this.rbFechado.UseVisualStyleBackColor = true;
            this.rbFechado.CheckedChanged += new System.EventHandler(this.rbFechado_CheckedChanged);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "delete.png");
            this.imageList1.Images.SetKeyName(1, "apply.png");
            // 
            // columnSituacao
            // 
            this.columnSituacao.Text = "Situacao?";
            this.columnSituacao.Width = 90;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(849, 401);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Total geral:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(371, 401);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 19);
            this.label4.TabIndex = 99;
            this.label4.Text = "Total fechado:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(619, 401);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 19);
            this.label5.TabIndex = 101;
            this.label5.Text = "Total aberto:";
            // 
            // txtTotalAberto
            // 
            this.txtTotalAberto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalAberto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalAberto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalAberto.Location = new System.Drawing.Point(738, 399);
            this.txtTotalAberto.Name = "txtTotalAberto";
            this.txtTotalAberto.ReadOnly = true;
            this.txtTotalAberto.Size = new System.Drawing.Size(100, 24);
            this.txtTotalAberto.TabIndex = 102;
            this.txtTotalAberto.TabStop = false;
            this.txtTotalAberto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotalFechado
            // 
            this.txtTotalFechado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalFechado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalFechado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalFechado.Location = new System.Drawing.Point(498, 399);
            this.txtTotalFechado.Name = "txtTotalFechado";
            this.txtTotalFechado.ReadOnly = true;
            this.txtTotalFechado.Size = new System.Drawing.Size(100, 24);
            this.txtTotalFechado.TabIndex = 100;
            this.txtTotalFechado.TabStop = false;
            this.txtTotalFechado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotalItem
            // 
            this.txtTotalItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTotalItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalItem.Location = new System.Drawing.Point(10, 399);
            this.txtTotalItem.Name = "txtTotalItem";
            this.txtTotalItem.ReadOnly = true;
            this.txtTotalItem.Size = new System.Drawing.Size(100, 24);
            this.txtTotalItem.TabIndex = 96;
            this.txtTotalItem.TabStop = false;
            this.txtTotalItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(956, 399);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 24);
            this.txtTotal.TabIndex = 90;
            this.txtTotal.TabStop = false;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBusca
            // 
            this.txtBusca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBusca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBusca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusca.Location = new System.Drawing.Point(8, 34);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(479, 23);
            this.txtBusca.TabIndex = 6;
            this.txtBusca.TextChanged += new System.EventHandler(this.txtBusca_TextChanged);
            // 
            // frmBaseTodasNegociacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1221, 435);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTotalAberto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTotalFechado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtTotalItem);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.lwNegociacoes);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBaseTodasNegociacoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Negociações";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmBaseTodasNegociacoes_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripSair;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel1;
        private TextBoxPersonalizado txtBusca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLimparBusca;
        private TextBoxPersonalizado txtTotalItem;
        private TextBoxPersonalizado txtTotal;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ListView lwNegociacoes;
        private System.Windows.Forms.ColumnHeader columnCod;
        private System.Windows.Forms.ColumnHeader columnCnpjCpf;
        private System.Windows.Forms.ColumnHeader columnFantasia;
        private System.Windows.Forms.ColumnHeader columnParc;
        private System.Windows.Forms.ColumnHeader columnDV;
        private System.Windows.Forms.ColumnHeader columnVlor;
        private System.Windows.Forms.ColumnHeader columnRef;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem baixarContaReceberToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rbAberto;
        private System.Windows.Forms.RadioButton rbTodos;
        private System.Windows.Forms.RadioButton rbFechado;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ColumnHeader columnSituacao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private TextBoxPersonalizado txtTotalFechado;
        private System.Windows.Forms.Label label5;
        private TextBoxPersonalizado txtTotalAberto;
    }
}