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
using System.Windows.Navigation;
using System.Windows.Shapes;
namespace Views
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string usr;
            string pswd;
            usr = UsernameText.Text;
            pswd = PswdText.Password;
            // Hna ndiro login hamlik username w password!
            bool logged;
            //aprés avoir vérifié : 
            logged = true;
            if (logged)
            {
                Menu menu = new Menu();
                menu.Show();
                this.Hide();
            }
        }

        private void Entrer(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                this.Button_Click(sender, e);
            }
        }
    }
}
