using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ROCAD.View
{
    public partial class creationQcmFr : Form
    {
        public creationQcmFr()
        {
            InitializeComponent();
            initialiserCouleursDark();
            if (!mainWindow.isDark)
                initialiserCouleursLight();
        }



        private void NomMatiere_TextChanged(object sender, EventArgs e)
        {

        }

        private void NBQuestions_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Date_TextChanged(object sender, EventArgs e)
        {

        }

        private void Duree_TextChanged(object sender, EventArgs e)
        {

        }

        private void NomEnseignant_TextChanged(object sender, EventArgs e)
        {

        }

        private void TitreQCM_TextChanged(object sender, EventArgs e)
        {

        }

        private void creationQcmFr_Load(object sender, EventArgs e)
        {

        }

        public void initialiserCouleursDark()
        {

            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.button1.ForeColor = System.Drawing.Color.Linen;
            this.progressBarCreaQcm.ForeColor = System.Drawing.Color.HotPink;
            this.nbQuestionsUpDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.nbQuestionsUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validerCreaQcmButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.validerCreaQcmButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.validerCreaQcmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validerCreaQcmButton.ForeColor = System.Drawing.Color.Linen;
            this.dureeTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.dureeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dureeLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.dateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nbQuestionsLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomMatiereTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.nomMatiereTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomMatiereLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titreQcmTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.titreQcmTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titreQcmLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomEnseignantTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.nomEnseignantTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomEnseignantLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windowTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windowTitleLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
        }

        public void initialiserCouleursLight()
        {
            this.button1.ForeColor = Color.Black;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(186)))), ((int)(((byte)(186)))));
            this.progressBarCreaQcm.ForeColor = System.Drawing.Color.HotPink;
            this.nbQuestionsUpDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.nbQuestionsUpDown.ForeColor = Color.Black;
            this.validerCreaQcmButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.validerCreaQcmButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(186)))), ((int)(((byte)(186)))));
            this.validerCreaQcmButton.ForeColor = Color.Black;
            this.dureeTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dureeTextBox.ForeColor = Color.Black;
            this.dureeLabel.ForeColor = Color.Black;
            this.dateTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dateTextBox.ForeColor = Color.Black;
            this.dateLabel.ForeColor = Color.Black;
            this.nbQuestionsLabel.ForeColor = Color.Black;
            this.nomMatiereTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.nomMatiereTextBox.ForeColor = Color.Black;
            this.nomMatiereLabel.ForeColor = Color.Black;
            this.titreQcmTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.titreQcmTextBox.ForeColor = Color.Black;
            this.titreQcmLabel.ForeColor = Color.Black;
            this.nomEnseignantTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.nomEnseignantTextBox.ForeColor = Color.Black;
            this.nomEnseignantLabel.ForeColor = Color.Black;
            this.windowTitleLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));

        }

        private void validerCreaQcmButton_Click(object sender, EventArgs e)
        {
            creaQcmWindow2 cq2 = new creaQcmWindow2();
            this.Hide();
            cq2.Show();
        }

        private void windowTitleLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
