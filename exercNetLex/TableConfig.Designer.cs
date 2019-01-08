namespace exercNetLex
{
	partial class frmTableConfig
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
			this.bntAddTableOK = new System.Windows.Forms.Button();
			this.numLinhas = new System.Windows.Forms.Label();
			this.numColunas = new System.Windows.Forms.Label();
			this.nudNumColunas = new System.Windows.Forms.NumericUpDown();
			this.nudNumLinhas = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.nudNumColunas)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudNumLinhas)).BeginInit();
			this.SuspendLayout();
			// 
			// bntAddTableOK
			// 
			this.bntAddTableOK.Location = new System.Drawing.Point(83, 92);
			this.bntAddTableOK.Name = "bntAddTableOK";
			this.bntAddTableOK.Size = new System.Drawing.Size(75, 23);
			this.bntAddTableOK.TabIndex = 0;
			this.bntAddTableOK.Text = "OK";
			this.bntAddTableOK.UseVisualStyleBackColor = true;
			this.bntAddTableOK.Click += new System.EventHandler(this.bntAddTableOK_Click);
			// 
			// numLinhas
			// 
			this.numLinhas.AutoSize = true;
			this.numLinhas.Location = new System.Drawing.Point(9, 56);
			this.numLinhas.Name = "numLinhas";
			this.numLinhas.Size = new System.Drawing.Size(96, 13);
			this.numLinhas.TabIndex = 1;
			this.numLinhas.Text = "Número de Linhas:";
			// 
			// numColunas
			// 
			this.numColunas.AutoSize = true;
			this.numColunas.Location = new System.Drawing.Point(9, 24);
			this.numColunas.Name = "numColunas";
			this.numColunas.Size = new System.Drawing.Size(103, 13);
			this.numColunas.TabIndex = 2;
			this.numColunas.Text = "Número de Colunas:";
			// 
			// nudNumColunas
			// 
			this.nudNumColunas.Location = new System.Drawing.Point(118, 17);
			this.nudNumColunas.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.nudNumColunas.Name = "nudNumColunas";
			this.nudNumColunas.Size = new System.Drawing.Size(40, 20);
			this.nudNumColunas.TabIndex = 5;
			this.nudNumColunas.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
			// 
			// nudNumLinhas
			// 
			this.nudNumLinhas.Location = new System.Drawing.Point(118, 49);
			this.nudNumLinhas.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.nudNumLinhas.Name = "nudNumLinhas";
			this.nudNumLinhas.Size = new System.Drawing.Size(40, 20);
			this.nudNumLinhas.TabIndex = 6;
			this.nudNumLinhas.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
			// 
			// frmTableConfig
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(232, 127);
			this.Controls.Add(this.nudNumLinhas);
			this.Controls.Add(this.nudNumColunas);
			this.Controls.Add(this.numColunas);
			this.Controls.Add(this.numLinhas);
			this.Controls.Add(this.bntAddTableOK);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmTableConfig";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Inserir Tabela";
			((System.ComponentModel.ISupportInitialize)(this.nudNumColunas)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudNumLinhas)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button bntAddTableOK;
		private System.Windows.Forms.Label numLinhas;
		private System.Windows.Forms.Label numColunas;
		public System.Windows.Forms.NumericUpDown nudNumColunas;
		public System.Windows.Forms.NumericUpDown nudNumLinhas;
	}
}