using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Tools.Ribbon;
using Word = Microsoft.Office.Interop.Word;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Word;

namespace exercNetLex
{
	public class RibbonPresenter
	{
		private Word.Document Doc = Globals.ThisAddIn.Application.ActiveDocument;
		public Word.Selection Sel = Globals.ThisAddIn.Application.Selection;

		public void SavePDF()
		{
			//Extrai as informções do documento ativo
			string nomeDocument = Doc.Name;
			string enderecoDoc = Doc.Path;

			//Cria uma string para armazenar o endereço onde o arquivo PDF será salvo e chama a função para converter
			string enderecoPDF = enderecoDoc + "\\" + nomeDocument + ".pdf";
			if (!Doc.Saved)
			{
				Doc.Save();
			}
			Doc.ExportAsFixedFormat(enderecoPDF, Word.WdExportFormat.wdExportFormatPDF, OpenAfterExport: true);
		}

		public void AddImage(string nomeImg)
		{
			//Add a imagem no documento
			Globals.ThisAddIn.Application.Selection.InlineShapes.AddPicture(nomeImg);
		}

		public void CriarTabela(int numLinhas, int numColunas)
		{
			object start = 0, end = 0;

			Word.Range rng = Doc.Range(ref start, ref end);

			// Configura o local onde será inserido a tabela
			rng.Font.Name = "Calibri";
			rng.Font.Size = 11;
			rng.InsertParagraphAfter();
			rng.InsertParagraphAfter();
			rng.SetRange(rng.End, rng.End);

			// Add a tabela
			rng.Tables.Add(Doc.Paragraphs[rng.Start].Range, numLinhas, numColunas);
			rng.SetRange(numLinhas + 1, numLinhas + 1);

			// Formata e coloca borda na tabela 
			Word.Table tbl = Doc.Tables[1];
			tbl.Range.Font.Size = 11;
			tbl.Borders.InsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
			tbl.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
			tbl.Columns.DistributeWidth();
		}

		public void InvertCase()
		{
			string selecao = Sel.Text;
			string result = "";
			String inverso;

			foreach (char caracter in selecao)
			{
				if (caracter == caracter.ToString().ToLower()[0])
				{
					inverso = caracter.ToString().ToUpper();
				}
				else
				{
					inverso = caracter.ToString().ToLower();
				}
				result += inverso;

			}
			Sel.Delete();
			Sel.InsertAfter(result);
		}

		/*public bool HaSelecao()
		{
			if (Globals.ThisAddIn.Application.Documents.Count != 0)
			{
				var vstoDoc = Globals.Factory.GetVstoObject(Globals.ThisAddIn.Application.ActiveDocument);
				vstoDoc.SelectionChange += vstoDoc
			}
			Globals.ThisAddIn.Application.DocumentChange += new Word.ApplicationEvents4_WindowSelectionChangeEventHandler(Sel);
			return Globals.ThisAddIn.Application.DocumentChange;

		}*/

	}
}
