using BibliVille.Lieux;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliVille
{
    public interface IVisiteur
    {
        public void VisiterTransport(Transport t);
        public void VisiterRestaurant(Restaurant r);

        public void VisiterEcole(Ecole e);
    }
}
