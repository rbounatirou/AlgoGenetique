using BibliVille;
using BibliVille.Lieux;

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
            numericUpDownAjoutLieuX.Maximum = ville.W;
            numericUpDownAjoutLieuY.Maximum = ville.H;
        }



        private void panelDessin_Paint(object sender, PaintEventArgs e)
        {
            visiteur.Dessiner(e.Graphics, ville);
            double[] scale = { panelDessin.Width / (double)ville.W, (double)panelDessin.Size.Height / ville.H };
            int gen = (int)numericUpDownSelectionGeneration.Value;
            if (gen < generations.Count())
            {
                Generation observe = generations[gen];
                for (int indice = 0; indice < observe.Individus.Count(); indice++)
                {
                    Individu i = observe.Individus[indice];

                    e.Graphics.FillRectangle(new SolidBrush(indice != 0 ? Color.Black : Color.Violet),
                        new Rectangle((int)(scale[0] * i.Position.X - 2),
                        (int)(scale[1] * i.Position.Y - 2),
                        5, 5));
                    e.Graphics.FillEllipse(new SolidBrush(Color.FromArgb(10, Color.Red)), new Rectangle(
                        (int)(scale[0] * (i.Position.X - (observe.ProcheDistanceMax))),
                        (int)(scale[1] * (i.Position.Y - (observe.ProcheDistanceMax))),
                        (int)(observe.ProcheDistanceMax * 2 * scale[0]),
                        (int)(observe.ProcheDistanceMax * 2 * scale[1])));
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


            buttonResetGenerations.Enabled = true;

            numericUpDownSelectionGeneration.Maximum = generations.Count() - 1;
            numericUpDownSelectionGeneration.Value = numericUpDownSelectionGeneration.Maximum;
            MajIHM();

        }

        private void MajIHM()
        {
            comboBoxType.Enabled = radioButtonEcole.Checked || radioButtonRestaurant.Checked;
            numericUpDownSelectionGeneration.Enabled = generations.Count() >= 2;
            groupBoxGeneration.Enabled = generations.Count() == 0;
            groupBoxScore.Enabled = generations.Count() == 0;
            int gen = (int)numericUpDownSelectionGeneration.Value;
            if (generations.Count > 0)
            {
                Individu i = generations[gen].Individus[0];
                labelMeilleurScore.Text = String.Format("Gen N°{0} S= {1}, ({2} ; {3}), ", gen + 1, i.GetScore(), i.Position.X, i.Position.Y);
            }
            else
            {
                labelMeilleurScore.Text = "-";
            }
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chk = sender as CheckBox;
            switch (Convert.ToInt32(chk.Tag))
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

        private void buttonResetGenerations_Click(object sender, EventArgs e)
        {

            groupBoxGeneration.Enabled = true;
            groupBoxScore.Enabled = true;
            generations.Clear();
            buttonResetGenerations.Enabled = false;
            panelDessin.Refresh();
            numericUpDownSelectionGeneration.Value = 0;
            numericUpDownSelectionGeneration.Maximum = 0;
            MajIHM();
        }



        private void numericUpDownSelectionGeneration_ValueChanged(object sender, EventArgs e)
        {
            MajIHM();
            panelDessin.Refresh();
        }


        private void loadComboEcole() => loadComboEnum<EnumEcole>();

        private void loadComboRestaurant() => loadComboEnum<EnumRestaurant>();

        private void radioButtonEcole_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton from = sender as RadioButton;
            switch (Convert.ToInt32(from.Tag))
            {
                case 0:
                    comboBoxType.Items.Clear();
                    break;
                case 1:
                    loadComboRestaurant();
                    break;
                case 2:
                    loadComboEcole();
                    break;
            }
            MajIHM();
        }

        private void buttonAjouterLieu_Click(object sender, EventArgs e)
        {
            if (radioButtonEcole.Checked)
            {
                ville.AddLieu(new Ecole(new Coordonees((ushort)numericUpDownAjoutLieuX.Value,
                    (ushort)numericUpDownAjoutLieuY.Value, ville), textBoxAjoutLieuNom.Text, (EnumEcole)comboBoxType.SelectedItem));
            }
            else if (radioButtonRestaurant.Checked)
            {
                ville.AddLieu(new Restaurant(new Coordonees((ushort)numericUpDownAjoutLieuX.Value,
                    (ushort)numericUpDownAjoutLieuY.Value, ville), textBoxAjoutLieuNom.Text, (EnumRestaurant)comboBoxType.SelectedItem));
            }
            else if (radioButtonTransport.Checked)
            {
                ville.AddLieu(new Transport(new Coordonees((ushort)numericUpDownAjoutLieuX.Value,
                    (ushort)numericUpDownAjoutLieuY.Value, ville), textBoxAjoutLieuNom.Text));
            }
            MajIHM();
            panelDessin.Refresh();
        }

        private void buttonEffacerLieu_Click(object sender, EventArgs e)
        {
            ville.Clear();
            generations.Clear();
            numericUpDownSelectionGeneration.Value = 0;
            numericUpDownSelectionGeneration.Maximum = 0;
            MajIHM();
            panelDessin.Refresh();
            
            
        }

        private void loadComboEnum<T>() where T : Enum
        {
            comboBoxType.Items.Clear();
            List<T> types = Enum.GetValues(typeof(T)).Cast<T>().ToList();
            foreach (T t in types)
            {
                comboBoxType.Items.Add(t);
            }
            comboBoxType.SelectedIndex = 0;
        }

    }
}