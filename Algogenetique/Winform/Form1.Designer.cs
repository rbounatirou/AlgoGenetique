namespace Winform
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panelDessin = new Panel();
            checkBoxTransport = new CheckBox();
            checkBoxRestaurant = new CheckBox();
            checkBoxEcole = new CheckBox();
            numericUpDownTransport = new NumericUpDown();
            numericUpDownMaternelle = new NumericUpDown();
            numericUpDownPrimaire = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            generation = new GroupBox();
            label9 = new Label();
            numericUpDownRestaurant = new NumericUpDown();
            label7 = new Label();
            numericUpDownUniversite = new NumericUpDown();
            label6 = new Label();
            numericUpDownLycee = new NumericUpDown();
            label5 = new Label();
            numericUpDownCollege = new NumericUpDown();
            label4 = new Label();
            numericUpDownMutatePercent = new NumericUpDown();
            label8 = new Label();
            è = new GroupBox();
            numericUpDownDst = new NumericUpDown();
            label11 = new Label();
            button1 = new Button();
            label10 = new Label();
            labelMeilleurScore = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            ((System.ComponentModel.ISupportInitialize)numericUpDownTransport).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMaternelle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrimaire).BeginInit();
            generation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRestaurant).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownUniversite).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownLycee).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCollege).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMutatePercent).BeginInit();
            è.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDst).BeginInit();
            SuspendLayout();
            // 
            // panelDessin
            // 
            panelDessin.Location = new Point(12, 12);
            panelDessin.Name = "panelDessin";
            panelDessin.Size = new Size(800, 800);
            panelDessin.TabIndex = 0;
            panelDessin.Paint += panelDessin_Paint;
            // 
            // checkBoxTransport
            // 
            checkBoxTransport.AutoSize = true;
            checkBoxTransport.Checked = true;
            checkBoxTransport.CheckState = CheckState.Checked;
            checkBoxTransport.Location = new Point(12, 833);
            checkBoxTransport.Name = "checkBoxTransport";
            checkBoxTransport.Size = new Size(112, 29);
            checkBoxTransport.TabIndex = 0;
            checkBoxTransport.Tag = "0";
            checkBoxTransport.Text = "Transport";
            checkBoxTransport.UseVisualStyleBackColor = true;
            checkBoxTransport.CheckedChanged += checkBox_CheckedChanged;
            // 
            // checkBoxRestaurant
            // 
            checkBoxRestaurant.AutoSize = true;
            checkBoxRestaurant.Checked = true;
            checkBoxRestaurant.CheckState = CheckState.Checked;
            checkBoxRestaurant.Location = new Point(139, 833);
            checkBoxRestaurant.Name = "checkBoxRestaurant";
            checkBoxRestaurant.Size = new Size(121, 29);
            checkBoxRestaurant.TabIndex = 1;
            checkBoxRestaurant.Tag = "1";
            checkBoxRestaurant.Text = "Restaurant";
            checkBoxRestaurant.UseVisualStyleBackColor = true;
            checkBoxRestaurant.CheckedChanged += checkBox_CheckedChanged;
            // 
            // checkBoxEcole
            // 
            checkBoxEcole.AutoSize = true;
            checkBoxEcole.Checked = true;
            checkBoxEcole.CheckState = CheckState.Checked;
            checkBoxEcole.Location = new Point(266, 833);
            checkBoxEcole.Name = "checkBoxEcole";
            checkBoxEcole.Size = new Size(79, 29);
            checkBoxEcole.TabIndex = 2;
            checkBoxEcole.Tag = "2";
            checkBoxEcole.Text = "Ecole";
            checkBoxEcole.UseVisualStyleBackColor = true;
            checkBoxEcole.CheckedChanged += checkBox_CheckedChanged;
            // 
            // numericUpDownTransport
            // 
            numericUpDownTransport.Location = new Point(248, 31);
            numericUpDownTransport.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownTransport.Name = "numericUpDownTransport";
            numericUpDownTransport.Size = new Size(180, 31);
            numericUpDownTransport.TabIndex = 3;
            numericUpDownTransport.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // numericUpDownMaternelle
            // 
            numericUpDownMaternelle.Location = new Point(248, 71);
            numericUpDownMaternelle.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownMaternelle.Name = "numericUpDownMaternelle";
            numericUpDownMaternelle.Size = new Size(180, 31);
            numericUpDownMaternelle.TabIndex = 4;
            numericUpDownMaternelle.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // numericUpDownPrimaire
            // 
            numericUpDownPrimaire.Location = new Point(248, 111);
            numericUpDownPrimaire.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownPrimaire.Name = "numericUpDownPrimaire";
            numericUpDownPrimaire.Size = new Size(180, 31);
            numericUpDownPrimaire.TabIndex = 5;
            numericUpDownPrimaire.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 37);
            label1.Name = "label1";
            label1.Size = new Size(132, 25);
            label1.TabIndex = 7;
            label1.Text = "score transport";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 77);
            label2.Name = "label2";
            label2.Size = new Size(187, 25);
            label2.TabIndex = 8;
            label2.Text = "score ecole maternelle";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 111);
            label3.Name = "label3";
            label3.Size = new Size(170, 25);
            label3.TabIndex = 9;
            label3.Text = "score ecole primaire";
            // 
            // generation
            // 
            generation.Controls.Add(label9);
            generation.Controls.Add(numericUpDownRestaurant);
            generation.Controls.Add(label7);
            generation.Controls.Add(numericUpDownUniversite);
            generation.Controls.Add(label6);
            generation.Controls.Add(numericUpDownLycee);
            generation.Controls.Add(label5);
            generation.Controls.Add(numericUpDownCollege);
            generation.Controls.Add(label4);
            generation.Controls.Add(label1);
            generation.Controls.Add(label3);
            generation.Controls.Add(numericUpDownTransport);
            generation.Controls.Add(label2);
            generation.Controls.Add(numericUpDownMaternelle);
            generation.Controls.Add(numericUpDownPrimaire);
            generation.Location = new Point(832, 12);
            generation.Name = "generation";
            generation.Size = new Size(434, 306);
            generation.TabIndex = 10;
            generation.TabStop = false;
            generation.Text = "groupBox1";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(108, 343);
            label9.Name = "label9";
            label9.Size = new Size(0, 25);
            label9.TabIndex = 20;
            // 
            // numericUpDownRestaurant
            // 
            numericUpDownRestaurant.Location = new Point(248, 262);
            numericUpDownRestaurant.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownRestaurant.Name = "numericUpDownRestaurant";
            numericUpDownRestaurant.Size = new Size(180, 31);
            numericUpDownRestaurant.TabIndex = 17;
            numericUpDownRestaurant.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 268);
            label7.Name = "label7";
            label7.Size = new Size(138, 25);
            label7.TabIndex = 16;
            label7.Text = "score restaurant";
            // 
            // numericUpDownUniversite
            // 
            numericUpDownUniversite.Location = new Point(248, 225);
            numericUpDownUniversite.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownUniversite.Name = "numericUpDownUniversite";
            numericUpDownUniversite.Size = new Size(180, 31);
            numericUpDownUniversite.TabIndex = 15;
            numericUpDownUniversite.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 231);
            label6.Name = "label6";
            label6.Size = new Size(180, 25);
            label6.TabIndex = 14;
            label6.Text = "score ecole universite";
            // 
            // numericUpDownLycee
            // 
            numericUpDownLycee.Location = new Point(248, 187);
            numericUpDownLycee.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownLycee.Name = "numericUpDownLycee";
            numericUpDownLycee.Size = new Size(180, 31);
            numericUpDownLycee.TabIndex = 13;
            numericUpDownLycee.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 193);
            label5.Name = "label5";
            label5.Size = new Size(144, 25);
            label5.TabIndex = 12;
            label5.Text = "score ecole lycee";
            // 
            // numericUpDownCollege
            // 
            numericUpDownCollege.Location = new Point(248, 147);
            numericUpDownCollege.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownCollege.Name = "numericUpDownCollege";
            numericUpDownCollege.Size = new Size(180, 31);
            numericUpDownCollege.TabIndex = 11;
            numericUpDownCollege.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 153);
            label4.Name = "label4";
            label4.Size = new Size(161, 25);
            label4.TabIndex = 10;
            label4.Text = "score ecole college";
            // 
            // numericUpDownMutatePercent
            // 
            numericUpDownMutatePercent.Location = new Point(275, 60);
            numericUpDownMutatePercent.Name = "numericUpDownMutatePercent";
            numericUpDownMutatePercent.Size = new Size(180, 31);
            numericUpDownMutatePercent.TabIndex = 18;
            numericUpDownMutatePercent.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(33, 62);
            label8.Name = "label8";
            label8.Size = new Size(199, 25);
            label8.TabIndex = 19;
            label8.Text = "Taux mutation pourcent";
            // 
            // è
            // 
            è.Controls.Add(numericUpDownDst);
            è.Controls.Add(label11);
            è.Controls.Add(numericUpDownMutatePercent);
            è.Controls.Add(label8);
            è.Location = new Point(1272, 23);
            è.Name = "è";
            è.Size = new Size(513, 295);
            è.TabIndex = 11;
            è.TabStop = false;
            è.Text = "groupBox1";
            // 
            // numericUpDownDst
            // 
            numericUpDownDst.Location = new Point(275, 110);
            numericUpDownDst.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownDst.Minimum = new decimal(new int[] { 200, 0, 0, 0 });
            numericUpDownDst.Name = "numericUpDownDst";
            numericUpDownDst.Size = new Size(180, 31);
            numericUpDownDst.TabIndex = 20;
            numericUpDownDst.Value = new decimal(new int[] { 600, 0, 0, 0 });
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(33, 112);
            label11.Name = "label11";
            label11.Size = new Size(142, 25);
            label11.TabIndex = 21;
            label11.Text = "Rayon proximite";
            // 
            // button1
            // 
            button1.Location = new Point(846, 347);
            button1.Name = "button1";
            button1.Size = new Size(939, 34);
            button1.TabIndex = 12;
            button1.Text = "Demarrer Generation";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(935, 421);
            label10.Name = "label10";
            label10.Size = new Size(225, 25);
            label10.TabIndex = 13;
            label10.Text = "Meilleur score derniere gen";
            // 
            // labelMeilleurScore
            // 
            labelMeilleurScore.AutoSize = true;
            labelMeilleurScore.Location = new Point(1213, 421);
            labelMeilleurScore.Name = "labelMeilleurScore";
            labelMeilleurScore.Size = new Size(19, 25);
            labelMeilleurScore.TabIndex = 14;
            labelMeilleurScore.Text = "-";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1835, 944);
            Controls.Add(labelMeilleurScore);
            Controls.Add(label10);
            Controls.Add(button1);
            Controls.Add(è);
            Controls.Add(generation);
            Controls.Add(checkBoxEcole);
            Controls.Add(checkBoxTransport);
            Controls.Add(checkBoxRestaurant);
            Controls.Add(panelDessin);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDownTransport).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMaternelle).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrimaire).EndInit();
            generation.ResumeLayout(false);
            generation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRestaurant).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownUniversite).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownLycee).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCollege).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMutatePercent).EndInit();
            è.ResumeLayout(false);
            è.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDst).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelDessin;
        private CheckBox checkBoxTransport;
        private CheckBox checkBoxRestaurant;
        private CheckBox checkBoxEcole;
        private NumericUpDown numericUpDownTransport;
        private NumericUpDown numericUpDownMaternelle;
        private NumericUpDown numericUpDownPrimaire;
        private Label label1;
        private Label label2;
        private Label label3;
        private GroupBox generation;
        private NumericUpDown numericUpDownCollege;
        private Label label4;
        private NumericUpDown numericUpDownRestaurant;
        private Label label7;
        private NumericUpDown numericUpDownUniversite;
        private Label label6;
        private NumericUpDown numericUpDownLycee;
        private Label label5;
        private Label label8;
        private NumericUpDown numericUpDownMutatePercent;
        private Label label9;
        private GroupBox è;
        private Button button1;
        private Label label10;
        private Label labelMeilleurScore;
        private NumericUpDown numericUpDownDst;
        private Label label11;
        private ContextMenuStrip contextMenuStrip1;
    }
}