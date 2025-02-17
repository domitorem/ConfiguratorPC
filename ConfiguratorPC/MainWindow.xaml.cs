﻿using ConfiguratorPC.Controls;
using ConfiguratorPC.Data;
using ConfiguratorPC.Pages;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ConfiguratorPC
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            var processes = Process.GetProcesses().Where(p => p.ProcessName == "ConfiguratorPC");
            if (processes.Count() > 1)
            {
                FeedBack.ShowMessage("Программа уже запущена");
                Application.Current.Shutdown();
            }
            InitializeComponent();
            MaxHeight = SystemParameters.MaximizedPrimaryScreenHeight;
            Navigator.Frame = MainFrame;
            MainFrame.Navigate(new ConfiguratorPage());
        }

        private void TitleBorder_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void MaxMinButton_Click(object sender, RoutedEventArgs e)
        {
            if (WindowState == WindowState.Normal)
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

		  private void HelpButton_Click(object sender, RoutedEventArgs e)
		  {
		      Navigator.Frame.Navigate(new HelpPage());
		  }

		private void ConfigWindow_StateChanged(object sender, EventArgs e)
		{
            if (WindowState == WindowState.Maximized)
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

        private void AboutProgramButton_Click(object sender, RoutedEventArgs e)
        {
            new AboutProgramWindow().ShowDialog();
        }

		private void TreeButton_Click(object sender, RoutedEventArgs e)
		{
			//TreeAssistant treeAssistant = new TreeAssistant();
			//treeAssistant.Show();
			try
			{
				//System.Windows.Forms.Application.EnableVisualStyles();
				//System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
				Form1 form = new Form1();
				//WindowInteropHelper wih = new WindowInteropHelper(this);
				//wih.Owner = form.Handle;

            form.ShowDialog();
            form.Close();
			}
         catch {}
   
		}
	}
}