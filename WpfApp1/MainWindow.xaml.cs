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

namespace WpfApp1
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public class Monstre
    {
        string nom;
        int pv;
        string degat;

        public string Nom { get => nom; set => nom = value; }
        public int Pv { get => pv; set => pv = value; }
        public string Degat { get => degat; set => degat = value; }
        public Monstre(string nom, int pv, string degat)
        {
            this.Nom = nom;
            this.Pv = pv;
            this.Degat = degat;
        }
        public override string ToString()
        {
            return "Le " + Nom + " qui a " + Pv + "pv et frappe de " + Degat + ".";
        }
        public partial class MainWindow : Window
        {
            public MainWindow()
            {
               // InitializeComponent();


            }
        }
    }
}
