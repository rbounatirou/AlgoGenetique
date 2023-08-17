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

        private bool estProcheTransport;
        private bool estProcheEcoleMaternelle;
        private bool estProcheEcolePrimaire;
        private bool estProcheCollege;
        private bool estProcheLycee;
        private bool estProcheUniversite;
        private bool estProcheRestaurant;
        private readonly double scoreprocheTransport;
        private readonly double scoreProcheEcoleMaternelle;
        private readonly double scoreProcheEcolePrimaire;
        private readonly double scoreProcheCollege;
        private readonly double scoreProcheLycee;
        private readonly double scoreProcheUniversite;
        private readonly double scoreProcheRestaurant;
        private readonly double procheDistanceMax;

        public Individu(Coordonees _coordonees, double _procheDistanceMax = 200, double _scoreProcheTransport = 0, double _scoreProcheEcoleMaternelle = 0,
            double _scoreProcheEcolePrimaire = 0, double _scoreProcheCollege = 0, double _scoreProcheLycee = 0, double _scoreProcheUniversite = 0, double _scoreProcheRestaurant = 0)
        {
            coordonees = _coordonees;
            procheDistanceMax = _procheDistanceMax;
            scoreprocheTransport = _scoreProcheTransport;
            score = 0;
            scoreProcheEcoleMaternelle = _scoreProcheEcoleMaternelle;
            scoreProcheEcolePrimaire = _scoreProcheEcolePrimaire;
            scoreProcheCollege = _scoreProcheCollege;
            scoreProcheLycee = _scoreProcheLycee;
            scoreProcheUniversite = _scoreProcheUniversite;
            scoreProcheRestaurant = _scoreProcheRestaurant;
            scoreProcheCollege = _scoreProcheCollege;

        }

        public override void VisiterEcole(Ecole e)
        {
           
            if (coordonees.GetDstFrom(e.Coordonees) <= procheDistanceMax)
            {
                switch (e.Type)
                {
                    case EnumEcole.MATERNELLE:
                        if (!estProcheEcoleMaternelle) { 
                            score += scoreProcheEcoleMaternelle;
                            estProcheEcoleMaternelle = true;
                        }
                        break;
                    case EnumEcole.PRIMAIRE:
                        if (!estProcheEcolePrimaire)
                        {
                            score += scoreProcheEcolePrimaire;
                            estProcheEcolePrimaire = true;
                        }
                        break;
                    case EnumEcole.COLLEGE:
                        if (!estProcheCollege)
                        {
                            score += scoreProcheCollege;
                            estProcheCollege = true;
                        }
                        break;
                    case EnumEcole.LYCEE:
                        if (!estProcheLycee)
                        {
                            score += scoreProcheLycee;
                            estProcheLycee = true;
                        }
                        break;
                    case EnumEcole.UNIVERSITE:
                        if (!estProcheUniversite)
                        {
                            score += scoreProcheUniversite;
                            estProcheUniversite = true;
                        }
                        break;

                }
            }
        }

        public override void VisiterRestaurant(Restaurant r)
        {
            if (coordonees.GetDstFrom(r.Coordonees) <= procheDistanceMax)
            {
                if (!estProcheRestaurant)
                {
                    estProcheRestaurant = true;
                    score += scoreProcheRestaurant;
                }
            }
        }

        public override void VisiterTransport(Transport t)
        {
            if (coordonees.GetDstFrom(t.Coordonees) <= procheDistanceMax)
            {
                if (!estProcheTransport)
                {
                    estProcheTransport = true;
                    score += scoreprocheTransport;
                }
            }
        }

        public override double GetScore() => score;
    }
}
