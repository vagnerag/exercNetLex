using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Windows.Forms;
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


			// Insert a title for the table and paragraph marks. 
			//rng.InsertBefore("Document Statistics");
			rng.Font.Name = "Calibri";
			rng.Font.Size = 11;
			rng.InsertParagraphAfter();
			rng.InsertParagraphAfter();
			rng.SetRange(rng.End, rng.End);

			// Add the table.
			rng.Tables.Add(document.Paragraphs[2].Range, numLinhas, numColunas);


			// Format the table and apply a style. 
			Word.Table tbl = document.Tables[1];
			tbl.Range.Font.Size = 12;
			tbl.Columns.DistributeWidth();

			object styleName = "Table Professional";
			tbl.set_Style(ref styleName);

			// Insert document properties into cells. 
			tbl.Cell(1, 1).Range.Text = "Document Property";
			tbl.Cell(1, 2).Range.Text = "Value";

			tbl.Cell(2, 1).Range.Text = "Subject";
			tbl.Cell(2, 2).Range.Text = ((Office.DocumentProperties)(document.BuiltInDocumentProperties))
				[Word.WdBuiltInProperty.wdPropertySubject].Value.ToString();

			tbl.Cell(3, 1).Range.Text = "Author";
			tbl.Cell(3, 2).Range.Text = ((Office.DocumentProperties)(document.BuiltInDocumentProperties))
				[Word.WdBuiltInProperty.wdPropertyAuthor].Value.ToString();

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
