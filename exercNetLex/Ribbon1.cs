using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using Word = Microsoft.Office.Interop.Word;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Word;

namespace exercNetLex
{
	public partial class Ribbon1
	{
		private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
		{

		}

		private void btnSavePDF_Click(object sender, RibbonControlEventArgs e)
		{
			Word.Document doc = Globals.ThisAddIn.Application.ActiveDocument;
			string nomeDocument = doc.Name;
			string enderecoDoc = doc.Path;
			string enderecoPDF = enderecoDoc + "\\" + nomeDocument+ ".pdf";
			doc.ExportAsFixedFormat(enderecoPDF, Word.WdExportFormat.wdExportFormatPDF, OpenAfterExport: true);
		}

		private void bntAddImage_Click(object sender, RibbonControlEventArgs e)
		{
			dlgImg.InitialDirectory = @"C:\Users\Netlex\Desktop\exercNetLex\";
			dlgImg.Title = "Escolha a Imagem";
			dlgImg.Filter = "Image Files (*.bmp;*.png;*.jpg)|*.bmp;*.png;*.jpg";
			dlgImg.ShowDialog();
			string enderecoImg = dlgImg.FileName;
			Globals.ThisAddIn.Application.Selection.InlineShapes.AddPicture(enderecoImg);
		}
	}
}
