﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using static Cotador.Core.Constants;
namespace Cotador.Inicio
{
	/// <summary>
	/// Interaction logic for Tela_Inicial.xaml
	/// </summary>
	public partial class Tela_Inicial : Window
	{
		public Tela_Inicial()
		{
			//Core.NetworkTest.test();
			
			InitializeComponent();
		}
		protected override void OnClosed(EventArgs e)
		{
			base.OnClosed(e);

			Application.Current.Shutdown();
		}
		private void Nacional_Click(object sender, RoutedEventArgs e)
		{
			Nacional.Nacional nacional = new Nacional.Nacional();
			nacional.Show();
		}

		private void Trasporte_Click(object sender, RoutedEventArgs e)
		{
			MainWindow mainWindow = new MainWindow();
			mainWindow.Show();
		}

		private void Internacional_Click(object sender, RoutedEventArgs e)
		{
			Internacional.janela_Internacional internacional = new Internacional.janela_Internacional();
			internacional.Show();
		}

		private void Avulsas_Click(object sender, RoutedEventArgs e)
		{
			Caixa_de_Mensagem.mensagem men = new Caixa_de_Mensagem.mensagem("Erro", "Avulsas ainda não implementado");
			men.Show();
		}

		private void Relatorio(object sender, object e)
		{
			Relatorio.Relatorio_Janela Relatorio = new Relatorio.Relatorio_Janela();
			Relatorio.Show();
		}

		private void RelacaoArquivos_Drop(Object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent("FileName"))
			{
				string[] fileName = (string[])e.Data.GetData(DataFormats.FileDrop);
				try
				{
					//Desaparecer();
					//LoopVisualTree(this);
					//Adicionar_Cotacao.Abrir_e_Adicionar cot = new Adicionar_Cotacao.Abrir_e_Adicionar(fileName[0]);
					//cot.show()
				}
				catch (Exception f)
				{
					MessageBox.Show($"Houve um erro na hora de importar o arquivo Excel\n{f}");
				}
			}
		}


		private void Buscar_Cotacao(object sender, MouseButtonEventArgs e)
		{
			Transportador.Servidor.Procurar pro = new Transportador.Servidor.Procurar();
			pro.Show();
		}
	}
}
