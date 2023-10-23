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
        private MusicManager musicManager;

        public MainMenuWindow()
        {
            InitializeComponent();

            Settings.MouseLeftButtonDown += Settings_MouseLeftButtonDown;
            Profile.MouseLeftButtonDown += Profile_MouseLeftButtonDown;
            musicManager = new MusicManager("Media/Music/FastestVersionSneakyAction.wav");
            musicManager.PlayMusic();
        }

        private void Settings_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            CodeNamesSettingsWindow codeNamesSettingsWindow = new CodeNamesSettingsWindow(musicManager);

            codeNamesSettingsWindow.Show();

            this.Close();

            musicManager.StopMusic();
            base.OnClosed(e);
        }

        private void BtnSocial_Click(object sender, RoutedEventArgs e)
        {
            SocialWindow socialWindow = new SocialWindow();

            socialWindow.Show();

            this.Close();

            musicManager.StopMusic();
            base.OnClosed(e);
        }

        private void BtnJoinGame_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnCreateGame_Click(object sender, RoutedEventArgs e)
        {
            GameBoardSettings gameBoardSettingsWindow = new GameBoardSettings();

            gameBoardSettingsWindow.Show();

            this.Close();

            musicManager.StopMusic();
            base.OnClosed(e);
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

            musicManager.StopMusic();
            base.OnClosed(e);
        }
    }
}
