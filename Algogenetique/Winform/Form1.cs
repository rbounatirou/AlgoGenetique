using BibliVille;

namespace Winform
{
    public partial class Form1 : Form
    {
        private Ville ville;
        private VisiteurWinform visiteur;
        private List<Generation> generations;
        public Form1()
        {
            InitializeComponent();
            ville = new Ville(4000, 4000);
            visiteur = new VisiteurWinform(panelDessin, true, true, true, panelDessin.Width / (double)ville.W, (double)panelDessin.Size.Height / ville.H);
            generations = new List<Generation>();
        }



        private void panelDessin_Paint(object sender, PaintEventArgs e)
        {
            visiteur.Dessiner(e.Graphics, ville);
            double[] scale = { panelDessin.Width / (double)ville.W, (double)panelDessin.Size.Height / ville.H };
            if (generations.Count() > 0)
            {
                for (int indice = 0; indice < generations.Last().Individus.Count(); indice++)
                {
                    Individu i = generations.Last().Individus[indice];

                    e.Graphics.FillRectangle(new SolidBrush(indice != 0 ? Color.Black : Color.Violet), new Rectangle((int)(scale[0] * i.Position.X - 2),
                        (int)(scale[1] * i.Position.Y - 2),
                        5, 5));
                    e.Graphics.FillEllipse(new SolidBrush(Color.FromArgb(10, Color.Red)), new Rectangle(
                        (int)(scale[0] * (i.Position.X - (generations.Last().ProcheDistanceMax))),
                        (int)(scale[1] * (i.Position.Y - (generations.Last().ProcheDistanceMax))),
                        (int)(generations.Last().ProcheDistanceMax * 2 * scale[0]),
                        (int)(generations.Last().ProcheDistanceMax * 2 * scale[1])));
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Generation generationAjoute;
            if (generations.Count() > 0)
                generationAjoute = new Generation(generations.Last());
            else
                generationAjoute = new Generation(ville, 20, (int)numericUpDownMutatePercent.Value, (double)numericUpDownDst.Value, (double)numericUpDownTransport.Value,
                    (double)numericUpDownMaternelle.Value, (double)numericUpDownPrimaire.Value, (double)numericUpDownCollege.Value,
                    (double)numericUpDownLycee.Value, (double)numericUpDownUniversite.Value, (double)numericUpDownRestaurant.Value); ;
            generations.Add(generationAjoute);
            panelDessin.Refresh();
            Individu i = generations.Last().Individus[0];
            labelMeilleurScore.Text = String.Format("S= {0}, ({1} ; {2}), ", i.GetScore(), i.Position.X, i.Position.Y);

        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chk = sender as CheckBox;
            switch(Convert.ToInt32(chk.Tag))
            {
                case 0:
                    visiteur.DessinerTransport = chk.Checked;
                    break;
                case 1:
                    visiteur.DessinerRestaurant = chk.Checked;
                    break;
                case 2:
                    visiteur.DessinerEcole = chk.Checked;
                    break;
            }
            panelDessin.Refresh();
        }
    }
}