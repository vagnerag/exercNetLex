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
			HabilitarBntInvertCase();
		}

		private void BtnSavePDF_Click(object sender, RibbonControlEventArgs e)
		{
			//Extrai as informções do documento ativo
			Word.Document doc = Globals.ThisAddIn.Application.ActiveDocument;
			string nomeDocument = doc.Name;
			string enderecoDoc = doc.Path;

			//Cria uma string para armazenar o endereço onde o arquivo PDF será salvo e chama a função para converter
			string enderecoPDF = enderecoDoc + "\\" + nomeDocument + ".pdf";
			doc.ExportAsFixedFormat(enderecoPDF, Word.WdExportFormat.wdExportFormatPDF, OpenAfterExport: true);
		}

		private void BntAddImage_Click(object sender, RibbonControlEventArgs e)
		{
			//Configuração do openDialog
			dlgImg.InitialDirectory = @"C:\Users\Netlex\Desktop\exercNetLex\";
			dlgImg.Title = "Escolha a Imagem";
			dlgImg.Filter = "Image Files (*.bmp;*.png;*.jpg)|*.bmp;*.png;*.jpg";

			//Mostra o openDialog e seta a stringo com o nome da imagem
			dlgImg.ShowDialog();
			string nomeImg = dlgImg.FileName;

			//Add a imagem no documento
			Globals.ThisAddIn.Application.Selection.InlineShapes.AddPicture(nomeImg);
		}

		private void BntAddTabela_Click(object sender, RibbonControlEventArgs e)
		{
			//Mostra a tela de configuração da tabela
			FrmTableConfig ftc = new FrmTableConfig();
			ftc.Show();
		}

		private void HabilitarBntInvertCase()
		{
			Word.Selection sl = Globals.ThisAddIn.Application.Selection;
			Word.Range rg = sl.Range;
			//rg.InsertAfter(""+rg.End);
			//rg.InsertBefore(""+rg.Start);
			//if (rg.Start <= rg.End)
			//{
				this.BntInvertCase.Enabled = true;
			//}
			//else this.BntInvertCase.Enabled = false;
		}

		private void BntInvertCase_Click(object sender, RibbonControlEventArgs e)
		{


		}
	}
}
