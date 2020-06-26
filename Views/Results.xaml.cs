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
    /// Logique d'interaction pour Results.xaml
    /// </summary>
    public partial class Results : Window
    {
        public string result;
        public string key;
        public double confidence;
        public Results(string res, string k, double conf)
        {
            InitializeComponent();
            result = res;
            key = k;
            confidence = conf;
            this.KeyText.Content = "Key : " + key;
            this.ConfText.Content = "Confidence rate : " + confidence.ToString();
            this.InfoText.Text = result;
        }
    }
}
