using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace Age_of_LanSchool
{
    public class Tourelle
    {
        public Point Position { get; set; }
        public double Portee { get; set; } = 100;
        public int Degats { get; set; } = 10;
        public TimeSpan IntervalleTir { get; set; } = TimeSpan.FromSeconds(4);

        private DispatcherTimer timer;

        public Tourelle()
        {
            timer = new DispatcherTimer();
            timer.Interval = IntervalleTir;
            timer.Tick += (s, e) => Attaquer();
            timer.Start();
        }

        public List<Ennemi> Ennemis { get; set; }

        private void Attaquer()
        {
            foreach (var ennemi in Ennemis)
            {
                if (EstDansPortee(ennemi.Position))
                {
                    ennemi.RecevoirDegats(Degats);
                    break; // Ne tire que sur un ennemi à la fois
                }
            }
        }

        private bool EstDansPortee(Point pos)
        {
            double distance = Math.Sqrt(Math.Pow(pos.X - Position.X, 2) + Math.Pow(pos.Y - Position.Y, 2));
            return distance <= Portee;
        }
    }

}
