namespace LavaJato
{
    partial class frmBaseTodosUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBaseTodosUsuarios));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtono = new System.Windows.Forms.ToolStripButton();
            this.toolStripSair = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLimparBusca = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBusca = new LavaJato.TextBoxPersonalizado();
            this.listViewProdutos = new System.Windows.Forms.ListView();
            this.columnCod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtono,
            this.toolStripSair});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(722, 39);
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
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.listViewProdutos);
            this.panel1.Location = new System.Drawing.Point(12, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(698, 344);
            this.panel1.TabIndex = 30;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(13, 121);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(671, 24);
            this.panel2.TabIndex = 74;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(37, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 20);
            this.label7.TabIndex = 51;
            this.label7.Text = "Operadores";
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
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox2.Controls.Add(this.btnLimparBusca);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtBusca);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(671, 96);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo pesquisa";
            // 
            // btnLimparBusca
            // 
            this.btnLimparBusca.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnLimparBusca.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnLimparBusca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLimparBusca.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparBusca.Image = ((System.Drawing.Image)(resources.GetObject("btnLimparBusca.Image")));
            this.btnLimparBusca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimparBusca.Location = new System.Drawing.Point(512, 48);
            this.btnLimparBusca.Name = "btnLimparBusca";
            this.btnLimparBusca.Size = new System.Drawing.Size(88, 23);
            this.btnLimparBusca.TabIndex = 3;
            this.btnLimparBusca.Text = "Limpar";
            this.btnLimparBusca.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimparBusca.UseVisualStyleBackColor = false;
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
            this.txtBusca.Size = new System.Drawing.Size(490, 23);
            this.txtBusca.TabIndex = 6;
            // 
            // listViewProdutos
            // 
            this.listViewProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewProdutos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.listViewProdutos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnCod});
            this.listViewProdutos.Font = new System.Drawing.Font("Tahoma", 9F);
            this.listViewProdutos.FullRowSelect = true;
            this.listViewProdutos.GridLines = true;
            this.listViewProdutos.Location = new System.Drawing.Point(13, 145);
            this.listViewProdutos.Name = "listViewProdutos";
            this.listViewProdutos.Size = new System.Drawing.Size(671, 183);
            this.listViewProdutos.TabIndex = 3;
            this.listViewProdutos.UseCompatibleStateImageBehavior = false;
            this.listViewProdutos.View = System.Windows.Forms.View.Details;
            // 
            // frmBaseTodosUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 411);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmBaseTodosUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Operadores do sistema";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtono;
        private System.Windows.Forms.ToolStripButton toolStripSair;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLimparBusca;
        private System.Windows.Forms.Label label1;
        private TextBoxPersonalizado txtBusca;
        private System.Windows.Forms.ListView listViewProdutos;
        private System.Windows.Forms.ColumnHeader columnCod;
    }
}