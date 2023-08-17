using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliAquarium
{
    public class Alea
    {
        private static Random rnd;
        private Alea()
        {
            rnd = new Random();
        }

        public static Random GetAlea()
        {
            if(rnd == default)
            {
                new Alea();
            }
            return rnd;
        }

        public static int GenererAleatoire(int min, int max)
        {
            Random rnd = GetAlea();
            return rnd.Next(min, max+1);
        }
    }
}
