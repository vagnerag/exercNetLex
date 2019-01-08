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
			this.btnSavePDF = this.Factory.CreateRibbonButton();
			this.grpImg = this.Factory.CreateRibbonGroup();
			this.bntAddImage = this.Factory.CreateRibbonButton();
			this.grpTabela = this.Factory.CreateRibbonGroup();
			this.bntAddTabela = this.Factory.CreateRibbonButton();
			this.dlgImg = new System.Windows.Forms.OpenFileDialog();
			this.tab1.SuspendLayout();
			this.grpPDF.SuspendLayout();
			this.grpImg.SuspendLayout();
			this.grpTabela.SuspendLayout();
			this.SuspendLayout();
			// 
			// tab1
			// 
			this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
			this.tab1.Groups.Add(this.grpPDF);
			this.tab1.Groups.Add(this.grpImg);
			this.tab1.Groups.Add(this.grpTabela);
			this.tab1.Label = "ExercNetLex";
			this.tab1.Name = "tab1";
			// 
			// grpPDF
			// 
			this.grpPDF.Items.Add(this.btnSavePDF);
			this.grpPDF.Label = "PDF";
			this.grpPDF.Name = "grpPDF";
			// 
			// btnSavePDF
			// 
			this.btnSavePDF.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
			this.btnSavePDF.Image = ((System.Drawing.Image)(resources.GetObject("btnSavePDF.Image")));
			this.btnSavePDF.Label = "Salvar em PDF";
			this.btnSavePDF.Name = "btnSavePDF";
			this.btnSavePDF.ShowImage = true;
			this.btnSavePDF.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.BtnSavePDF_Click);
			// 
			// grpImg
			// 
			this.grpImg.Items.Add(this.bntAddImage);
			this.grpImg.Label = "Imagens";
			this.grpImg.Name = "grpImg";
			// 
			// bntAddImage
			// 
			this.bntAddImage.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
			this.bntAddImage.Image = ((System.Drawing.Image)(resources.GetObject("bntAddImage.Image")));
			this.bntAddImage.Label = "Add Image";
			this.bntAddImage.Name = "bntAddImage";
			this.bntAddImage.ShowImage = true;
			this.bntAddImage.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.BntAddImage_Click);
			// 
			// grpTabela
			// 
			this.grpTabela.Items.Add(this.bntAddTabela);
			this.grpTabela.Label = "Tabelas";
			this.grpTabela.Name = "grpTabela";
			// 
			// bntAddTabela
			// 
			this.bntAddTabela.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
			this.bntAddTabela.Image = ((System.Drawing.Image)(resources.GetObject("bntAddTabela.Image")));
			this.bntAddTabela.Label = "Add Table";
			this.bntAddTabela.Name = "bntAddTabela";
			this.bntAddTabela.ShowImage = true;
			this.bntAddTabela.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.BntAddTabela_Click);
			// 
			// dlgImg
			// 
			this.dlgImg.FileName = "dlgImg";
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
			this.ResumeLayout(false);

		}

		#endregion

		internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
		internal Microsoft.Office.Tools.Ribbon.RibbonGroup grpPDF;
		internal Microsoft.Office.Tools.Ribbon.RibbonButton btnSavePDF;
		internal Microsoft.Office.Tools.Ribbon.RibbonGroup grpImg;
		internal Microsoft.Office.Tools.Ribbon.RibbonButton bntAddImage;
		private System.Windows.Forms.OpenFileDialog dlgImg;
		internal Microsoft.Office.Tools.Ribbon.RibbonGroup grpTabela;
		internal Microsoft.Office.Tools.Ribbon.RibbonButton bntAddTabela;
	}

	partial class ThisRibbonCollection
	{
		internal Ribbon1 Ribbon1
		{
			get { return this.GetRibbon<Ribbon1>(); }
		}
	}
}
