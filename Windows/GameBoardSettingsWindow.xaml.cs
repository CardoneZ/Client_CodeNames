using CodeNamesClientSide.CodeNamesService;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Channels;
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
    /// Interaction logic for GameBoardSettings.xaml
    /// </summary>
    public partial class GameBoardSettings : Window, ILobbyServiceCallback
    {

        private CodeNamesService.Player[] playerList;
        private LobbyServiceClient lobbyServiceClient;
        private bool isNewRoom;
        private string roomId;
        private bool isConected = false;
        private bool isHost = false;
        public bool IsNewRoom { get { return isNewRoom; } set { isNewRoom = value; } }
        public string RoomId { get { return roomId; } set { roomId = value; } }

        private List<string> chatMessages = new List<string>();

        public GameBoardSettings()
        {
            InitializeComponent();
            LibChat.ItemsSource = chatMessages;

        }

        public void UserLoggedIn(string username)
        {
            throw new NotImplementedException();
        }

        public void UserLoggedOut(string username)
        {
            throw new NotImplementedException();
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void BtnSendMessage_Click(object sender, RoutedEventArgs e)
        {
            String message = TbMessage.Text;
            if (!string.IsNullOrEmpty(message))
            {
                chatMessages.Add(message);
                LibChat.Items.Refresh(); // Actualiza la ListBox
                TbMessage.Clear(); // Borra el contenido del TextBox
            }
        }
    }
}
