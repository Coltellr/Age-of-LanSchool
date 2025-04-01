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
        public static Canvas MainCanvas { get; private set; }
        public DispatcherTimer minuterie;
        public bool inRange = false;
        public int range = 150;
        public int ptVieBaseMe = 100, ptVieBaseEn = 100;
        public int delaiSpawn = 0;
        public List<Ennemi> ennemis = new List<Ennemi>();
        public bool peutSpawn = false;
        System.Drawing.Rectangle hitbox2;
        public MainWindow()
        {
            InitializeComponent();
            InitTimer();
            MainCanvas = canvasMainWindow;
        }

        private void InitTimer()
        {
            minuterie = new DispatcherTimer();
            minuterie.Interval = TimeSpan.FromMilliseconds(17);
            minuterie.Tick += Jeu;
            minuterie.Start();
        }
        private void Jeu(object? sender, EventArgs e)
        {
            

            
            //Canvas.SetLeft(visuelEnnemi, ennemi.X);
            //Canvas.SetTop(visuelEnnemi, ennemi.Y);
            //canvasMainWindow.Children.Add(visuelEnnemi);
            Deplacement(player);
            Delai();
            Range(player);
            if (!inRange)
            {
                Deplacement(player);
            }
            else
            {
                //Attaque(player);
            }
            
        }
            
            

        private void Deplacement(Rectangle player)
        {
            foreach (Ennemi ennemi in ennemis)
            {
                ennemi.Deplacement();
            }
        }
        
        private void Range(Rectangle player)
        {
            System.Drawing.Rectangle hitbox = new System.Drawing.Rectangle( (int)(Canvas.GetLeft(player) + player.Width), (int)Canvas.GetTop(player) , range, 5);
            hitbox2 = new System.Drawing.Rectangle( (int)Canvas.GetLeft(Player2), (int)Canvas.GetTop(Player2) , (int)Player2.Width, (int)Player2.Height);
            inRange = hitbox.IntersectsWith(hitbox2);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (peutSpawn)
            {
                Ennemi ennemi = new Ennemi(50, 200, 721, 25);
                ennemis.Add(ennemi);
                delaiSpawn = 0;
                peutSpawn = false;

            }
            
        }

        private void Delai()
        {
            delaiSpawn = delaiSpawn + 1;
            peutSpawn = (double)(delaiSpawn / 17) >= 1;
            
        }


    }

}