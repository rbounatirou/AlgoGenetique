using BibliAquarium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliVille.Lieux
{
    public abstract class Lieu
    {

        protected Coordonees coordonees;
        protected string name;
        private Coordonees c;

        public Coordonees Coordonees { get => coordonees; }

        public string Name { get => name; }
        public Lieu(ushort _x, ushort _y, Ville _v, string _name) : this(new Coordonees(_x, _y, _v), _name)
        {
        }

        public Lieu(Coordonees c, string _name)
        {
            coordonees = c;
            name = _name;
        }

        public abstract void AccepterVisite(IVisiteur visiteur);
    }
}
