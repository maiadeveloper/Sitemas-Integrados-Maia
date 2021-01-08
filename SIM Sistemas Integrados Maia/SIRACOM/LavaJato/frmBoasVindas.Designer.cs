namespace LavaJato
{
    partial class frmBoasVindas
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
            this.lblMensagemBoasVindas = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMensagemBoasVindas
            // 
            this.lblMensagemBoasVindas.AutoSize = true;
            this.lblMensagemBoasVindas.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagemBoasVindas.Location = new System.Drawing.Point(100, 9);
            this.lblMensagemBoasVindas.Name = "lblMensagemBoasVindas";
            this.lblMensagemBoasVindas.Size = new System.Drawing.Size(123, 42);
            this.lblMensagemBoasVindas.TabIndex = 0;
            this.lblMensagemBoasVindas.Text = "Bom dia";
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Seja Bem Vindo(a) ao Sistema ";
            // 
            // frmBoasVindas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(360, 108);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMensagemBoasVindas);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBoasVindas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seja bem vindo ao Sistema";
            this.Load += new System.EventHandler(this.frmBoasVindas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMensagemBoasVindas;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
    }
}