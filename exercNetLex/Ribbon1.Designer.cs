namespace exercNetLex
{
	partial class Ribbon1 : Microsoft.Office.Tools.Ribbon.RibbonBase
	{
		/// <summary>
		/// Variável de designer necessária.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		public Ribbon1()
			: base(Globals.Factory.GetRibbonFactory())
		{
			InitializeComponent();
		}

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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ribbon1));
			this.tab1 = this.Factory.CreateRibbonTab();
			this.grpPDF = this.Factory.CreateRibbonGroup();
			this.grpImg = this.Factory.CreateRibbonGroup();
			this.grpTabela = this.Factory.CreateRibbonGroup();
			this.grpLetras = this.Factory.CreateRibbonGroup();
			this.grpFindAndReplace = this.Factory.CreateRibbonGroup();
			this.dlgImg = new System.Windows.Forms.OpenFileDialog();
			this.BtnSavePDF = this.Factory.CreateRibbonButton();
			this.BntAddImage = this.Factory.CreateRibbonButton();
			this.BntAddTabela = this.Factory.CreateRibbonButton();
			this.BntInvertCase = this.Factory.CreateRibbonButton();
			this.BntFindAndReplace = this.Factory.CreateRibbonButton();
			this.tab1.SuspendLayout();
			this.grpPDF.SuspendLayout();
			this.grpImg.SuspendLayout();
			this.grpTabela.SuspendLayout();
			this.grpLetras.SuspendLayout();
			this.grpFindAndReplace.SuspendLayout();
			this.SuspendLayout();
			// 
			// tab1
			// 
			this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
			this.tab1.Groups.Add(this.grpPDF);
			this.tab1.Groups.Add(this.grpImg);
			this.tab1.Groups.Add(this.grpTabela);
			this.tab1.Groups.Add(this.grpLetras);
			this.tab1.Groups.Add(this.grpFindAndReplace);
			this.tab1.Label = "ExercNetLex";
			this.tab1.Name = "tab1";
			// 
			// grpPDF
			// 
			this.grpPDF.Items.Add(this.BtnSavePDF);
			this.grpPDF.Label = "PDF";
			this.grpPDF.Name = "grpPDF";
			// 
			// grpImg
			// 
			this.grpImg.Items.Add(this.BntAddImage);
			this.grpImg.Label = "Imagens";
			this.grpImg.Name = "grpImg";
			// 
			// grpTabela
			// 
			this.grpTabela.Items.Add(this.BntAddTabela);
			this.grpTabela.Label = "Tabelas";
			this.grpTabela.Name = "grpTabela";
			// 
			// grpLetras
			// 
			this.grpLetras.Items.Add(this.BntInvertCase);
			this.grpLetras.Label = "Letras";
			this.grpLetras.Name = "grpLetras";
			// 
			// grpFindAndReplace
			// 
			this.grpFindAndReplace.Items.Add(this.BntFindAndReplace);
			this.grpFindAndReplace.Label = "Revisão";
			this.grpFindAndReplace.Name = "grpFindAndReplace";
			// 
			// dlgImg
			// 
			this.dlgImg.FileName = "dlgImg";
			// 
			// BtnSavePDF
			// 
			this.BtnSavePDF.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
			this.BtnSavePDF.Image = ((System.Drawing.Image)(resources.GetObject("BtnSavePDF.Image")));
			this.BtnSavePDF.Label = "Salvar em PDF";
			this.BtnSavePDF.Name = "BtnSavePDF";
			this.BtnSavePDF.ShowImage = true;
			this.BtnSavePDF.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.BtnSavePDF_Click);
			// 
			// BntAddImage
			// 
			this.BntAddImage.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
			this.BntAddImage.Image = ((System.Drawing.Image)(resources.GetObject("BntAddImage.Image")));
			this.BntAddImage.Label = "Add Image";
			this.BntAddImage.Name = "BntAddImage";
			this.BntAddImage.ShowImage = true;
			this.BntAddImage.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.BntAddImage_Click);
			// 
			// BntAddTabela
			// 
			this.BntAddTabela.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
			this.BntAddTabela.Image = ((System.Drawing.Image)(resources.GetObject("BntAddTabela.Image")));
			this.BntAddTabela.Label = "Add Table";
			this.BntAddTabela.Name = "BntAddTabela";
			this.BntAddTabela.ShowImage = true;
			this.BntAddTabela.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.BntAddTabela_Click);
			// 
			// BntInvertCase
			// 
			this.BntInvertCase.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
			this.BntInvertCase.Enabled = false;
			this.BntInvertCase.Image = ((System.Drawing.Image)(resources.GetObject("BntInvertCase.Image")));
			this.BntInvertCase.Label = "Invert Case";
			this.BntInvertCase.Name = "BntInvertCase";
			this.BntInvertCase.ShowImage = true;
			this.BntInvertCase.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.BntInvertCase_Click);
			// 
			// BntFindAndReplace
			// 
			this.BntFindAndReplace.Image = ((System.Drawing.Image)(resources.GetObject("BntFindAndReplace.Image")));
			this.BntFindAndReplace.Label = "Find and Replace";
			this.BntFindAndReplace.Name = "BntFindAndReplace";
			this.BntFindAndReplace.ShowImage = true;
			this.BntFindAndReplace.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.BntFindAndReplace_Click);
			// 
			// Ribbon1
			// 
			this.Name = "Ribbon1";
			this.RibbonType = "Microsoft.Word.Document";
			this.Tabs.Add(this.tab1);
			this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon1_Load);
			this.tab1.ResumeLayout(false);
			this.tab1.PerformLayout();
			this.grpPDF.ResumeLayout(false);
			this.grpPDF.PerformLayout();
			this.grpImg.ResumeLayout(false);
			this.grpImg.PerformLayout();
			this.grpTabela.ResumeLayout(false);
			this.grpTabela.PerformLayout();
			this.grpLetras.ResumeLayout(false);
			this.grpLetras.PerformLayout();
			this.grpFindAndReplace.ResumeLayout(false);
			this.grpFindAndReplace.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
		internal Microsoft.Office.Tools.Ribbon.RibbonGroup grpPDF;
		internal Microsoft.Office.Tools.Ribbon.RibbonButton BtnSavePDF;
		internal Microsoft.Office.Tools.Ribbon.RibbonGroup grpImg;
		internal Microsoft.Office.Tools.Ribbon.RibbonButton BntAddImage;
		private System.Windows.Forms.OpenFileDialog dlgImg;
		internal Microsoft.Office.Tools.Ribbon.RibbonGroup grpTabela;
		internal Microsoft.Office.Tools.Ribbon.RibbonButton BntAddTabela;
		internal Microsoft.Office.Tools.Ribbon.RibbonGroup grpLetras;
		internal Microsoft.Office.Tools.Ribbon.RibbonButton BntInvertCase;
		internal Microsoft.Office.Tools.Ribbon.RibbonGroup grpFindAndReplace;
		internal Microsoft.Office.Tools.Ribbon.RibbonButton BntFindAndReplace;
	}

	partial class ThisRibbonCollection
	{
		internal Ribbon1 Ribbon1
		{
			get { return this.GetRibbon<Ribbon1>(); }
		}
	}
}
