namespace exercNetLex
{
	partial class FindPanel
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
			this.TxFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TxFind.Location = new System.Drawing.Point(16, 29);
			this.TxFind.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
			this.TxFind.Name = "TxFind";
			this.TxFind.Size = new System.Drawing.Size(170, 24);
			this.TxFind.TabIndex = 0;
			this.TxFind.TextChanged += new System.EventHandler(this.TxFind_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label1.Location = new System.Drawing.Point(15, 54);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(60, 15);
			this.label1.TabIndex = 1;
			this.label1.Text = "Find what";
			// 
			// BntFindNext
			// 
			this.BntFindNext.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.BntFindNext.Enabled = false;
			this.BntFindNext.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.BntFindNext.Location = new System.Drawing.Point(16, 84);
			this.BntFindNext.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
			this.BntFindNext.Name = "BntFindNext";
			this.BntFindNext.Size = new System.Drawing.Size(92, 26);
			this.BntFindNext.TabIndex = 2;
			this.BntFindNext.Text = "Find Next";
			this.BntFindNext.UseVisualStyleBackColor = false;
			this.BntFindNext.EnabledChanged += new System.EventHandler(this.TxFind_TextChanged);
			this.BntFindNext.Click += new System.EventHandler(this.BntFindNext_Click);
			// 
			// FindPanel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.SystemColors.GrayText;
			this.Controls.Add(this.BntFindNext);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.TxFind);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
			this.Name = "FindPanel";
			this.Size = new System.Drawing.Size(232, 417);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button BntFindNext;
		public System.Windows.Forms.TextBox TxFind;
	}
}
