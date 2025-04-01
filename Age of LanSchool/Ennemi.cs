using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Age_of_LanSchool
{
    public class Ennemi
    {

        private int vie;
        private int degat;
        private bool peutAttaquer;
        private Rectangle texture;

        public Ennemi(int vie,double x, double y , int degat)
        {
            this.Vie = vie;
            this.Degat = degat; 
            this.Texture = new Rectangle();
            this.Texture.Width = 50;
            this.Texture.Height = 80;
            this.Texture.Fill = Brushes.Black;
            MainWindow.MainCanvas.Children.Add(this.Texture);
            // Positionne le rectangle sur le Canvas
            Canvas.SetLeft(this.Texture, x);
            Canvas.SetTop(this.Texture, y);

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

        public Rectangle Texture
        {
            get
            {
                return this.texture;
            }

            set
            {
                this.texture = value;
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
            Canvas.SetLeft(this.Texture, Canvas.GetLeft(this.Texture) + 6);
        }

    }

}
