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

namespace Urhajok
{
    public class Urhajoadatok
    {
        public int Legneyseg  { get; set; }
        public int maxHatotav { get; set; }
        public int UzemanyagSzint { get; set; }
        public string Gyarto   { get; set; }
        public bool KuldetesStatusz { get; set; }
        public int InditasEve { get; set; }
    }
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }
}