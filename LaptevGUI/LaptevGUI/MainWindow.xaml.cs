﻿using System.Windows;
using System.Windows.Controls;
using System.Data;

namespace LaptevGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow() {
            InitializeComponent();
            foreach (UIElement el in MainRoot.Children) {
                if (el is Button) {
                    ((Button) el).Click += Button_Click;
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            string str = (string) ((Button) e.OriginalSource).Content;
            if (str == "AC") {
                TextLabel.Text = "";
            } else if (str == "=") {
                string value = new DataTable().Compute(TextLabel.Text, null).ToString();
                TextLabel.Text = value;
            } else {
                TextLabel.Text += str;
            }
        }
    }
}