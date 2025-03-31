using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Age_of_LanSchool
{
    public class Ennemi
    {
        private Point position;
        private int vie;
        private int degat;
        private bool peutAttaquer;
        private Rectangle texture;

        public Ennemi(int vie, Point position, int degat)
        {
            this.Vie = vie;
            this.Position = position;
            this.Degat = degat; 
            this.texture = new Rectangle();
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

        public int Degat
        {
            get
            {
                return this.degat;
            }

            set
            {
                this.degat = value;
            }
        }

        public bool PeutAttaquer
        {
            get
            {
                return this.peutAttaquer;
            }

            set
            {
                this.peutAttaquer = value;
            }
        }

        public void RecevoirDegats(int montant)
        {
            Vie -= montant;
            if (Vie <= 0)
            {
                
            }
        }
        
        public void Deplacement()
        {
            //Canvas.SetLeft(this, Canvas.GetLeft(this) + 6);
        }

    }

}
