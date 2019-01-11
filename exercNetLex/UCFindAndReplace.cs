using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercNetLex
{
	public partial class UCFindAndReplace : UserControl
	{
		public UCFindAndReplace()
		{
			InitializeComponent();

			if (TxFind.Text.Length > 0)
			{
				BntFindNext.Enabled = true;
			}
			else
			{
				BntFindNext.Enabled = false;
			}
		}

		private void BntFindNext_Click(object sender, EventArgs e)
		{
			
		}
	}
}
