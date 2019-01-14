using System;
using Word = Microsoft.Office.Interop.Word;

namespace exercNetLex
{
	public class RibbonPresenter
	{
		public Word.Document Documento = Globals.ThisAddIn.Application.ActiveDocument;
		public Word.Selection Selecao = Globals.ThisAddIn.Application.Selection;
		public Word.Range Range = Globals.ThisAddIn.Application.Selection.Range;

		public void SavePDF()
		{
			//Extrai as informções do documento ativo
			string nomeDocument = Documento.Name;
			string enderecoDoc = Documento.Path;

			//Cria uma string para armazenar o endereço onde o arquivo PDF será salvo e chama a função para converter
			string enderecoPDF = enderecoDoc + "\\" + nomeDocument + ".pdf";
			if (!Documento.Saved)
			{
				Documento.Save();
			}
			Documento.ExportAsFixedFormat(enderecoPDF, Word.WdExportFormat.wdExportFormatPDF, OpenAfterExport: true);
		}

		public void AddImage(string nomeImg)
		{
			//Add a imagem no documento
			Globals.ThisAddIn.Application.Selection.InlineShapes.AddPicture(nomeImg);
		}

		public void CriarTabela(int numLinhas, int numColunas)
		{
			object start = 0, end = 0;

			Word.Range rng = Documento.Range(ref start, ref end);

			// Configura o local onde será inserido a tabela
			rng.Font.Name = "Calibri";
			rng.Font.Size = 11;
			rng.InsertParagraphAfter();
			rng.InsertParagraphAfter();
			rng.SetRange(rng.End, rng.End);

			// Add a tabela
			rng.Tables.Add(Documento.Paragraphs[rng.Start].Range, numLinhas, numColunas);
			rng.SetRange(numLinhas + 1, numLinhas + 1);

			// Formata e coloca borda na tabela 
			Word.Table tbl = Documento.Tables[1];
			tbl.Range.Font.Size = 11;
			tbl.Borders.InsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
			tbl.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
			tbl.Columns.DistributeWidth();
		}

		public void InvertCase()
		{
			string selecao = Selecao.Text;
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
			Selecao.Delete();
			Selecao.InsertAfter(result);
		}

		public void AddSpan(string condicao)
		{
			Range.InsertBefore("[");
			Range.InsertAfter("]");
			Range.Select();
			Range.Application.Selection.Font.Color = Word.WdColor.wdColorRed;
			Range.Start = Range.Start + 1;
			Range.Select();
			Range.InsertBefore(condicao);
			Range.End = Range.Start + condicao.Length;
			Range.Select();
			Range.Application.Selection.Font.Subscript = -1;
		}

		public void AddField(string fieldName)
		{
			Range.InsertBefore("{" + fieldName + "}");
			Range.Select();
			Range.Application.Selection.Font.Color = Word.WdColor.wdColorRed;
			
		}
	}
}
