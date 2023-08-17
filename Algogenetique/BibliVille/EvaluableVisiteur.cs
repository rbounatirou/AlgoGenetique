using BibliVille.Lieux;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliVille
{
    public abstract class EvaluableVisiteur : IVisiteur
    {
        public abstract double GetScore();
        public abstract void VisiterEcole(Ecole e);

        public abstract void VisiterRestaurant(Restaurant r);

        public abstract void VisiterTransport(Transport t);
    }
}
