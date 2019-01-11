using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using Word = Microsoft.Office.Interop.Word;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Word;


namespace exercNetLex
{
	public partial class Ribbon1
	{
		RibbonPresenter Rp;

		private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
		{
			//Globals.ThisAddIn.Application.DocumentChange += Change;
			HabilitarBntInvertCase();
		}

		private void BtnSavePDF_Click(object sender, RibbonControlEventArgs e)
		{
			Rp = new RibbonPresenter();
			Rp.SavePDF();
		}

		private void BntAddImage_Click(object sender, RibbonControlEventArgs e)
		{
			//Configuração do openDialog
			dlgImg.InitialDirectory = @"C:\Users\Netlex\Desktop\exercNetLex\";
			dlgImg.Title = "Escolha a Imagem";
			dlgImg.Filter = "Image Files (*.bmp;*.png;*.jpg)|*.bmp;*.png;*.jpg";

			//Mostra o openDialog e seta a stringo com o nome da imagem
			dlgImg.ShowDialog();
			string nomeImg = dlgImg.FileName;

			Rp = new RibbonPresenter();
			Rp.AddImage(nomeImg);
		}

		private void BntAddTabela_Click(object sender, RibbonControlEventArgs e)
		{
			//Mostra a tela de configuração da tabela
			FrmTableConfig ftc = new FrmTableConfig();
			ftc.Show();
		}

		private void HabilitarBntInvertCase()
		{
			if (true)
			{
				BntInvertCase.Enabled = true;
			}
			else
			{
				BntInvertCase.Enabled = false;
			}
		}

		private void BntInvertCase_Click(object sender, RibbonControlEventArgs e)
		{
			Rp = new RibbonPresenter();
			Rp.InvertCase();
		}
	}
}
