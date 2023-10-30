using CodeNamesClientSide.CodeNamesService;
using ControlzEx.Controls;
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
    /// Interaction logic for SocialWindow.xaml
    /// </summary>
    public partial class SocialWindow : Window, IFriendListServiceCallback
    {
        private MusicManager musicManager;
        public SocialWindow()
        {
            InitializeComponent();
            musicManager = new MusicManager("Media/Music/BackgroundCheck.wav");
            musicManager.PlayMusic();
        }

        public void ShowFriends(Player[] friends)
        {
            
        }

        public void ShowGlobalUsers(Player[] users)
        {
            throw new NotImplementedException();
        }

        private void BtnGoBack_Click(object sender, RoutedEventArgs e)
        {
            MainMenuWindow mainMenulWindow = new MainMenuWindow();

            mainMenulWindow.Show();

            this.Close();

            musicManager.StopMusic();
            base.OnClosed(e);
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verificar qué pestaña está seleccionada
            if (TacSocial.SelectedItem == TabGlobalUsers)
            {
                

            }
            else if (TacSocial.SelectedItem == TabRequest)
            {
                // Otra pestaña seleccionada
                // Aquí puedes mostrar u ocultar los controles específicos para esta pestaña.
            }
            else
            {
            }
            // Agrega más condiciones para otras pestañas si es necesario.
        }

        



    }
}
