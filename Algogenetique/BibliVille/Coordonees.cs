using BibliAquarium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliVille
{
    public class Coordonees
    {

        private ushort x;
        private ushort y;
        private Ville ville;


        public ushort X
        {
            get => x;
            private set => setX(value); 
        }

        

        public ushort Y { get => y; private set => setY(value);  }

        private void setX(ushort value)
        {
            x = Math.Min(value,ville.W);
        }

        private void setY(ushort value)
        {
            y = Math.Min(value, ville.H);
        }




        // X et Y
        public Coordonees(ushort x, ushort y, Ville v)
        {
            this.ville = v;
            this.X = x;
            
            this.Y = y;
            
        }

        // RENVOIE LA DISTANCE ENTRE LES POINTS
        public double GetDstFrom(Coordonees from)
        {
            return Math.Sqrt(Math.Pow((from.x - x), 2) + Math.Pow((from.y - y), 2));
        }

        public Coordonees Crossover(Coordonees crosswith)
        {
            ushort[] coords = new ushort[2];            
            int i = 0;
            bool  isLeftParent;

            while (i < coords.Length)
            {
                int log = (int)Math.Log2(i == 0 ? ville.W : ville.H) + 1;
                int c = Alea.GenererAleatoire(1, log); // ON CROSS LES POSITION A LA VALEUR ALEATOIRE C
                isLeftParent = Alea.GenererAleatoire(0, 1) == 0; // Si true l'instance sera a gauche
                
                /*long min = ((uint)Math.Pow(2, (32-c)));
                long max = UInt32.MaxValue - min;*/
                int m1 = (UInt16.MaxValue << ((log+1) - c));
                int m2 = UInt16.MaxValue >> (c);

                ushort[] v = (i == 0 ? new ushort[] { x, crosswith.X } : new ushort[] { y, crosswith.Y });
                if (!isLeftParent)
                {
                    ushort tmp = v[0];
                    v[0] = v[1];
                    v[1] = tmp;
                }  
                coords[i] = (ushort)((v[0] & m1) + (v[1] & m2));
                i++;
            }
            return new Coordonees(coords[0], coords[1], ville);
        }

        public void Mutate(int probaPercentPerBits)
        {
            
            X = MutateX(probaPercentPerBits);
            Y = MutateY(probaPercentPerBits);          
        }

        private ushort MutateX(int probaPercentPerBits)
        {
            int log = (int)Math.Log2(ville.W);
            ushort tmpNb = x;
            int rnd;
            for (int i = 0; i < log; i++)
            {
                rnd = Alea.GenererAleatoire(1, 100);
                if (probaPercentPerBits >= rnd)
                {
                    ushort pow = (ushort)Math.Pow(2, log);
                    if ((tmpNb & pow) > 0)
                    {
                        tmpNb -= pow;
                    }
                    else
                    {
                        tmpNb += pow;
                    }
                }
            }
            return tmpNb;
        }

        private ushort MutateY(int probaPercentPerBits)
        {
            int log = (int)Math.Log2(ville.H);
            ushort tmpNb = y;
            int rnd;
            for (int i = 0; i < log; i++)
            {
                rnd = Alea.GenererAleatoire(1, 100);
                if (probaPercentPerBits >= rnd)
                {
                    ushort pow = (ushort)Math.Pow(2, log);
                    if ((tmpNb & pow) > 0)
                    {
                        tmpNb -= pow;
                    }
                    else
                    {
                        tmpNb += pow;
                    }
                }
            }
            return tmpNb;
        }
    }
}
