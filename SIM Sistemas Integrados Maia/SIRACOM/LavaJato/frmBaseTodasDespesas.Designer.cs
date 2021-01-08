namespace LavaJato
{
    partial class frmBaseTodasDespesas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBaseTodasDespesas));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQtde = new LavaJato.TextBoxPersonalizado();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotal = new LavaJato.TextBoxPersonalizado();
            this.listViewDespesas = new System.Windows.Forms.ListView();
            this.columnHeaderid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderdata = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderdescricao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeadertipoDespesa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderclasseDespesa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeadervalor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtono = new System.Windows.Forms.ToolStripButton();
            this.toolStripSair = new System.Windows.Forms.ToolStripButton();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnLimparBusca = new System.Windows.Forms.Button();
            this.btnConsultar = new LavaJato.btnPesonalizado();
            this.txtDataFinal = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDateInicial = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.listViewDespesas);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 143);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1052, 250);
            this.panel1.TabIndex = 69;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.txtQtde);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.txtTotal);
            this.panel4.Location = new System.Drawing.Point(13, 198);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1025, 40);
            this.panel4.TabIndex = 76;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 14);
            this.label4.TabIndex = 4;
            this.label4.Text = "Qtde:";
            // 
            // txtQtde
            // 
            this.txtQtde.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQtde.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtde.Location = new System.Drawing.Point(58, 8);
            this.txtQtde.Name = "txtQtde";
            this.txtQtde.ReadOnly = true;
            this.txtQtde.Size = new System.Drawing.Size(45, 23);
            this.txtQtde.TabIndex = 3;
            this.txtQtde.TabStop = false;
            this.txtQtde.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(770, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 14);
            this.label5.TabIndex = 2;
            this.label5.Text = "Vlr Total Despesa(s):";
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(920, 8);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 23);
            this.txtTotal.TabIndex = 2;
            this.txtTotal.TabStop = false;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // listViewDespesas
            // 
            this.listViewDespesas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewDespesas.BackColor = System.Drawing.Color.WhiteSmoke;
            this.listViewDespesas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderid,
            this.columnHeaderdata,
            this.columnHeaderdescricao,
            this.columnHeadertipoDespesa,
            this.columnHeaderclasseDespesa,
            this.columnHeadervalor});
            this.listViewDespesas.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewDespesas.FullRowSelect = true;
            this.listViewDespesas.GridLines = true;
            this.listViewDespesas.Location = new System.Drawing.Point(11, 36);
            this.listViewDespesas.Name = "listViewDespesas";
            this.listViewDespesas.Size = new System.Drawing.Size(1028, 153);
            this.listViewDespesas.TabIndex = 75;
            this.listViewDespesas.UseCompatibleStateImageBehavior = false;
            this.listViewDespesas.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderid
            // 
            this.columnHeaderid.Text = "ID";
            this.columnHeaderid.Width = 35;
            // 
            // columnHeaderdata
            // 
            this.columnHeaderdata.Text = "Data";
            this.columnHeaderdata.Width = 100;
            // 
            // columnHeaderdescricao
            // 
            this.columnHeaderdescricao.Text = "Descrição";
            this.columnHeaderdescricao.Width = 320;
            // 
            // columnHeadertipoDespesa
            // 
            this.columnHeadertipoDespesa.Text = "Tipo Despesa";
            this.columnHeadertipoDespesa.Width = 250;
            // 
            // columnHeaderclasseDespesa
            // 
            this.columnHeaderclasseDespesa.Text = "Classe Despesa";
            this.columnHeaderclasseDespesa.Width = 250;
            // 
            // columnHeadervalor
            // 
            this.columnHeadervalor.Text = "Valor";
            this.columnHeadervalor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeadervalor.Width = 120;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(11, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1028, 24);
            this.panel2.TabIndex = 54;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(37, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 20);
            this.label6.TabIndex = 51;
            this.label6.Text = "Despesas";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 22);
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtono,
            this.toolStripSair});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1076, 39);
            this.toolStrip1.TabIndex = 70;
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
            this.toolStripButtono.Text = "Nova Despesa";
            this.toolStripButtono.ToolTipText = "Novo";
            this.toolStripButtono.Click += new System.EventHandler(this.toolStripButtono_Click);
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
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel7.Controls.Add(this.label9);
            this.panel7.Controls.Add(this.pictureBox3);
            this.panel7.Location = new System.Drawing.Point(12, 49);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1052, 24);
            this.panel7.TabIndex = 76;
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
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.btnLimparBusca);
            this.panel6.Controls.Add(this.btnConsultar);
            this.panel6.Controls.Add(this.txtDataFinal);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.txtDateInicial);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel6.Location = new System.Drawing.Point(12, 73);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1052, 57);
            this.panel6.TabIndex = 75;
            // 
            // btnLimparBusca
            // 
            this.btnLimparBusca.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnLimparBusca.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnLimparBusca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLimparBusca.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparBusca.Image = ((System.Drawing.Image)(resources.GetObject("btnLimparBusca.Image")));
            this.btnLimparBusca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimparBusca.Location = new System.Drawing.Point(513, 20);
            this.btnLimparBusca.Name = "btnLimparBusca";
            this.btnLimparBusca.Size = new System.Drawing.Size(92, 23);
            this.btnLimparBusca.TabIndex = 46;
            this.btnLimparBusca.Text = "Limpar";
            this.btnLimparBusca.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimparBusca.UseVisualStyleBackColor = false;
            this.btnLimparBusca.Click += new System.EventHandler(this.btnLimparBusca_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultar.Image")));
            this.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultar.Location = new System.Drawing.Point(407, 21);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(100, 23);
            this.btnConsultar.TabIndex = 18;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // txtDataFinal
            // 
            this.txtDataFinal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataFinal.Location = new System.Drawing.Point(291, 20);
            this.txtDataFinal.Name = "txtDataFinal";
            this.txtDataFinal.Size = new System.Drawing.Size(103, 25);
            this.txtDataFinal.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(210, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 21);
            this.label7.TabIndex = 16;
            this.label7.Text = "Data Final:";
            // 
            // txtDateInicial
            // 
            this.txtDateInicial.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDateInicial.Location = new System.Drawing.Point(100, 20);
            this.txtDateInicial.Name = "txtDateInicial";
            this.txtDateInicial.Size = new System.Drawing.Size(105, 25);
            this.txtDateInicial.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(14, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 21);
            this.label8.TabIndex = 14;
            this.label8.Text = "Data Inicial:";
            // 
            // frmBaseTodasDespesas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1076, 401);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Name = "frmBaseTodasDespesas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Despesas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmBaseTodasDespesas_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmBaseTodasDespesas_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtono;
        private System.Windows.Forms.ToolStripButton toolStripSair;
        private System.Windows.Forms.ListView listViewDespesas;
        private System.Windows.Forms.ColumnHeader columnHeaderid;
        private System.Windows.Forms.ColumnHeader columnHeaderdata;
        private System.Windows.Forms.ColumnHeader columnHeaderdescricao;
        private System.Windows.Forms.ColumnHeader columnHeadertipoDespesa;
        private System.Windows.Forms.ColumnHeader columnHeaderclasseDespesa;
        private System.Windows.Forms.ColumnHeader columnHeadervalor;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnLimparBusca;
        private btnPesonalizado btnConsultar;
        private System.Windows.Forms.DateTimePicker txtDataFinal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker txtDateInicial;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private TextBoxPersonalizado txtQtde;
        private System.Windows.Forms.Label label5;
        private TextBoxPersonalizado txtTotal;
    }
}