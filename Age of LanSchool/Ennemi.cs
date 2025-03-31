using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_of_LanSchool
{
    public class Ennemi
    {
        private Point position;
        private int vie;

        public Ennemi(int vie, Point position)
        {
            Vie = vie;
            Position = position;
        }

        public Point Position
        {
            get
            {
                return position;
            }

            set
            {
                position = value;
            }
        }

        public int Vie
        {
            get
            {
                return vie;
            }

            set
            {
                vie = value;
            }
        }

        public void RecevoirDegats(int montant)
        {
            Vie -= montant;
            if (Vie <= 0)
            {
                // Ennemi mort
            }
        }
    }

}
