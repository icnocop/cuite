﻿using System.Windows;

namespace Sut.Wpf.ScreenComponents
{
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnOpenModalDialog_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new Dialog
            {
                Owner = this
            };

            dialog.ShowDialog();
        }

        private void OnOpenNonModalDialog(object sender, RoutedEventArgs e)
        {
            var dialog = new Dialog
            {
                Owner = this
            };

            dialog.Show();
        }
    }
}