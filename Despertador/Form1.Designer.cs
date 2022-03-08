namespace Despertador
{
	partial class Form1
	{
		/// <summary>
		/// Variável de designer necessária.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpar os recursos que estão sendo usados.
		/// </summary>
		/// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código gerado pelo Windows Form Designer

		/// <summary>
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.lblHoraAtual = new System.Windows.Forms.Label();
            this.tmrAtual = new System.Windows.Forms.Timer(this.components);
            this.mskDespertar = new System.Windows.Forms.MaskedTextBox();
            this.chkAtivar = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblHoraAtual
            // 
            this.lblHoraAtual.AutoSize = true;
            this.lblHoraAtual.Font = new System.Drawing.Font("DS-Digital", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraAtual.ForeColor = System.Drawing.Color.Yellow;
            this.lblHoraAtual.Location = new System.Drawing.Point(62, 31);
            this.lblHoraAtual.Name = "lblHoraAtual";
            this.lblHoraAtual.Size = new System.Drawing.Size(253, 63);
            this.lblHoraAtual.TabIndex = 0;
            this.lblHoraAtual.Text = "00:00:00";
            // 
            // tmrAtual
            // 
            this.tmrAtual.Enabled = true;
            this.tmrAtual.Interval = 1000;
            this.tmrAtual.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // mskDespertar
            // 
            this.mskDespertar.BackColor = System.Drawing.SystemColors.MenuText;
            this.mskDespertar.Font = new System.Drawing.Font("DS-Digital", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskDespertar.ForeColor = System.Drawing.Color.Yellow;
            this.mskDespertar.Location = new System.Drawing.Point(97, 140);
            this.mskDespertar.Mask = "00:00:00";
            this.mskDespertar.Name = "mskDespertar";
            this.mskDespertar.Size = new System.Drawing.Size(171, 39);
            this.mskDespertar.TabIndex = 1;
            this.mskDespertar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mskDespertar.ValidatingType = typeof(System.DateTime);
            this.mskDespertar.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskDespertar_MaskInputRejected);
            // 
            // chkAtivar
            // 
            this.chkAtivar.AutoSize = true;
            this.chkAtivar.Font = new System.Drawing.Font("DS-Digital", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAtivar.ForeColor = System.Drawing.Color.Yellow;
            this.chkAtivar.Location = new System.Drawing.Point(165, 185);
            this.chkAtivar.Name = "chkAtivar";
            this.chkAtivar.Size = new System.Drawing.Size(103, 31);
            this.chkAtivar.TabIndex = 2;
            this.chkAtivar.Text = "Ativar";
            this.chkAtivar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(392, 283);
            this.Controls.Add(this.chkAtivar);
            this.Controls.Add(this.mskDespertar);
            this.Controls.Add(this.lblHoraAtual);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblHoraAtual;
        private System.Windows.Forms.Timer tmrAtual;
        private System.Windows.Forms.MaskedTextBox mskDespertar;
        private System.Windows.Forms.CheckBox chkAtivar;
    }
}

