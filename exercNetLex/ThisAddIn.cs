using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Windows.Forms;
using Microsoft.Office.Tools.Ribbon;
using Word = Microsoft.Office.Interop.Word;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Word;


namespace exercNetLex
{
	public partial class ThisAddIn
	{
		private void ThisAddIn_Startup(object sender, System.EventArgs e)
		{
		}

		private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
		{
		}

		public static void CriarTabela(int numLinhas, int numColunas)
		{
			object start = 0, end = 0;
			Word.Document document = Globals.ThisAddIn.Application.ActiveDocument;
			Word.Range rng = document.Range(ref start, ref end);


			// Configura o local onde será inserido a tabela
			rng.Font.Name = "Calibri";
			rng.Font.Size = 11;
			rng.InsertParagraphAfter();
			rng.InsertParagraphAfter();
			rng.SetRange(rng.End, rng.End);

			// Add a tabela
			rng.Tables.Add(document.Paragraphs[rng.Start].Range, numLinhas, numColunas);
			rng.SetRange(numLinhas+1, numLinhas + 1);

			// Formata e coloca borda na tabela 
			Word.Table tbl = document.Tables[1];
			tbl.Range.Font.Size = 11;
			tbl.Borders.InsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
			tbl.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
			tbl.Columns.DistributeWidth();
		}

		#region Código gerado por VSTO

		/// <summary>
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InternalStartup()
		{
			this.Startup += new System.EventHandler(ThisAddIn_Startup);
			this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
		}

		#endregion
	}
}
