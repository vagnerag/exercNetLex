﻿using System;
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
		private UCFindAndReplace Fr;
		private static Microsoft.Office.Tools.CustomTaskPane myCustomTaskPane;

		private void ThisAddIn_Startup(object sender, System.EventArgs e)
		{
			Fr = new UCFindAndReplace();
			myCustomTaskPane = this.CustomTaskPanes.Add(Fr, "Find And Replace");
		}

		private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
		{
		}

		public static void IniciarFindAndReplace()
		{
			myCustomTaskPane.Visible = !myCustomTaskPane.Visible;
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
