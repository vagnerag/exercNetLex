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
	public partial class FrmTableConfig : Form
	{
		RibbonPresenter Rp;

		public FrmTableConfig()
		{
			InitializeComponent();
		}

		private void BntAddTableOK_Click(object sender, EventArgs e)
		{
			Rp = new RibbonPresenter();

			//Seta as variáveis INT com os valores inseridos na tela de configuração da tabela
			int numLinhas = (int)NudNumLinhas.Value;
			int numColunas = (int)NudNumColunas.Value;

			//Fecha a tela de configuração após extrair os valores digitados
			ActiveForm.Close();

			//Chama a função de criar tabela passando os valores extraidos
			Rp.CriarTabela(numLinhas, numColunas);
			
		}

		private void BntAddTableCancel_Click(object sender, EventArgs e)
		{
			ActiveForm.Close();
		}
	}
}
