using BibliVille;
using BibliVille.Lieux;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winform
{
    public class VisiteurWinform : IVisiteur
    {
        private bool dessinerTransport;
        private bool dessinerRestaurant;
        private bool dessinerEcole;
        private Panel panel;
        private Graphics graphics;
        private double scaleX;
        private double scaleY;
        public VisiteurWinform(Panel _panel, bool _dessinerTransport, bool _dessinerRestaurant, bool _dessinerEcole, 
            double _scaleX, double _scaleY)
        {
            panel = _panel;
            
            dessinerTransport = _dessinerTransport;
            dessinerRestaurant = _dessinerRestaurant;
            dessinerEcole = _dessinerEcole;
            scaleX = _scaleX;
            scaleY = _scaleY;

        }

        public bool DessinerTransport { get => dessinerTransport; set => dessinerTransport = value; }
        public bool DessinerRestaurant { get => dessinerRestaurant; set => dessinerRestaurant = value; }
        public bool DessinerEcole { get => dessinerEcole; set => dessinerEcole = value; }

        public void Dessiner(Graphics g, Ville v)
        {
            graphics = g;
            g.Clear(Color.White);
            foreach (Lieu l in v.Lieux)
            {
                l.AccepterVisite(this);
            }
            
        }
        public void VisiterEcole(Ecole e)
        {
            if (!dessinerEcole)
                return;
            graphics.FillRectangle(new SolidBrush(Color.Red), new Rectangle((int)(e.Coordonees.X * scaleX)-5,
                (int)(e.Coordonees.Y * scaleY)-5,
                10, 10));

        }

        public void VisiterRestaurant(Restaurant r)
        {
            if (!dessinerRestaurant)
                return;
            graphics.FillRectangle(new SolidBrush(Color.Blue), new Rectangle((int)(r.Coordonees.X * scaleX)-5,
                (int)(r.Coordonees.Y * scaleY)-5,
                10, 10));
        }

        public void VisiterTransport(Transport t)
        {
            if (!dessinerTransport)
                return;
            graphics.FillRectangle(new SolidBrush(Color.Green), new Rectangle((int)(t.Coordonees.X * scaleX)-5,
                (int)(t.Coordonees.Y * scaleY)-5,
                10, 10));
        }

    }
}
