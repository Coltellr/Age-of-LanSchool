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
        public bool inRange = false;
        public int range = 150;
        public int ptVieBaseMe = 100, ptVieBaseEn = 100;
        System.Drawing.Rectangle hitbox2;
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
            Range(player);
            if (!inRange)
            {
                Deplacement(player);
            }
            else
            {
                Attaque(player);
            }
            
        }
            Ennemi ennemi = new Ennemi(50, new System.Drawing.Point(877, 721));
            

        private void Deplacement(Rectangle player)
        {
            Canvas.SetLeft(player, Canvas.GetLeft(player) + 6);
        }
        
        private void Range(Rectangle player)
        {
            System.Drawing.Rectangle hitbox = new System.Drawing.Rectangle( (int)(Canvas.GetLeft(player) + player.Width), (int)Canvas.GetTop(player) , range, 5);
            hitbox2 = new System.Drawing.Rectangle( (int)Canvas.GetLeft(Player2), (int)Canvas.GetTop(Player2) , (int)Player2.Width, (int)Player2.Height);
            inRange = hitbox.IntersectsWith(hitbox2);
        }

        private void Attaque(Rectangle player)
        {
            canvasMainWindow.Children.Remove(Player2);
        }
    }

}