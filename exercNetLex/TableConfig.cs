using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercNetLex
{
	public partial class frmTableConfig : Form
	{
		public frmTableConfig()
		{
			InitializeComponent();
		}

		private void bntAddTableOK_Click(object sender, EventArgs e)
		{
			int numLinhas = (int)nudNumLinhas.Value;
			int numColunas = (int)nudNumColunas.Value;

			ActiveForm.Close();

			ThisAddIn.CriarTabela(numLinhas, numColunas);
			
		}
	}
}
