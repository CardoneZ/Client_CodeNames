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
using System.Windows.Shapes;

namespace CodeNamesClientSide.Windows
{
    /// <summary>
    /// Interaction logic for MainMenuWindow.xaml
    /// </summary>
    public partial class MainMenuWindow : Window
    {
        public MainMenuWindow()
        {
            InitializeComponent();

            Settings.MouseLeftButtonDown += Settings_MouseLeftButtonDown;
            Profile.MouseLeftButtonDown += Profile_MouseLeftButtonDown;
        }

        private void Settings_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            CodeNamesSettingsWindow codeNamesSettingsWindow = new CodeNamesSettingsWindow();

            codeNamesSettingsWindow.Show();

            this.Close();
        }

        private void BtnSocial_Click(object sender, RoutedEventArgs e)
        {
            SocialWindow socialWindow = new SocialWindow();

            socialWindow.Show();

            this.Close();
        }

        private void BtnJoinGame_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnCreateGame_Click(object sender, RoutedEventArgs e)
        {
            GameBoardSettings gameBoardSettingsWindow = new GameBoardSettings();

            gameBoardSettingsWindow.Show();

            this.Close();
        }

        private void BtnExitGame_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Profile_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            UserProfileWindow userProfileWindow = new UserProfileWindow();

            userProfileWindow.Show();

            this.Close();
        }
    }
}
