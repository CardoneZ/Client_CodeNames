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
    /// Interaction logic for SignUpWindow.xaml
    /// </summary>
    public partial class SignUpWindow : Window
    {
        public SignUpWindow()
        {
            InitializeComponent();
        }

        private void BtnSignUp_Click(object sender, RoutedEventArgs e)
        {
            string username = TbNickname.Text;
            string email = TbEmail.Text;
            string password = TbPassword.Text;
            //ServiceReference1.IDatabaseService client = new ServiceReference1.DatabaseServiceClient();
            //client.AddUserAccountToDatabase(username, email, password);

            TbEmail.Clear();
            TbPassword.Clear();
            TbNickname.Clear();

            MessageBox.Show("El registro del usuario se ha realizado con éxito", "Registro Exitoso");
        }

        private void BtnCancelSignUp_Click(object sender, RoutedEventArgs e)
        {
            LogInWindow logInWindow = new LogInWindow();

            logInWindow.Show();

            this.Close();
        }
    }
}
