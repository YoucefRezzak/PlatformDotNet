using Microsoft.Win32;
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

namespace Views
{
    /// <summary>
    /// Logique d'interaction pour Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Upload(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.DefaultExt = ".txt"; // Required file extension 
            fileDialog.Filter = "Text documents (.txt)|*.txt"; // Optional file extensions

            fileDialog.ShowDialog();
        }

        private void send(object sender, RoutedEventArgs e)
        {
            //Send files
        }

        private void result(object sender, RoutedEventArgs e)
        {
            string resultat = "ze3ma un long text yji hna kbiiiiiiiiiira w tw" +
                "iiiiiiiiil par exemple ktiba bezaaaf matekhlassch tu vois" +
                "aya w rna mazelna nahdro psk ani hab n3amer la fenetre psk les fichiers" +
                "yjiw twal mais hada ghir test berk w khlas " +
                "riad hab ydir b ASP jsp pk O.o alors que C# c'est plus facile" +
                "akhtik men ASP sahbi c# khir wellaah !" +
                "aya khlas kemelt normalement rani 3amertha";
            string key = " ze3ma key hhh";
            double confidence = 51.11;
            this.Hide();
            Results res = new Results(resultat, key, confidence);
            res.Show();
        }
    }
}
