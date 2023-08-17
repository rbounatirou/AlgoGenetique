using BibliAquarium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliVille.Lieux
{
    public class Restaurant : Lieu
    {
        private EnumRestaurant typeResaurant;

        public EnumRestaurant Type { get => typeResaurant; }
        public Restaurant(Coordonees c, string _name, EnumRestaurant _type) : base(c, _name)
        {
            typeResaurant = _type;
        }

        public Restaurant(ushort _x, ushort _y, Ville _v, string _name, EnumRestaurant _type) : base(_x, _y, _v,  _name)
        {
            typeResaurant = _type;
        }

        public override void AccepterVisite(IVisiteur visiteur)
        {
            visiteur.VisiterRestaurant(this);
        }
    }
}
