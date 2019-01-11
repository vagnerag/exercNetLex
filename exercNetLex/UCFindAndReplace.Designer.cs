namespace exercNetLex
{
	partial class UCFindAndReplace
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

		#region Código gerado pelo Designer de Componentes

		/// <summary> 
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.TxFind = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.BntFindNext = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// TxFind
			// 
			this.TxFind.Location = new System.Drawing.Point(20, 31);
			this.TxFind.Name = "TxFind";
			this.TxFind.Size = new System.Drawing.Size(193, 22);
			this.TxFind.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label1.Location = new System.Drawing.Point(17, 56);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(68, 17);
			this.label1.TabIndex = 1;
			this.label1.Text = "Find what";
			// 
			// BntFindNext
			// 
			this.BntFindNext.Location = new System.Drawing.Point(20, 88);
			this.BntFindNext.Name = "BntFindNext";
			this.BntFindNext.Size = new System.Drawing.Size(75, 23);
			this.BntFindNext.TabIndex = 2;
			this.BntFindNext.Text = "Find Next";
			this.BntFindNext.UseVisualStyleBackColor = true;
			this.BntFindNext.Click += new System.EventHandler(this.BntFindNext_Click);
			// 
			// UCFindAndReplace
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GrayText;
			this.Controls.Add(this.BntFindNext);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.TxFind);
			this.Name = "UCFindAndReplace";
			this.Size = new System.Drawing.Size(265, 444);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox TxFind;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button BntFindNext;
	}
}
