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
using System.Windows.Threading;

namespace Age_of_LanSchool
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window

    {
        public DispatcherTimer minuterie;
        public int ptVieBaseMe = 100, ptVieBaseEn = 100;
        public MainWindow()
        {
            InitializeComponent();
            InitTimer();
        }

        private void InitTimer()
        {
            //timer pour faire fonctionner le jeu à 60 fps
            minuterie = new DispatcherTimer();
            minuterie.Interval = TimeSpan.FromMilliseconds(17);
            minuterie.Tick += Jeu;
            minuterie.Start();
        }
        private void Jeu(object? sender, EventArgs e)
        {
            Ennemi ennemi = new Ennemi(50, new System.Drawing.Point(877, 721));
            

        }
    }

}