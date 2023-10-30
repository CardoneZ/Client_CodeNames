using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Threading;

namespace CodeNamesClientSide.Windows
{
    /// <summary>
    /// Interaction logic for LogInWindow.xaml
    /// </summary>
    public partial class LogInWindow : Window
    {
        private MusicManager musicManager;

        public LogInWindow()
        {
            InitializeComponent();
            musicManager = new MusicManager("Media/Music/BackgroundCheck.wav");
            musicManager.PlayMusic();
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

            musicManager.StopMusic();
            base.OnClosed(e);
        }

        private void BtnPlayGuest_Click(object sender, RoutedEventArgs e)
        {
            Utilities.Player.PlayerClient = new Utilities.Player()
            {
                Username = $"Guest{new Random().Next()}",
                IsGuest = true
            };
            
            MainMenuWindow mainMenuWindow = new MainMenuWindow();

            mainMenuWindow.Show();

            this.Close();

            musicManager.StopMusic(); 
            base.OnClosed(e);
        }

        private void BtnLogIn_Click(object sender, RoutedEventArgs e)
        {
            LoginRequest();
            
        }

        private void LoginRequest()
        {
            string username = TbNickname.Text;
            string password = TbPassword.Text;
            if (!String.IsNullOrWhiteSpace(username) && !String.IsNullOrWhiteSpace(password))
            {
                if (CheckStrings(username, password))
                {
                    if (CheckExcessLength(username, password))

                    {
<<<<<<< HEAD
                        ServiceModel.IPlayerManager client = new ServiceModel.PlayerManagerClient();
=======
                        CodeNamesService.PlayerManagerServiceClient client = new CodeNamesService.PlayerManagerServiceClient();

>>>>>>> efcb2f772394ff40c02550feb37dbc2704b45123

                        var playerLogin = client.Login(username, Utilities.PasswordEncryptor.HashPassword(password));

                        if (playerLogin != null)
                        {
                                Utilities.Player.PlayerClient = new Utilities.Player()
                                {
                                    Idplayer = playerLogin.Player_Id,
                                    Username= playerLogin.Nickname,
                                    Email = playerLogin.Email,
                                    IsGuest = false
                                };

                                MainMenuWindow mainMenuWindow = new MainMenuWindow();
                                mainMenuWindow.Show();
                                this.Close();

                        }
                        else
                        {
                            MessageBox.Show("Datos incorrecto","Fallo al iniciar sesión", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Ingresa todos los datos", "Información faltante", MessageBoxButton.OK, MessageBoxImage.Warning);

            }
        }

        #region LoginValidations
        private bool CheckExcessLength(string username, string password)
        {
            bool validLength = username.Length <= 20 && password.Length <= 30;

            if (!validLength)
            {
                MessageBox.Show("La información excede el número de caracteres permitido", "Máximo de caracteres", MessageBoxButton.OK);
            }

            return validLength;
        }

        private bool CheckStrings(string username, string password)
        {

            bool validStrings = (Regex.IsMatch(username, "^[a-zA-Z0-9]*$") && Regex.IsMatch(password, "^[a-zA-Z0-9]*$"));
            
            if (!validStrings)
            {
                MessageBox.Show("La información ingresada contiene caracteres no permitidos", "Error en los caracteres", MessageBoxButton.OK);

            }
            return validStrings;
        }
        #endregion

     

    }
}
