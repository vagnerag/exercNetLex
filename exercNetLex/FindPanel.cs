using System;
using System.Windows.Forms;

namespace exercNetLex
{
	public partial class FindPanel : UserControl
	{
		FindPanelPresenter FindPanelPresent;

		public FindPanel()
		{
			InitializeComponent();
		}

		private void BntFindNext_Click(object sender, EventArgs e)
		{
			FindPanelPresent = new FindPanelPresenter();

			FindPanelPresent.FindNext(TxFind.Text);
		}

		private void TxFind_TextChanged(object sender, EventArgs e)
		{
			if (TxFind.Text.Length > 0)
			{
				BntFindNext.Enabled = true;
			}
			else
			{
				BntFindNext.Enabled = false;
			}
		}
	}
}
