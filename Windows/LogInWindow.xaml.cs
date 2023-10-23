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

namespace CodeNamesClientSide.Windows
{
    /// <summary>
    /// Interaction logic for LogInWindow.xaml
    /// </summary>
    public partial class LogInWindow : Window
    {
        public LogInWindow()
        {
            InitializeComponent();
        }


        private void BtnExitGame_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void BtnSignUp_Click(object sender, RoutedEventArgs e)
        {
            SignUpWindow signUpWindow = new SignUpWindow();

            signUpWindow.Show();

            this.Close();
        }

        private void BtnPlayGuest_Click(object sender, RoutedEventArgs e)
        {
            MainMenuWindow mainMenuWindow = new MainMenuWindow();

            mainMenuWindow.Show();

            this.Close();
        }

        private void BtnLogIn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
