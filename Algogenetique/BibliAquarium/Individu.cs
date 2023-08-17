using BibliVille.Lieux;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliVille
{
    public class Individu : EvaluableVisiteur
    {
        private double score;
        private Coordonees coordonees;


        public Coordonees Position { get => coordonees; }

        public Generation GenerationFrom => generationFrom;

        private bool estProcheTransport;
        private bool estProcheEcoleMaternelle;
        private bool estProcheEcolePrimaire;
        private bool estProcheCollege;
        private bool estProcheLycee;
        private bool estProcheUniversite;
        private bool estProcheRestaurant;
        private readonly Generation generationFrom;

        public Individu(Coordonees _coordonees, Generation _from)
        {
            coordonees = _coordonees;
            score = 0;


        }

        public override void VisiterEcole(Ecole e)
        {
           
            if (coordonees.GetDstFrom(e.Coordonees) <= generationFrom.ProcheDistanceMax)
            {
                switch (e.Type)
                {
                    case EnumEcole.MATERNELLE:
                        if (!estProcheEcoleMaternelle) { 
                            score += generationFrom.ScoreProcheEcoleMaternelle;
                            estProcheEcoleMaternelle = true;
                        }
                        break;
                    case EnumEcole.PRIMAIRE:
                        if (!estProcheEcolePrimaire)
                        {
                            score += generationFrom.ScoreProcheEcolePrimaire;
                            estProcheEcolePrimaire = true;
                        }
                        break;
                    case EnumEcole.COLLEGE:
                        if (!estProcheCollege)
                        {
                            score += generationFrom.ScoreProcheCollege;
                            estProcheCollege = true;
                        }
                        break;
                    case EnumEcole.LYCEE:
                        if (!estProcheLycee)
                        {
                            score += generationFrom.ScoreProcheLycee;
                            estProcheLycee = true;
                        }
                        break;
                    case EnumEcole.UNIVERSITE:
                        if (!estProcheUniversite)
                        {
                            score += generationFrom.ScoreProcheLycee;
                            estProcheUniversite = true;
                        }
                        break;

                }
            }
        }

        public override void VisiterRestaurant(Restaurant r)
        {
            if (coordonees.GetDstFrom(r.Coordonees) <= generationFrom.ProcheDistanceMax)
            {
                if (!estProcheRestaurant)
                {
                    estProcheRestaurant = true;
                    score += generationFrom.ScoreProcheRestaurant;
                }
            }
        }

        public override void VisiterTransport(Transport t)
        {
            if (coordonees.GetDstFrom(t.Coordonees) <= generationFrom.ProcheDistanceMax)
            {
                if (!estProcheTransport)
                {
                    estProcheTransport = true;
                    score += generationFrom.ScoreProcheTransport;
                }
            }
        }

        public override double GetScore() => score;
    }
}
