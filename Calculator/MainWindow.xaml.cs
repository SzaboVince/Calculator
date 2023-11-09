using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculator
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void összead_Click(object sender, RoutedEventArgs e)
		{
			if (szam1.Text==""||szam2.Text=="")
			{
				MessageBox.Show("Adjon meg számot.");
			}
			else
			{
				eredmeny.Text = Convert.ToString(Convert.ToDouble(szam1.Text) + Convert.ToDouble(szam2.Text));

			}
		}

		private void kivon_Click(object sender, RoutedEventArgs e)
		{
			if (szam1.Text == "" || szam2.Text == "")
			{
				MessageBox.Show("Adjon meg számot.");
			}
			else
			{
				eredmeny.Text = Convert.ToString(Convert.ToDouble(szam1.Text) - Convert.ToDouble(szam2.Text));

			}
		}

		private void szoroz_Click(object sender, RoutedEventArgs e)
		{
			if (szam1.Text == "" || szam2.Text == "")
			{
				MessageBox.Show("Adjon meg számot.");
			}
			else
			{
				eredmeny.Text = Convert.ToString(Convert.ToDouble(szam1.Text) * Convert.ToDouble(szam2.Text));

			}
		}

		private void oszt_Click(object sender, RoutedEventArgs e)
		{
			if (szam1.Text == "" || szam2.Text == "")
			{
				MessageBox.Show("Adjon meg számot.");
			}
			else
			{
				eredmeny.Text = Convert.ToString(Math.Round(Convert.ToDouble(szam1.Text) / Convert.ToDouble(szam2.Text),2));

			}
		}

		private void maradek_Click(object sender, RoutedEventArgs e)
		{
			if (szam1.Text == "" || szam2.Text == "")
			{
				MessageBox.Show("Adjon meg számot.");
			}
			else
			{
				eredmeny.Text = Convert.ToString(Convert.ToDouble(szam1.Text) % Convert.ToDouble(szam2.Text));

			}
		}
	}
}
