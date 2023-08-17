using BibliVille.Lieux;

namespace BibliVille
{
    public class Ville
    {
        private ushort w;
        private ushort h;
        private List<Lieu> lieux;

        public Lieu[] Lieux { get => lieux.ToArray(); }

        public ushort W { get => w; }
        public ushort H { get => h; }

        public Ville(ushort _w, ushort _h)
        {
            this.w = _w;
            this.h = _h;
            lieux = new List<Lieu>();
            Load();
        }

        private void Load()
        {
            lieux.Add(new Transport(3200, 600, this, "Bouvardiere"));
            lieux.Add(new Transport(800, 1000, this, "Anatole France"));
            lieux.Add(new Transport(3000, 1000, this, "Bergereonnette"));
            lieux.Add(new Transport(1200, 1200, this, "Nouveau bassin"));
            lieux.Add(new Transport(2600, 1200, this, "Baliniere"));
            lieux.Add(new Transport(3200, 1400, this, "Moliere"));
            lieux.Add(new Transport(1200, 1400, this, "Beausejour"));
            lieux.Add(new Transport(2400, 1400, this, "Albert Camus"));
            lieux.Add(new Transport(3600, 1600, this, "Jeanne"));
            lieux.Add(new Transport(1600, 1800, this, "Bouffay"));
            lieux.Add(new Transport(2000, 1800, this, "Placide"));
            lieux.Add(new Transport(2000, 2200, this, "Centre"));
            lieux.Add(new Transport(2800, 2400, this, "St-Michel"));
            lieux.Add(new Transport(3200, 2400, this, "Viarme"));
            lieux.Add(new Transport(2000, 2600, this, "Vitel"));
            lieux.Add(new Transport(2400, 2600, this, "Italie"));
            lieux.Add(new Transport(1800, 3000, this, "Constantinople"));
            lieux.Add(new Transport(1400, 3200, this, "Talensac"));
            // RESTAURANTS
            lieux.Add(new Restaurant(600, 1800, this, "Le tigre d'Asie", EnumRestaurant.ASIATIQUE));
            lieux.Add(new Restaurant(1400, 2200, this, "Pizzeria italienne", EnumRestaurant.ITALIEN));
            lieux.Add(new Restaurant(1400, 2400, this, "Tradition curry", EnumRestaurant.INDIEN));
            lieux.Add(new Restaurant(1800, 2400, this, "Au boeuf bourguignon", EnumRestaurant.FRANCAIS));
            lieux.Add(new Restaurant(3200, 1800, this, "Al dente", EnumRestaurant.ITALIEN));
            lieux.Add(new Restaurant(3200, 3600, this, "Le coq au vin", EnumRestaurant.FRANCAIS));
            lieux.Add(new Restaurant(2600, 600, this, "Douceur lotus", EnumRestaurant.ASIATIQUE));
            // ECOLES
            lieux.Add(new Ecole(1200, 600, this, "Lycée georges clemenceau", EnumEcole.LYCEE));
            lieux.Add(new Ecole(1800, 600, this, "Ecole primaire francois mitterand", EnumEcole.PRIMAIRE));
            lieux.Add(new Ecole(1800, 800, this, "Maternelle du soleil", EnumEcole.MATERNELLE));
            lieux.Add(new Ecole(1000, 1000, this, "College Jules Ferry", EnumEcole.COLLEGE));
        }
    }
}