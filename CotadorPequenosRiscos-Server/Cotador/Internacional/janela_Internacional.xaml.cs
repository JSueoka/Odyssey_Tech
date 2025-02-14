﻿using System;
using System.Collections.Generic;
using System.IO;
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

namespace Cotador.Internacional
{
	/// <summary>
	/// Interaction logic for janela_Internacional.xaml
	/// </summary>
	public partial class janela_Internacional : Window
	{
		private void Basicas()
		{
			Coberturas.Items.Clear();
			B1.Width = Coberturas.Width;
			B1.Content = "N° 1 – Cobertura Básica Restrita C (bens e/ou mercadorias usadas, em devolução ou redespachadas;";
			Coberturas.Items.Add(B1);
			B2.Width = Coberturas.Width;
			B2.Content = "N° 2 - Cobertura Básica Restrita B;";
			Coberturas.Items.Add(B2);
			B3.Width = Coberturas.Width;
			B3.Content = "N° 3 – Cobertura Básica Ampla A (bens e/ou mercadorias novas);";
			Coberturas.Items.Add(B3);
			B4.Width = Coberturas.Width;
			B4.Content = "N° 4 – Cobertura Básica Restrita para embarques de mercadorias/bens acondicionados em ambientes refrigerados;";
			Coberturas.Items.Add(B4);
			B5.Width = Coberturas.Width;
			B5.Content = "N° 5 – Cobertura Básica Ampla para embarques de mercadorias/bens acondicionados em ambientes refrigerados;";
			Coberturas.Items.Add(B5);
			B6.Width = Coberturas.Width;
			B6.Content = "N° 6 – Cobertura Básica Restrita para mercadorias/bens congeladas;";
			Coberturas.Items.Add(B6);
			B7.Width = Coberturas.Width;
			B7.Content = "N° 7 – Cobertura Básica Ampla para mercadorias/bens congelados;";
			Coberturas.Items.Add(B7);
			B8.Width = Coberturas.Width;
			B8.Content = "N° 8 – Cobertura Básica Ampla para bovinos incluindo reprodução;";
			Coberturas.Items.Add(B8);
			B9.Width = Coberturas.Width;
			B9.Content = "N° 9 – Cobertura Básica Ampla para animais vivos (exceto embarques aéreos de aves vivas);";
			Coberturas.Items.Add(B9);
			B10.Width = Coberturas.Width;
			B10.Content = "N° 10 – Cobertura Básica Ampla para seguros de transportes aéreos de aves vivas;";
			Coberturas.Items.Add(B10);
			B11.Width = Coberturas.Width;
			B11.Content = "N° 11 – Cobertura Básica Ampla para batata e outros bulbos-raízes;";
			Coberturas.Items.Add(B11);
			B12.Width = Coberturas.Width;
			B12.Content = "N° 12 – Cobertura Básica Ampla para embarques a granel (aquaviários e terrestres);";
			Coberturas.Items.Add(B12);
			B13.Width = Coberturas.Width;
			B13.Content = "N° 13 – Cobertura Básica Restrita para transporte de óleo (petróleo) a granel (embarques aquaviários e terrestres);";
			Coberturas.Items.Add(B13);
			B14.Width = Coberturas.Width;
			B14.Content = "N° 14 – Cobertura Básica Restrita para Carvão (embarques aquaviários e terrestres);";
			Coberturas.Items.Add(B14);
			B15.Width = Coberturas.Width;
			B15.Content = "N° 15 – Cobertura Básica Restrita para madeiras (carga no convés)";
			Coberturas.Items.Add(B15);
			B16.Width = Coberturas.Width;
			B16.Content = "N° 16 – Cobertura Básica Ampla para madeiras (carga não acondicionada no convés);";
			Coberturas.Items.Add(B16);
			B17.Width = Coberturas.Width;
			B17.Content = "N° 17 – Cobertura Básica Restrita para borracha natural (excluindo látex líquido);";
			Coberturas.Items.Add(B17);
			B18.Width = Coberturas.Width;
			B18.Content = "N° 18 – Cobertura Básica Restrita para juta;";
			Coberturas.Items.Add(B18);
			B19.Width = Coberturas.Width;
			B19.Content = "N° 19 – Cobertura Básica para seguros de operações isoladas;";
			Coberturas.Items.Add(B19);
			B20.Width = Coberturas.Width;
			B20.Content = "N° 20 – Cobertura Básica para seguros de bagagem;";
			Coberturas.Items.Add(B20);
			B21.Width = Coberturas.Width;
			B21.Content = "N° 21 – Cobertura Básica para seguros de mercadorias conduzidas por portadores;";
			Coberturas.Items.Add(B21);
			B22.Width = Coberturas.Width;
			B22.Content = "N° 22 – Cobertura Básica para seguros de mostruários sob a responsabilidade de viajantes comerciais;";
			Coberturas.Items.Add(B22);
			B23.Width = Coberturas.Width;
			B23.Content = "N° 23 – Cobertura Básica para seguros de transportes de títulos em malotes;";
			Coberturas.Items.Add(B23);
		}
		private void Adicionais()
		{
			Coberturas.Items.Clear();
			A1.Width = Coberturas.Width;
			A1.Content = "N° 200 – Cobertura Adicional de frete e/ou de seguro;";
			Coberturas.Items.Add(A1);
			A2.Width = Coberturas.Width;
			A2.Content = "N° 201 – Cobertura Adicional de despesas;";
			Coberturas.Items.Add(A2);
			A3.Width = Coberturas.Width;
			A3.Content = "N° 202 – Cobertura Adicional de tributos (mercadorias importadas);";
			A4.Width = Coberturas.Width;
			A4.Content = "N° 203 – Cobertura Adicional de Tributos; (MERCADORIAS EXPORTADAS)";
			A5.Width = Coberturas.Width;
			A5.Content = "N° 204 – Cobertura Adicional de Lucros Esperados;";
			Coberturas.Items.Add(A5);
			A6.Width = Coberturas.Width;
			A6.Content = "N° 205 – Cobertura Adicional para mercadorias em devolução ou redespachadas;";
			Coberturas.Items.Add(A6);
			A7.Width = Coberturas.Width;
			A7.Content = "N° 206 – Cobertura Adicional para embarques aéreos sem valor declarado;";
			Coberturas.Items.Add(A7);
			A8.Width = Coberturas.Width;
			A8.Content = "N° 207 – Cobertura Adicional para embarques em navios com denominação a avisar em viagens internacionais;";
			Coberturas.Items.Add(A8);
			A9.Width = Coberturas.Width;
			A9.Content = "N°208 – Cobertura Adicional para classificação de navios em viagens internacionais;";
			Coberturas.Items.Add(A9);
			A10.Width = Coberturas.Width;
			A10.Content = "N° 209 – Cobertura Adicional de transbordo e desvio de rota;";
			Coberturas.Items.Add(A10);
			A11.Width = Coberturas.Width;
			A11.Content = "N° 210 – Cobertura Adicional de riscos de greves;";
			Coberturas.Items.Add(A11);
			A12.Width = Coberturas.Width;
			A12.Content = "N° 211 – Cobertura Adicional de riscos de guerra para embarques aquaviários e aéreos;";
			Coberturas.Items.Add(A12);
			A13.Width = Coberturas.Width;
			A13.Content = "N° 212 – Cobertura Adicional de prorrogação de prazo de duração dos riscos;";
			Coberturas.Items.Add(A13);
			A14.Width = Coberturas.Width;
			A14.Content = "N° 213 – Cobertura Adicional de extensão de cobertura e abertura de volumes;";
			Coberturas.Items.Add(A14);
			A15.Width = Coberturas.Width;
			A15.Content = "N° 214 – Cobertura Adicional de benefícios internos;";
			Coberturas.Items.Add(A15);
			A16.Width = Coberturas.Width;
			A16.Content = "N° 215 – Cobertura Adicional de destruição;";
			Coberturas.Items.Add(A16);
			A17.Width = Coberturas.Width;
			A17.Content = "N° 216 – Cobertura Adicional para mercadorias transportadas em veículos do segurado;";
			Coberturas.Items.Add(A17);
			A18.Width = Coberturas.Width;
			A18.Content = "N° 217 – Cobertura Adicional de roubo (somente com a cobertura Básica Restrita C);";
			Coberturas.Items.Add(A18);
			A19.Width = Coberturas.Width;
			A19.Content = "N° 218 – Cobertura Adicional de extravio (somente com a cobertura Básica Restrita B);";
			Coberturas.Items.Add(A19);
			A20.Width = Coberturas.Width;
			A20.Content = "N° 219 – Cobertura Adicional para os riscos de quebra (somente com a cobertura Básica Ampla A);";
			Coberturas.Items.Add(A20);
		}
		private void Especificas()
		{
			Coberturas.Items.Clear();
			E1.Width = Coberturas.Width;
			E1.Content = "N° 301 – Cláusula Específica para bens usados (limitado à Básica Restrita C);";
			Coberturas.Items.Add(E1);
			E2.Width = Coberturas.Width;
			E2.Content = "N° 302 – Cláusula Específica para embarques aéreos sem valor declarado;";
			Coberturas.Items.Add(E2);
			E3.Width = Coberturas.Width;
			E3.Content = "N° 304 – Cláusula Específica para embarques efetuados no convés dos navios (limitado à cobertura Básica Restrita C);";
			Coberturas.Items.Add(E3);
			E4.Width = Coberturas.Width;
			E4.Content = "Nº 309 - Cláusula Específica de Averbações Simplificadas para os Seguros de Transportes Nacionais e para os Seguros de Exportação";
			Coberturas.Items.Add(E4);
			E5.Width = Coberturas.Width;
			E5.Content = "N° 310 – Cláusula Específica de franquia para os seguros de transportes internacionais e nacionais (exceto operações isoladas e transportes terrestres nacionais);";
			Coberturas.Items.Add(E5);
			E6.Width = Coberturas.Width;
			E6.Content = "N° 312 – Cláusula Específica para aparelhos, máquinas e equipamentos;";
			Coberturas.Items.Add(E6);
			E7.Width = Coberturas.Width;
			E7.Content = "N° 313 – Cláusula Específica para quebra (falta) em mercadorias a granel;";
			Coberturas.Items.Add(E7);
			E8.Width = Coberturas.Width;
			E8.Content = @"N° 314 – Cláusula Específica para mercadorias transportadas em containers ""Padrão ISO"";";
			Coberturas.Items.Add(E8);
			E9.Width = Coberturas.Width;
			E9.Content = "N° 315 – Cláusula Específica de estipulação de seguro de transportes;";
			Coberturas.Items.Add(E9);
			E10.Width = Coberturas.Width;
			E10.Content = "N° 316 – Cláusula Específica de beneficiário;";
			Coberturas.Items.Add(E10);
			E11.Width = Coberturas.Width;
			E11.Content = "N° 317 – Cláusula Específica de dispensa do direito de regresso;";
			E11.Checked += DDR;
			E11.Unchecked += DDR;
			Coberturas.Items.Add(E11);
		}
		public janela_Internacional()
		{
			//Remover Todas as claususlas 15 se nao tiver complementar ou preliminar
			InitializeComponent();
			Adicionais();
			Especificas();
			Basica.IsChecked = true;
			Basicas();

			LAB_Premio_Minimo.Visibility = Visibility.Hidden;
			Premio_Minimo.Visibility = Visibility.Hidden;

			LAB_Quantidade_De_Parcelas.Visibility = Visibility.Hidden;
			Ajustavel_Quantidade_Parcela.Visibility = Visibility.Hidden;
			LAB_Ajustavel_Premio_MInimo.Visibility = Visibility.Hidden;
			_80.Visibility = Visibility.Hidden;
			_90.Visibility = Visibility.Hidden;
			_100.Visibility = Visibility.Hidden;

			LAB_SubLimite.Visibility = Visibility.Hidden;
			Sub_Limite.Visibility = Visibility.Hidden;
			complementar_preliminar.Visibility = Visibility.Hidden;
			LAB_Franquia.Visibility = Visibility.Hidden;
			Franquia.Visibility = Visibility.Hidden;
		}
		private void Averbavel_Checked(object sender, RoutedEventArgs e)
		{
			if (Averbavel.IsChecked == true)
			{
				Ajustavel.IsChecked = false;
				LAB_Premio_Minimo.Visibility = Visibility.Visible;
				Premio_Minimo.Visibility = Visibility.Visible;

				LAB_Ajustavel_Premio_MInimo.Visibility = Visibility.Hidden;
				LAB_Quantidade_De_Parcelas.Visibility = Visibility.Hidden;
				Ajustavel_Quantidade_Parcela.Visibility = Visibility.Hidden;
				_80.Visibility = Visibility.Hidden;
				_90.Visibility = Visibility.Hidden;
				_100.Visibility = Visibility.Hidden;

			}
			else
			{
				Ajustavel.IsChecked = true;
				LAB_Premio_Minimo.Visibility = Visibility.Hidden;
				Premio_Minimo.Visibility = Visibility.Hidden;

				LAB_Ajustavel_Premio_MInimo.Visibility = Visibility.Visible;
				LAB_Quantidade_De_Parcelas.Visibility = Visibility.Visible;
				Ajustavel_Quantidade_Parcela.Visibility = Visibility.Visible;
				_80.Visibility = Visibility.Visible;
				_90.Visibility = Visibility.Visible;
				_100.Visibility = Visibility.Visible;
			}
		}
		private void Atualizar(object sender,RoutedEventArgs e)
		{
			if (Basica.IsChecked == true){
				Basicas();
			
			}else if (Adicional.IsChecked == true){
				Adicionais();
				
			}else if (Especifica.IsChecked == true){
				Especificas();
				
			}
			if (sender.GetType() != A4.GetType())
				return;
			if (((CheckBox)sender).Name == "Impor" )
			{
				if (Impor.IsChecked == true)
				{
					Expor.IsChecked = false;
					A3.IsChecked = true;
					A4.IsChecked = false;
					Franquia.Visibility = Visibility.Visible;
					LAB_Franquia.Visibility = Visibility.Visible;
				}
				if (Impor.IsChecked == false)
				{
					Expor.IsChecked = true;
					A3.IsChecked = false;
					A4.IsChecked = true;
					Franquia.Visibility = Visibility.Hidden;
					LAB_Franquia.Visibility = Visibility.Hidden;
				}
				
			}
			if (((CheckBox)sender).Name == "Expor")
			{
				if (Expor.IsChecked == true)
				{
					Impor.IsChecked = false;
					A3.IsChecked = false;
					A4.IsChecked = true;
					Franquia.Visibility = Visibility.Hidden;
					LAB_Franquia.Visibility = Visibility.Hidden;
				}
				if (Expor.IsChecked == false)
				{
					Impor.IsChecked = true;
					A3.IsChecked = true;
					A4.IsChecked = false;
					Franquia.Visibility = Visibility.Visible;
					LAB_Franquia.Visibility = Visibility.Visible;
				}
			}

			
		}
		private void Ajustavel_Checked(object sender, RoutedEventArgs e)
		{
			if (Ajustavel.IsChecked == false)
			{
				Averbavel.IsChecked = true;
				LAB_Premio_Minimo.Visibility = Visibility.Visible;
				Premio_Minimo.Visibility = Visibility.Visible;

				LAB_Quantidade_De_Parcelas.Visibility = Visibility.Hidden;
				Ajustavel_Quantidade_Parcela.Visibility = Visibility.Hidden;
				LAB_Ajustavel_Premio_MInimo.Visibility = Visibility.Hidden;
				_80.Visibility = Visibility.Hidden;
				_90.Visibility = Visibility.Hidden;
				_100.Visibility = Visibility.Hidden;

			}
			else
			{
				Averbavel.IsChecked = false;
				LAB_Premio_Minimo.Visibility = Visibility.Hidden;
				Premio_Minimo.Visibility = Visibility.Hidden;

				LAB_Ajustavel_Premio_MInimo.Visibility = Visibility.Visible;
				LAB_Quantidade_De_Parcelas.Visibility = Visibility.Visible;
				Ajustavel_Quantidade_Parcela.Visibility = Visibility.Visible;
				_80.Visibility = Visibility.Visible;
				_90.Visibility = Visibility.Visible;
				_100.Visibility = Visibility.Visible;
			}
		}
		private void ListBoxItem_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{

			Coberturas.SelectedItem = null;

		}	
		private void Complementar (object sender, RoutedEventArgs e)
		{
			if (Com_Pre.IsChecked == true)
			{
				complementar_preliminar.Visibility = Visibility.Visible;
				Sub_Limite.Visibility = Visibility.Visible;
				LAB_SubLimite.Visibility = Visibility.Visible;
			}
			else
			{
				complementar_preliminar.Visibility = Visibility.Hidden;
				Sub_Limite.Visibility = Visibility.Hidden;
				LAB_SubLimite.Visibility = Visibility.Hidden;
			}
			
		}
		void LoopVisualTree(DependencyObject obj)
		{
			for (int i = 0; i < VisualTreeHelper.GetChildrenCount(obj); i++)
			{
				if (obj is TextBox)
					((TextBox)obj).Text = string.Empty;
				if (obj is CheckBox)
					((CheckBox)obj).IsChecked = false;
				LoopVisualTree(VisualTreeHelper.GetChild(obj, i));
			}

		}
		long total = DateTime.Now.Ticks;
		private void DDR(object sender, RoutedEventArgs e)
		{
			if (DateTime.Now.Ticks - total < 10) return;
			if (((CheckBox)sender).Content.ToString() == "DDR")
			{
				if (Chk_DDR.IsChecked == true)
				{
					E11.IsChecked = true;
				}
				else
				{
					E11.IsChecked = false;
				}
			}
			else
			{
				if (E11.IsChecked == true)
				{
					Chk_DDR.IsChecked = true;
				}
				else
				{
					Chk_DDR.IsChecked = false;
				}
			}

		}
		private void Limpar_Click(object sender, RoutedEventArgs e)
		{
			LoopVisualTree(this);
		}
		private void AbrirRecusar(object sender, RoutedEventArgs e)
		{
			Transportador.RecusarJanela x = new Transportador.RecusarJanela(this);
			x.Show();
		}
		private void Button_Click(object sender, RoutedEventArgs e)
		{
			try
			{
				Gerar_Arquivo.gerar(this);
				Caixa_de_Mensagem.mensagem messa = new Caixa_de_Mensagem.mensagem("Arquivo gerado", "Arquivo foi gerado com sucesso");
				messa.Show();
			}
			catch (Exception f)
			{
				System.IO.File.WriteAllText(Directory.GetCurrentDirectory() + @"\Debug.txt", f.Message);

				MessageBox.Show($"Houve um erro em gerar o arquivo\nUm relatorio de erros foi salvo em\n{Directory.GetCurrentDirectory() + @"\Debug.txt"}");
				//messa.Show();
			}

		}

		public CheckBox B1 = new CheckBox();
		public CheckBox B2 = new CheckBox();
		public CheckBox B3 = new CheckBox();
		public CheckBox B4 = new CheckBox();
		public CheckBox B5 = new CheckBox();
		public CheckBox B6 = new CheckBox();
		public CheckBox B7 = new CheckBox();
		public CheckBox B8 = new CheckBox();
		public CheckBox B9 = new CheckBox();
		public CheckBox B10 = new CheckBox();
		public CheckBox B11 = new CheckBox();
		public CheckBox B12 = new CheckBox();
		public CheckBox B13 = new CheckBox();
		public CheckBox B14 = new CheckBox();
		public CheckBox B15 = new CheckBox();
		public CheckBox B16 = new CheckBox();
		public CheckBox B17 = new CheckBox();
		public CheckBox B18 = new CheckBox();
		public CheckBox B19 = new CheckBox();
		public CheckBox B20 = new CheckBox();
		public CheckBox B21 = new CheckBox();
		public CheckBox B22 = new CheckBox();
		public CheckBox B23 = new CheckBox();
		public CheckBox A1 = new CheckBox();
		public CheckBox A2 = new CheckBox();
		public CheckBox A3 = new CheckBox();
		public CheckBox A4 = new CheckBox();
		public CheckBox A5 = new CheckBox();
		public CheckBox A6 = new CheckBox();
		public CheckBox A7 = new CheckBox();
		public CheckBox A8 = new CheckBox();
		public CheckBox A9 = new CheckBox();
		public CheckBox A10 = new CheckBox();
		public CheckBox A11 = new CheckBox();
		public CheckBox A12 = new CheckBox();
		public CheckBox A13 = new CheckBox();
		public CheckBox A14 = new CheckBox();
		public CheckBox A15 = new CheckBox();
		public CheckBox A16 = new CheckBox();
		public CheckBox A17 = new CheckBox();
		public CheckBox A18 = new CheckBox();
		public CheckBox A19 = new CheckBox();
		public CheckBox A20 = new CheckBox();
		public CheckBox A21 = new CheckBox();
		public CheckBox A22 = new CheckBox();
		public CheckBox A23 = new CheckBox();
		public CheckBox E1 = new CheckBox();
		public CheckBox E2 = new CheckBox();
		public CheckBox E3 = new CheckBox();
		public CheckBox E4 = new CheckBox();
		public CheckBox E5 = new CheckBox();
		public CheckBox E6 = new CheckBox();
		public CheckBox E7 = new CheckBox();
		public CheckBox E8 = new CheckBox();
		public CheckBox E9 = new CheckBox();
		public CheckBox E10 = new CheckBox();
		public CheckBox E11 = new CheckBox();



		private void Window_Drop(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent("FileName"))
			{
				string[] fileName = (string[])e.Data.GetData(DataFormats.FileDrop);
				try
				{
					LoopVisualTree(this);
					Excel.Abrir(this, fileName[0]);
				}
				catch (Exception f)
				{
					MessageBox.Show($"Houve um erro na hora de importar o arquivo Excel\n{f}");
				}
			}
			
		}
	}
}
