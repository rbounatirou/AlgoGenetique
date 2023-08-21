using BibliAquarium;
using BibliVille.Lieux;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliVille
{
    public class Generation
    {
        private List<Individu> individus;
        private readonly Ville ville;
        private int nbIndividuGeneration;
        private int mutationPourcent;
        private readonly double scoreprocheTransport;
        private readonly double scoreProcheEcoleMaternelle;
        private readonly double scoreProcheEcolePrimaire;
        private readonly double scoreProcheCollege;
        private readonly double scoreProcheLycee;
        private readonly double scoreProcheUniversite;
        private readonly double scoreProcheRestaurant;
        private readonly double procheDistanceMax;

        



        public Individu[] Individus { get => individus.ToArray(); }
        public Ville Ville => ville;
        public int NbIndividuGeneration { get => nbIndividuGeneration; }
        public int MutationPourcent { get => mutationPourcent; }
        public double ScoreProcheTransport => scoreprocheTransport;

        public double ScoreProcheEcoleMaternelle => scoreProcheEcoleMaternelle;

        public double ScoreProcheEcolePrimaire => scoreProcheEcolePrimaire;

        public double ScoreProcheCollege => scoreProcheCollege;

        public double ScoreProcheLycee => scoreProcheLycee;

        public double ScoreProcheUniversite => scoreProcheUniversite;

        public double ScoreProcheRestaurant => scoreProcheRestaurant;

        public double ProcheDistanceMax => procheDistanceMax;


        /// <summary>
        /// Generer une generation depuis une ancienne
        /// </summary>
        /// <param name="from">Generation depuis laquelle le constructeur va se baser</param>
        public Generation(Generation from)
        {
            individus = new List<Individu>();
            ville = from.Ville;
            mutationPourcent = from.MutationPourcent;
            nbIndividuGeneration = from.NbIndividuGeneration;
            mutationPourcent = from.MutationPourcent;
            scoreprocheTransport = from.ScoreProcheTransport;
            scoreProcheEcoleMaternelle = from.ScoreProcheEcoleMaternelle;
            scoreProcheEcolePrimaire = from.ScoreProcheEcolePrimaire;
            scoreProcheCollege = from.ScoreProcheCollege;
            scoreProcheLycee = from.ScoreProcheLycee;
            scoreProcheUniversite = from.ScoreProcheUniversite;
            scoreProcheRestaurant = from.ScoreProcheRestaurant;
            procheDistanceMax = from.ProcheDistanceMax;
            List<Individu> fromindividus = from.Individus.ToList();
            fromindividus.Sort((a,b)=> (int)(a.GetScore() - b.GetScore()));
            fromindividus.Reverse();
            if (fromindividus[0].GetScore() > 0)
            {
                individus.Add(fromindividus[0]);

                for (int i = 1; i < nbIndividuGeneration; i++)
                {
                    // On genere la coordonee en se basant sur un crossover avec la meilleure coordonee de la generation precedente
                    Coordonees crossOver = fromindividus[0].Position.Crossover(fromindividus[i].Position);
                    // On fait muter le crossover avec une probabilité qu'on indique en parametre
                    crossOver.Mutate(mutationPourcent);

                    Individu tmp = new Individu(crossOver,this);
                    individus.Add(tmp);
                }
            } else
            {
                GenererAleatoire();
            }

            // On evalue la nouvelle generation
            Evaluer();
        }

        private void GenererAleatoire()
        {
            for (int i = 0; i < nbIndividuGeneration; i++)
            {
                Coordonees tmpc = new Coordonees((ushort)Alea.GenererAleatoire(0, ville.W),
                    (ushort)Alea.GenererAleatoire(0, ville.H), ville);
                Individu tmp = new Individu(tmpc, this);
                individus.Add(tmp);
            }
        }

        public Generation(Ville _from, int _nbIndividu, int _mutationPourcent, double _procheDstMax = 200, double _scoreProcheTransport = 0,
            double _scoreProcheMaternelle = 0, double _scoreProchePrimaire = 0, double _scoreProcheCollege = 0,
            double _scoreProcheLycee = 0, double _scoreProcheUniversite = 0, double _scoreProcheRestaurant = 0)
        {
            ville = _from;
            mutationPourcent = _mutationPourcent;
            nbIndividuGeneration = _nbIndividu;
            individus = new List<Individu>();
            scoreprocheTransport = _scoreProcheTransport;
            scoreProcheEcoleMaternelle = _scoreProcheMaternelle;
            scoreProcheEcolePrimaire = _scoreProchePrimaire;
            scoreProcheCollege = _scoreProcheCollege;
            scoreProcheLycee = _scoreProcheLycee;
            scoreProcheUniversite = _scoreProcheUniversite;
            scoreProcheRestaurant = _scoreProcheRestaurant;
            procheDistanceMax = _procheDstMax;
            GenererAleatoire();
            Evaluer();
        }

        private void Evaluer()
        {
            foreach (Lieu l in ville.Lieux)
            {
                individus.ForEach(d=> l.AccepterVisite(d));
            }
            individus.Sort((a, b) => (int)(a.GetScore() - b.GetScore()));
            individus.Reverse();

        }
            
    }
}
