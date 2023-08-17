using BibliAquarium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliVille.Lieux
{
    public class Transport : Lieu
    {
        public Transport(ushort _x, ushort _y, Ville _v,  string _name) : base(_x, _y, _v, _name)
        {
        }

        public Transport(Coordonees c, string name) : base(c, name) { }

        public override void AccepterVisite(IVisiteur visiteur)
        {
            visiteur.VisiterTransport(this);
        }
    }
}
