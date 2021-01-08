namespace LavaJato
{
    partial class frmPesquisarFornecedores
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddNovo = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbSobreNomeRazao = new System.Windows.Forms.RadioButton();
            this.rbNomeFantasia = new System.Windows.Forms.RadioButton();
            this.rbCpfCnpj = new System.Windows.Forms.RadioButton();
            this.ListaFornecedores = new System.Windows.Forms.ListView();
            this.txtParametro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddNovo)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddNovo);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.ListaFornecedores);
            this.groupBox1.Controls.Add(this.txtParametro);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(875, 385);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnAddNovo
            // 
            this.btnAddNovo.BackgroundImage = global::LavaJato.Properties.Resources.Symbol_Add;
            this.btnAddNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddNovo.Location = new System.Drawing.Point(810, 18);
            this.btnAddNovo.Name = "btnAddNovo";
            this.btnAddNovo.Size = new System.Drawing.Size(56, 45);
            this.btnAddNovo.TabIndex = 67;
            this.btnAddNovo.TabStop = false;
            this.btnAddNovo.Click += new System.EventHandler(this.btnAddNovo_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbSobreNomeRazao);
            this.groupBox2.Controls.Add(this.rbNomeFantasia);
            this.groupBox2.Controls.Add(this.rbCpfCnpj);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(8, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(787, 54);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo pesquisa";
            // 
            // rbSobreNomeRazao
            // 
            this.rbSobreNomeRazao.AutoSize = true;
            this.rbSobreNomeRazao.Location = new System.Drawing.Point(503, 18);
            this.rbSobreNomeRazao.Name = "rbSobreNomeRazao";
            this.rbSobreNomeRazao.Size = new System.Drawing.Size(110, 19);
            this.rbSobreNomeRazao.TabIndex = 2;
            this.rbSobreNomeRazao.Text = "Razão Social";
            this.rbSobreNomeRazao.UseVisualStyleBackColor = true;
            this.rbSobreNomeRazao.CheckedChanged += new System.EventHandler(this.rbSobreNomeRazao_CheckedChanged);
            // 
            // rbNomeFantasia
            // 
            this.rbNomeFantasia.AutoSize = true;
            this.rbNomeFantasia.Checked = true;
            this.rbNomeFantasia.Location = new System.Drawing.Point(359, 18);
            this.rbNomeFantasia.Name = "rbNomeFantasia";
            this.rbNomeFantasia.Size = new System.Drawing.Size(122, 19);
            this.rbNomeFantasia.TabIndex = 1;
            this.rbNomeFantasia.TabStop = true;
            this.rbNomeFantasia.Text = "Nome Fantasia";
            this.rbNomeFantasia.UseVisualStyleBackColor = true;
            this.rbNomeFantasia.CheckedChanged += new System.EventHandler(this.rbNomeFantasia_CheckedChanged);
            // 
            // rbCpfCnpj
            // 
            this.rbCpfCnpj.AutoSize = true;
            this.rbCpfCnpj.Location = new System.Drawing.Point(215, 18);
            this.rbCpfCnpj.Name = "rbCpfCnpj";
            this.rbCpfCnpj.Size = new System.Drawing.Size(60, 19);
            this.rbCpfCnpj.TabIndex = 0;
            this.rbCpfCnpj.Text = "CNPJ";
            this.rbCpfCnpj.UseVisualStyleBackColor = true;
            this.rbCpfCnpj.CheckedChanged += new System.EventHandler(this.rbCpfCnpj_CheckedChanged);
            // 
            // ListaFornecedores
            // 
            this.ListaFornecedores.AllowColumnReorder = true;
            this.ListaFornecedores.BackColor = System.Drawing.Color.White;
            this.ListaFornecedores.BackgroundImageTiled = true;
            this.ListaFornecedores.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaFornecedores.FullRowSelect = true;
            this.ListaFornecedores.GridLines = true;
            this.ListaFornecedores.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ListaFornecedores.Location = new System.Drawing.Point(9, 109);
            this.ListaFornecedores.Name = "ListaFornecedores";
            this.ListaFornecedores.ShowItemToolTips = true;
            this.ListaFornecedores.Size = new System.Drawing.Size(857, 268);
            this.ListaFornecedores.TabIndex = 38;
            this.ListaFornecedores.UseCompatibleStateImageBehavior = false;
            this.ListaFornecedores.View = System.Windows.Forms.View.Details;
            this.ListaFornecedores.SelectedIndexChanged += new System.EventHandler(this.ListaFornecedores_SelectedIndexChanged);
            // 
            // txtParametro
            // 
            this.txtParametro.BackColor = System.Drawing.Color.Silver;
            this.txtParametro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParametro.Location = new System.Drawing.Point(9, 82);
            this.txtParametro.Name = "txtParametro";
            this.txtParametro.Size = new System.Drawing.Size(857, 24);
            this.txtParametro.TabIndex = 1;
            this.txtParametro.TextChanged += new System.EventHandler(this.txtParametro_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite aqui:";
            // 
            // frmPesquisarFornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(896, 404);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPesquisarFornecedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Fornecedor";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPesquisarFornecedores_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddNovo)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView ListaFornecedores;
        private System.Windows.Forms.TextBox txtParametro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbSobreNomeRazao;
        private System.Windows.Forms.RadioButton rbNomeFantasia;
        private System.Windows.Forms.RadioButton rbCpfCnpj;
        private System.Windows.Forms.PictureBox btnAddNovo;
    }
}