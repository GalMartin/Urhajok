using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows;

namespace Urhajok
{
    public class Urhajoadatok
    {
        public string Nev { get; set; }
        public int Legenyseg { get; set; }
        public int MaxHatotav { get; set; }
        public int UzemanyagSzint { get; set; }
        public string Gyarto { get; set; }
        public string KuldetesStatusz { get; set; }
        public int InditasEve { get; set; }

        public Urhajoadatok(string nev, int legenyseg, int maxhatotav,int uzemanyagszint, string gyarto, string kuldetesstatusz,int inditaseve)
        {
            Nev = nev;
            Legenyseg = legenyseg;
            MaxHatotav = maxhatotav;
            UzemanyagSzint = uzemanyagszint;
            Gyarto = gyarto;
            KuldetesStatusz = kuldetesstatusz;
            InditasEve = inditaseve;
        }
    }

    public partial class MainWindow : Window
    {
        List<Urhajoadatok> Urhajok = new List<Urhajoadatok>();

        public MainWindow()
        {
            InitializeComponent();

            Urhajok = new List<Urhajoadatok>
        {
            new Urhajoadatok("Falcon-9", 7, 550000, 87, "SpaceX", "Sikeres", 2020),
            new Urhajoadatok("Orion-X1", 4, 820000, 73, "NASA", "Folyamatban", 2023),
            new Urhajoadatok("StarRider", 12, 910000, 66, "Boeing", "Sikeres", 2019),
            new Urhajoadatok("SolarWind", 3, 300000, 92, "ESA", "Sikertelen", 2018),
            new Urhajoadatok("Galaxy-Cruiser", 18, 1200000, 54, "Blue Origin", "Sikeres", 2022),
            new Urhajoadatok("Nova-Prime", 10, 760000, 80, "Roscosmos", "Sikeres", 2017),
            new Urhajoadatok("Pioneer-VII", 6, 640000, 70, "NASA", "Folyamatban", 2024),
            new Urhajoadatok("Titan-Hawk", 14, 1050000, 48, "SpaceX", "Sikeres", 2021),
            new Urhajoadatok("CosmoJet", 5, 430000, 93, "JAXA", "Sikertelen", 2016),
            new Urhajoadatok("Nebula-FX", 11, 870000, 60, "ESA", "Sikeres", 2020)
        };
        }


        private void betoltes(object sender, RoutedEventArgs e)
        {
            datagrid.ItemsSource = Urhajok;
            datagrid.Items.Refresh();
        }

        private void hanyurhajo(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"A listában {Urhajok.Count} űrhajó található.");
        }
    }
}