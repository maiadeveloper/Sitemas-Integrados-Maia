namespace LavaJato
{
    partial class frmBaseTodosProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBaseTodosProdutos));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtono = new System.Windows.Forms.ToolStripButton();
            this.toolStripSair = new System.Windows.Forms.ToolStripButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEstoqueAtual = new LavaJato.TextBoxPersonalizado();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEstoqueMaximo = new LavaJato.TextBoxPersonalizado();
            this.txtEstoqueMinimo = new LavaJato.TextBoxPersonalizado();
            this.txtQtde = new LavaJato.TextBoxPersonalizado();
            this.txtTotalemProdutos = new LavaJato.TextBoxPersonalizado();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLimparBusca = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBusca = new LavaJato.TextBoxPersonalizado();
            this.listViewProdutos = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ExcluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
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
            this.toolStrip1.Size = new System.Drawing.Size(1053, 39);
            this.toolStrip1.TabIndex = 28;
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
            this.toolStripButtono.Click += new System.EventHandler(this.toolStripButtonOrcamento_Click);
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
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(12, 160);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1029, 24);
            this.panel2.TabIndex = 78;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(37, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 20);
            this.label7.TabIndex = 51;
            this.label7.Text = "Produtos";
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
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(834, 423);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Total Est.Atual";
            // 
            // txtEstoqueAtual
            // 
            this.txtEstoqueAtual.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEstoqueAtual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEstoqueAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstoqueAtual.Location = new System.Drawing.Point(837, 439);
            this.txtEstoqueAtual.Name = "txtEstoqueAtual";
            this.txtEstoqueAtual.ReadOnly = true;
            this.txtEstoqueAtual.Size = new System.Drawing.Size(100, 23);
            this.txtEstoqueAtual.TabIndex = 12;
            this.txtEstoqueAtual.TabStop = false;
            this.txtEstoqueAtual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(729, 423);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Total Est.Mín";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(940, 423);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Total Produtos";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(623, 423);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Total Est.Máx";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(11, 422);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Qtde Produtos";
            // 
            // txtEstoqueMaximo
            // 
            this.txtEstoqueMaximo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEstoqueMaximo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEstoqueMaximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstoqueMaximo.Location = new System.Drawing.Point(626, 439);
            this.txtEstoqueMaximo.Name = "txtEstoqueMaximo";
            this.txtEstoqueMaximo.ReadOnly = true;
            this.txtEstoqueMaximo.Size = new System.Drawing.Size(100, 23);
            this.txtEstoqueMaximo.TabIndex = 5;
            this.txtEstoqueMaximo.TabStop = false;
            this.txtEstoqueMaximo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEstoqueMinimo
            // 
            this.txtEstoqueMinimo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEstoqueMinimo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEstoqueMinimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstoqueMinimo.Location = new System.Drawing.Point(732, 439);
            this.txtEstoqueMinimo.Name = "txtEstoqueMinimo";
            this.txtEstoqueMinimo.ReadOnly = true;
            this.txtEstoqueMinimo.Size = new System.Drawing.Size(100, 23);
            this.txtEstoqueMinimo.TabIndex = 4;
            this.txtEstoqueMinimo.TabStop = false;
            this.txtEstoqueMinimo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtQtde
            // 
            this.txtQtde.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtQtde.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQtde.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtde.Location = new System.Drawing.Point(14, 439);
            this.txtQtde.Name = "txtQtde";
            this.txtQtde.ReadOnly = true;
            this.txtQtde.Size = new System.Drawing.Size(100, 23);
            this.txtQtde.TabIndex = 3;
            this.txtQtde.TabStop = false;
            this.txtQtde.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTotalemProdutos
            // 
            this.txtTotalemProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalemProdutos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalemProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalemProdutos.Location = new System.Drawing.Point(943, 439);
            this.txtTotalemProdutos.Name = "txtTotalemProdutos";
            this.txtTotalemProdutos.ReadOnly = true;
            this.txtTotalemProdutos.Size = new System.Drawing.Size(100, 23);
            this.txtTotalemProdutos.TabIndex = 2;
            this.txtTotalemProdutos.TabStop = false;
            this.txtTotalemProdutos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox2.Controls.Add(this.btnLimparBusca);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtBusca);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(12, 49);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1029, 96);
            this.groupBox2.TabIndex = 76;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Consultar";
            // 
            // btnLimparBusca
            // 
            this.btnLimparBusca.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnLimparBusca.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnLimparBusca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLimparBusca.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparBusca.ForeColor = System.Drawing.Color.Black;
            this.btnLimparBusca.Image = ((System.Drawing.Image)(resources.GetObject("btnLimparBusca.Image")));
            this.btnLimparBusca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimparBusca.Location = new System.Drawing.Point(886, 49);
            this.btnLimparBusca.Name = "btnLimparBusca";
            this.btnLimparBusca.Size = new System.Drawing.Size(88, 23);
            this.btnLimparBusca.TabIndex = 3;
            this.btnLimparBusca.Text = "Limpar";
            this.btnLimparBusca.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimparBusca.UseVisualStyleBackColor = false;
            this.btnLimparBusca.Click += new System.EventHandler(this.btnLimparBusca_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(9, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Digite aqui:";
            // 
            // txtBusca
            // 
            this.txtBusca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusca.Location = new System.Drawing.Point(12, 49);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(867, 23);
            this.txtBusca.TabIndex = 6;
            this.txtBusca.TextChanged += new System.EventHandler(this.txtBusca_TextChanged_1);
            // 
            // listViewProdutos
            // 
            this.listViewProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewProdutos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.listViewProdutos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16,
            this.columnHeader1,
            this.columnHeader17});
            this.listViewProdutos.ContextMenuStrip = this.contextMenuStrip2;
            this.listViewProdutos.Font = new System.Drawing.Font("Tahoma", 9F);
            this.listViewProdutos.FullRowSelect = true;
            this.listViewProdutos.GridLines = true;
            this.listViewProdutos.Location = new System.Drawing.Point(12, 184);
            this.listViewProdutos.Name = "listViewProdutos";
            this.listViewProdutos.Size = new System.Drawing.Size(1029, 229);
            this.listViewProdutos.TabIndex = 75;
            this.listViewProdutos.UseCompatibleStateImageBehavior = false;
            this.listViewProdutos.View = System.Windows.Forms.View.Details;
            this.listViewProdutos.DoubleClick += new System.EventHandler(this.listViewProdutos_DoubleClick_1);
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Código";
            this.columnHeader7.Width = 50;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "EAN-Codigo Barra";
            this.columnHeader8.Width = 120;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Nome Produto";
            this.columnHeader9.Width = 240;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Descrição Produto";
            this.columnHeader10.Width = 200;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Categoria Produto";
            this.columnHeader11.Width = 130;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Unidade Compra";
            this.columnHeader13.Width = 110;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Est Máx";
            this.columnHeader14.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader14.Width = 54;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Est Mín";
            this.columnHeader15.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader15.Width = 54;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Qtde Estoque";
            this.columnHeader16.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader16.Width = 90;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Vlr Compra";
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader1.Width = 90;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Vlr Revenda";
            this.columnHeader17.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader17.Width = 90;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExcluirToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip1";
            this.contextMenuStrip2.Size = new System.Drawing.Size(163, 34);
            this.contextMenuStrip2.Text = "Baixar conta";
            // 
            // ExcluirToolStripMenuItem
            // 
            this.ExcluirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ExcluirToolStripMenuItem.Image")));
            this.ExcluirToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ExcluirToolStripMenuItem.Name = "ExcluirToolStripMenuItem";
            this.ExcluirToolStripMenuItem.Size = new System.Drawing.Size(162, 30);
            this.ExcluirToolStripMenuItem.Text = "Excluir Produto";
            this.ExcluirToolStripMenuItem.Click += new System.EventHandler(this.ExcluirToolStripMenuItem_Click);
            // 
            // frmBaseTodosProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1053, 472);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtEstoqueAtual);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listViewProdutos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtQtde);
            this.Controls.Add(this.txtEstoqueMaximo);
            this.Controls.Add(this.txtTotalemProdutos);
            this.Controls.Add(this.txtEstoqueMinimo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBaseTodosProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produtos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmBaseTodosProdutos_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtono;
        private System.Windows.Forms.ToolStripButton toolStripSair;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private TextBoxPersonalizado txtEstoqueAtual;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private TextBoxPersonalizado txtEstoqueMaximo;
        private TextBoxPersonalizado txtEstoqueMinimo;
        private TextBoxPersonalizado txtQtde;
        private TextBoxPersonalizado txtTotalemProdutos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLimparBusca;
        private System.Windows.Forms.Label label1;
        private TextBoxPersonalizado txtBusca;
        private System.Windows.Forms.ListView listViewProdutos;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem ExcluirToolStripMenuItem;
    }
}