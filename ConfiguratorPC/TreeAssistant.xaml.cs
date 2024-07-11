using ConfiguratorPC.Pages;
using System;
using System.Collections.Generic;
using System.Data;
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
using System.Data.SqlClient;

namespace ConfiguratorPC
{
	/// <summary>
	/// Логика взаимодействия для TreeAssistant.xaml
	/// </summary>
	public partial class TreeAssistant : Window
	{
		public TreeAssistant()
		{
			InitializeComponent();
			DataSet dataSet = new DataSet();
			
		}

		public string ViewModel {get; set;}
		
		public void ShowViewModel()
		{
			MessageBox.Show(ViewModel);
		}

		private void TitleBorder_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			DragMove();
		}

		private void CloseButton_Click(object sender, RoutedEventArgs e)
		{
			Close();
		}

		private void MaxMinButton_Click(object sender, RoutedEventArgs e)
		{
			if(WindowState == WindowState.Normal)
			{
				WindowState = WindowState.Maximized;
			}
			else
			{
				WindowState = WindowState.Normal;
			}
		}

		private void HideButton_Click(object sender, RoutedEventArgs e)
		{
			WindowState = WindowState.Minimized;
		}

		private void ConfigWindow_StateChanged(object sender, EventArgs e)
		{
			if(WindowState == WindowState.Maximized)
			{
				MaxMinButtonImage.Source = new BitmapImage(new Uri("Resources/minimize.png", UriKind.Relative));
				TitleBorder.Height = 35;
				TitleDockPanel.Margin = new Thickness(5, 5, 5, 0);
				MainFrame.Margin = new Thickness(5, 0, 5, 0);
			}
			else if(WindowState == WindowState.Normal)
			{
				MaxMinButtonImage.Source = new BitmapImage(new Uri("Resources/maximize.png", UriKind.Relative));
				TitleBorder.Height = 30;
				TitleDockPanel.Margin = MainFrame.Margin = new Thickness(0, 0, 0, 0);
			}
		}
	}
}
