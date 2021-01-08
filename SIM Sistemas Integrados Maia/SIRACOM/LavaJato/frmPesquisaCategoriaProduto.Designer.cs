namespace LavaJato
{
    partial class frmPesquisaCategoriaProduto
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbDescricao = new System.Windows.Forms.RadioButton();
            this.rbCodigoCategoria = new System.Windows.Forms.RadioButton();
            this.ListaCategoria = new System.Windows.Forms.ListView();
            this.txtParametro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbDescricao);
            this.groupBox2.Controls.Add(this.rbCodigoCategoria);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(572, 54);
            this.groupBox2.TabIndex = 43;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo pesquisa";
            // 
            // rbDescricao
            // 
            this.rbDescricao.AutoSize = true;
            this.rbDescricao.Checked = true;
            this.rbDescricao.Location = new System.Drawing.Point(299, 20);
            this.rbDescricao.Name = "rbDescricao";
            this.rbDescricao.Size = new System.Drawing.Size(155, 19);
            this.rbDescricao.TabIndex = 2;
            this.rbDescricao.TabStop = true;
            this.rbDescricao.Text = "Descrição Categoria";
            this.rbDescricao.UseVisualStyleBackColor = true;
            this.rbDescricao.CheckedChanged += new System.EventHandler(this.rbDescricao_CheckedChanged);
            // 
            // rbCodigoCategoria
            // 
            this.rbCodigoCategoria.AutoSize = true;
            this.rbCodigoCategoria.Location = new System.Drawing.Point(126, 20);
            this.rbCodigoCategoria.Name = "rbCodigoCategoria";
            this.rbCodigoCategoria.Size = new System.Drawing.Size(136, 19);
            this.rbCodigoCategoria.TabIndex = 1;
            this.rbCodigoCategoria.Text = "Código Categoria";
            this.rbCodigoCategoria.UseVisualStyleBackColor = true;
            this.rbCodigoCategoria.CheckedChanged += new System.EventHandler(this.rbCodigoCategoria_CheckedChanged);
            // 
            // ListaCategoria
            // 
            this.ListaCategoria.AllowColumnReorder = true;
            this.ListaCategoria.BackColor = System.Drawing.Color.White;
            this.ListaCategoria.BackgroundImageTiled = true;
            this.ListaCategoria.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaCategoria.FullRowSelect = true;
            this.ListaCategoria.GridLines = true;
            this.ListaCategoria.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ListaCategoria.Location = new System.Drawing.Point(13, 114);
            this.ListaCategoria.Name = "ListaCategoria";
            this.ListaCategoria.ShowItemToolTips = true;
            this.ListaCategoria.Size = new System.Drawing.Size(572, 268);
            this.ListaCategoria.TabIndex = 42;
            this.ListaCategoria.UseCompatibleStateImageBehavior = false;
            this.ListaCategoria.View = System.Windows.Forms.View.Details;
            // 
            // txtParametro
            // 
            this.txtParametro.BackColor = System.Drawing.Color.Silver;
            this.txtParametro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParametro.Location = new System.Drawing.Point(13, 86);
            this.txtParametro.Name = "txtParametro";
            this.txtParametro.Size = new System.Drawing.Size(572, 24);
            this.txtParametro.TabIndex = 41;
            this.txtParametro.TextChanged += new System.EventHandler(this.txtParametro_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 40;
            this.label1.Text = "Digite aqui:";
            // 
            // frmPesquisaCategoriaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(594, 391);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ListaCategoria);
            this.Controls.Add(this.txtParametro);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPesquisaCategoriaProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisar Categoria Produto";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbDescricao;
        private System.Windows.Forms.RadioButton rbCodigoCategoria;
        private System.Windows.Forms.ListView ListaCategoria;
        private System.Windows.Forms.TextBox txtParametro;
        private System.Windows.Forms.Label label1;
    }
}