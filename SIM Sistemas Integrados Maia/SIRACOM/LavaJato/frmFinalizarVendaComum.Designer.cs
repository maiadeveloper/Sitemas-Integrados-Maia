namespace LavaJato
{
    partial class frmFinalizarVendaComum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFinalizarVendaComum));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTotalVenda = new LavaJato.TextBoxPersonalizado();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txttotalPago = new LavaJato.TextBoxPersonalizado();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPagando = new LavaJato.TextBoxPersonalizado();
            this.txtDesconto = new LavaJato.TextBoxPersonalizado();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTroco = new LavaJato.TextBoxPersonalizado();
            this.listFormaRecebimento = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.listBoxFormaPagamento = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Location = new System.Drawing.Point(8, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(987, 486);
            this.panel1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtTotalVenda);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(371, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(601, 93);
            this.groupBox3.TabIndex = 96;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Venda";
            // 
            // txtTotalVenda
            // 
            this.txtTotalVenda.BackColor = System.Drawing.Color.Black;
            this.txtTotalVenda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalVenda.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalVenda.ForeColor = System.Drawing.Color.White;
            this.txtTotalVenda.Location = new System.Drawing.Point(305, 26);
            this.txtTotalVenda.Name = "txtTotalVenda";
            this.txtTotalVenda.ReadOnly = true;
            this.txtTotalVenda.Size = new System.Drawing.Size(280, 57);
            this.txtTotalVenda.TabIndex = 27;
            this.txtTotalVenda.TabStop = false;
            this.txtTotalVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(130, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(177, 37);
            this.label9.TabIndex = 26;
            this.label9.Text = "Valor Venda:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txttotalPago);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPagando);
            this.groupBox1.Controls.Add(this.txtDesconto);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtTroco);
            this.groupBox1.Controls.Add(this.listFormaRecebimento);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(371, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(601, 369);
            this.groupBox1.TabIndex = 84;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pagamentos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(305, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 37);
            this.label1.TabIndex = 105;
            this.label1.Text = "Total Pago:";
            // 
            // txttotalPago
            // 
            this.txttotalPago.BackColor = System.Drawing.Color.Black;
            this.txttotalPago.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttotalPago.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotalPago.ForeColor = System.Drawing.Color.White;
            this.txttotalPago.Location = new System.Drawing.Point(305, 165);
            this.txttotalPago.Name = "txttotalPago";
            this.txttotalPago.ReadOnly = true;
            this.txttotalPago.Size = new System.Drawing.Size(280, 57);
            this.txttotalPago.TabIndex = 28;
            this.txttotalPago.TabStop = false;
            this.txttotalPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 37);
            this.label8.TabIndex = 89;
            this.label8.Text = "Pagando:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(298, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 37);
            this.label2.TabIndex = 104;
            this.label2.Text = "Desconto:";
            // 
            // txtPagando
            // 
            this.txtPagando.BackColor = System.Drawing.Color.Black;
            this.txtPagando.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPagando.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPagando.ForeColor = System.Drawing.Color.White;
            this.txtPagando.Location = new System.Drawing.Point(19, 68);
            this.txtPagando.Name = "txtPagando";
            this.txtPagando.Size = new System.Drawing.Size(280, 57);
            this.txtPagando.TabIndex = 90;
            this.txtPagando.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPagando.Enter += new System.EventHandler(this.txtPagando_Enter_1);
            // 
            // txtDesconto
            // 
            this.txtDesconto.BackColor = System.Drawing.Color.Black;
            this.txtDesconto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDesconto.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesconto.ForeColor = System.Drawing.Color.White;
            this.txtDesconto.Location = new System.Drawing.Point(305, 68);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.ReadOnly = true;
            this.txtDesconto.Size = new System.Drawing.Size(280, 57);
            this.txtDesconto.TabIndex = 103;
            this.txtDesconto.TabStop = false;
            this.txtDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDesconto.Enter += new System.EventHandler(this.txtDesconto_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 37);
            this.label7.TabIndex = 102;
            this.label7.Text = "Troco:";
            // 
            // txtTroco
            // 
            this.txtTroco.BackColor = System.Drawing.Color.Black;
            this.txtTroco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTroco.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTroco.ForeColor = System.Drawing.Color.White;
            this.txtTroco.Location = new System.Drawing.Point(19, 165);
            this.txtTroco.Name = "txtTroco";
            this.txtTroco.ReadOnly = true;
            this.txtTroco.Size = new System.Drawing.Size(280, 57);
            this.txtTroco.TabIndex = 101;
            this.txtTroco.TabStop = false;
            this.txtTroco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // listFormaRecebimento
            // 
            this.listFormaRecebimento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listFormaRecebimento.BackColor = System.Drawing.Color.White;
            this.listFormaRecebimento.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader7,
            this.columnHeader8});
            this.listFormaRecebimento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listFormaRecebimento.ForeColor = System.Drawing.Color.Black;
            this.listFormaRecebimento.FullRowSelect = true;
            this.listFormaRecebimento.Location = new System.Drawing.Point(19, 239);
            this.listFormaRecebimento.Name = "listFormaRecebimento";
            this.listFormaRecebimento.Size = new System.Drawing.Size(566, 114);
            this.listFormaRecebimento.TabIndex = 38;
            this.listFormaRecebimento.TabStop = false;
            this.listFormaRecebimento.UseCompatibleStateImageBehavior = false;
            this.listFormaRecebimento.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Item";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Forma Recebimento";
            this.columnHeader7.Width = 315;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Valor";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader8.Width = 180;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.listBoxFormaPagamento);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(15, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(339, 465);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Formas de Pagamento";
            // 
            // listBoxFormaPagamento
            // 
            this.listBoxFormaPagamento.BackColor = System.Drawing.Color.White;
            this.listBoxFormaPagamento.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxFormaPagamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.listBoxFormaPagamento.FormattingEnabled = true;
            this.listBoxFormaPagamento.ItemHeight = 37;
            this.listBoxFormaPagamento.Items.AddRange(new object[] {
            "01 - Dinheiro",
            "02 - Cartão de Débito",
            "03 - Cartão Crédito 1x"});
            this.listBoxFormaPagamento.Location = new System.Drawing.Point(17, 34);
            this.listBoxFormaPagamento.Name = "listBoxFormaPagamento";
            this.listBoxFormaPagamento.Size = new System.Drawing.Size(303, 411);
            this.listBoxFormaPagamento.TabIndex = 81;
            this.listBoxFormaPagamento.SelectedIndexChanged += new System.EventHandler(this.listBoxFormaPagamento_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(732, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 37);
            this.label3.TabIndex = 32;
            this.label3.Text = "Desconto:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.toolStripLabel2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1006, 39);
            this.toolStrip1.TabIndex = 33;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton1.Text = "Salvar";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
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
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(89, 36);
            this.toolStripLabel1.Text = "F2 - Desconto";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(93, 36);
            this.toolStripLabel2.Text = "ESC - Cancelar";
            // 
            // frmFinalizarVendaComum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1006, 541);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFinalizarVendaComum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Finalizar Venda Comum";
            this.Load += new System.EventHandler(this.frmFinalizarVendaComum_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmFinalizarVendaComum_KeyDown);
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox listBoxFormaPagamento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private TextBoxPersonalizado txtPagando;
        private TextBoxPersonalizado txtTotalVenda;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListView listFormaRecebimento;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Label label2;
        private TextBoxPersonalizado txtDesconto;
        private System.Windows.Forms.Label label7;
        private TextBoxPersonalizado txtTroco;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private TextBoxPersonalizado txttotalPago;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
    }
}