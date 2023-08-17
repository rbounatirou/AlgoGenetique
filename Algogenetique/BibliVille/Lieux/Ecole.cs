using BibliAquarium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliVille.Lieux
{
    public class Ecole : Lieu
    {

        private EnumEcole typeEcole;

        public EnumEcole Type { get => typeEcole;  }
        public Ecole(Coordonees c, string _name, EnumEcole type) : base(c, _name)
        {
            typeEcole = type;
        }

        public Ecole(ushort _x, ushort _y, Ville _v, string _name, EnumEcole type) : base(_x, _y, _v, _name)
        {
            typeEcole = type;
        }

        public override void AccepterVisite(IVisiteur visiteur)
        {
            visiteur.VisiterEcole(this);
        }
    }
}
