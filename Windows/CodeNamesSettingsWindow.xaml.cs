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
    /// Interaction logic for CodeNamesSettingsWindow.xaml
    /// </summary>
    public partial class CodeNamesSettingsWindow : Window
    {
        public CodeNamesSettingsWindow()
        {
            InitializeComponent();
            Goback.MouseLeftButtonDown += Goback_MouseLeftButtonDown;
        }

        private void Goback_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MainMenuWindow mainMenulWindow = new MainMenuWindow();

            mainMenulWindow.Show();

            this.Close();
        }

        
    }
}
