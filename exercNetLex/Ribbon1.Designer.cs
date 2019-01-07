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
			this.group1 = this.Factory.CreateRibbonGroup();
			this.btnSavePDF = this.Factory.CreateRibbonButton();
			this.tab1.SuspendLayout();
			this.group1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tab1
			// 
			this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
			this.tab1.Groups.Add(this.group1);
			this.tab1.Label = "ExercNetLex";
			this.tab1.Name = "tab1";
			// 
			// group1
			// 
			this.group1.Items.Add(this.btnSavePDF);
			this.group1.Label = "PDF";
			this.group1.Name = "group1";
			// 
			// btnSavePDF
			// 
			this.btnSavePDF.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
			this.btnSavePDF.Image = ((System.Drawing.Image)(resources.GetObject("btnSavePDF.Image")));
			this.btnSavePDF.Label = "Salvar em PDF";
			this.btnSavePDF.Name = "btnSavePDF";
			this.btnSavePDF.ShowImage = true;
			this.btnSavePDF.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnSavePDF_Click);
			// 
			// Ribbon1
			// 
			this.Name = "Ribbon1";
			this.RibbonType = "Microsoft.Word.Document";
			this.Tabs.Add(this.tab1);
			this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon1_Load);
			this.tab1.ResumeLayout(false);
			this.tab1.PerformLayout();
			this.group1.ResumeLayout(false);
			this.group1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
		internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
		internal Microsoft.Office.Tools.Ribbon.RibbonButton btnSavePDF;
	}

	partial class ThisRibbonCollection
	{
		internal Ribbon1 Ribbon1
		{
			get { return this.GetRibbon<Ribbon1>(); }
		}
	}
}
