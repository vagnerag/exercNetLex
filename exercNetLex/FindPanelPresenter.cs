﻿using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace exercNetLex
{
	public class FindPanelPresenter
	{
		FindPanel Fp;

		public static Word.Document Documento = Globals.ThisAddIn.Application.ActiveDocument;
		public Word.Selection Selecao = Globals.ThisAddIn.Application.ActiveDocument.Application.Selection;


		public void FindNext(string texto)
		{
			object objText = texto;
			Selecao.Find.ClearFormatting();
			Selecao.Find.Forward = true;
			Selecao.Find.Execute(objText);
			if (!Selecao.Find.Found)
			{
				Documento.Range(0, 0).Select();
				Selecao.Find.Execute(objText);
				if (!Selecao.Find.Found)
				{
					MessageBox.Show("Não foram encontradas ocorrências!");
				}
			}
		}
	}
}
