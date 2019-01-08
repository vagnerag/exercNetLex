﻿using System;
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
		public FrmTableConfig()
		{
			InitializeComponent();
		}

		private void BntAddTableOK_Click(object sender, EventArgs e)
		{
			//Seta as variáveis INT com os valores inseridos na tela de configuração da tabela
			int numLinhas = (int)NudNumLinhas.Value;
			int numColunas = (int)NudNumColunas.Value;

			//Fecha a tela de configuração após extrair os valores digitados
			ActiveForm.Close();

			//Chama a função de criar tabela passando os valores extraidos
			ThisAddIn.CriarTabela(numLinhas, numColunas);
			
		}
	}
}