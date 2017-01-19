using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ROCAD.View
{
    public partial class mainWindow : Form
    {
        public static bool isFr = false;
        public static bool isDark = true;

        public mainWindow()
        {
            InitializeComponent();
            initiliserTextes();
            initialiserCouleurs();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void creerQCM_MouseOver(object sender, EventArgs e)
        {
            creerQcmButton.ForeColor = Color.OrangeRed;
        }

        private void creerQCM_MouseLeaver(object sender, EventArgs e)
        {
            if(isDark)
                creerQcmButton.ForeColor = Color.Silver;
            else
                creerQcmButton.ForeColor = Color.Black;
        }

        private void correctQCM_MouseOver(object sender, EventArgs e)
        {
            correctQCM.ForeColor = Color.OrangeRed;
        }

        private void correctQCM_MouseLeaver(object sender, EventArgs e)
        {
            if (isDark)
                correctQCM.ForeColor = Color.Silver;
            else
                correctQCM.ForeColor = Color.Black;

        }

        private void open_MouseOver(object sender, EventArgs e)
        {
            openQCM.ForeColor = Color.OrangeRed;
        }

        private void openQCM_MouseLeaver(object sender, EventArgs e)
        {
            if (isDark)
                openQCM.ForeColor = Color.Silver;
            else
                openQCM.ForeColor = Color.Black;
        }

        private void help_MouseOver(object sender, EventArgs e)
        {
            help.ForeColor = Color.OrangeRed;
        }

        private void help_MouseLeaver(object sender, EventArgs e)
        {
            if(isDark)
                help.ForeColor = Color.Silver;
            else
                help.ForeColor = Color.Black;

        }


        public void settings_Click(object sender, EventArgs e)
        {
            settingsWindow sw = new settingsWindow();
            sw.Show();
        }

        public void creerQcmButton_Click(object sender, EventArgs e)
        {
            if(isFr)
            {
                creationQcmFr cqf = new creationQcmFr();
                cqf.Show();
            }
            else
            {
                creationQcmEn cqe = new creationQcmEn();
                cqe.Show();
            }
        }


        private void pictureBox1_Click(object sender, EventArgs args)
        {
            isFr = true;
            changeLangToFr();
        }

        private void pictureBox2_Click(object sender, EventArgs args)
        {
            isFr = false;
            changeLangToEn();
        }

        public void changeLangToFr()
        {
            this.creerQcmButton.Text = "Créer un QCM";
            this.correctQCM.Text = "Corriger";
            this.openQCM.Text = "Ouvrir";
            this.help.Text = "Aide";
        }

        public void changeLangToEn()
        {
            this.creerQcmButton.Text = "Create a MCQ";
            this.correctQCM.Text = "Correct a MCQ";
            this.openQCM.Text = "Open";
            this.help.Text = "Help";
        }

        private void openQCM_Click(object sender, EventArgs e)
        {
            OpenFileDialog o1 = new OpenFileDialog();
            o1.Filter = "Xml Files (.xml)|*.xml";
            if (o1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.StreamReader sr = new
                   System.IO.StreamReader(o1.FileName);
                MessageBox.Show(sr.ReadToEnd());
                sr.Close();


            }
        }

        private void correctQCM_Click(object sender, EventArgs e)
        {

            if (isFr)
            {
                CorrectQCMFr f2 = new CorrectQCMFr();
                f2.Show();
            }
            else
            {
                CorrectQCMEn f2 = new CorrectQCMEn();
                f2.Show();
            }
            
        }

        private void toggleButtonTheme_Click(object sender, EventArgs e)
        {
            changeToggleButtonImg();
        }

        private void toggleButtonLabelS_Click(object sender, EventArgs e)
        {

        }

        public void changeToggleButtonImg()
        {
            if (isDark)
            {
                this.toggleButtonTheme.Image = Image.FromFile(String.Concat(Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "\\Images\\off.png"));
                changeTheme();
                isDark = false;
            }
                else
            {
                this.toggleButtonTheme.Image = Image.FromFile(String.Concat(Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "\\Images\\on.png"));
                changeTheme();
                isDark = true;
            }
        }

        public void changeTheme()
        {
            if (isDark)
            {
                this.accueilPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
                this.pastProjectsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
                this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(145)))), ((int)(((byte)(80)))));
                this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(186)))), ((int)(((byte)(186)))));
                this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(145)))), ((int)(((byte)(80)))));
                this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(186)))), ((int)(((byte)(186)))));
                this.correctQCM.FlatAppearance.BorderColor = System.Drawing.Color.Black;
                this.correctQCM.ForeColor = System.Drawing.Color.Black;
                this.openQCM.FlatAppearance.BorderColor = System.Drawing.Color.Black;
                this.openQCM.ForeColor = System.Drawing.Color.Black;
                this.help.FlatAppearance.BorderColor = System.Drawing.Color.Black;
                this.help.ForeColor = System.Drawing.Color.Black;
                this.creerQcmButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
                this.creerQcmButton.ForeColor = System.Drawing.Color.Black;
                this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
                this.button2.ForeColor = System.Drawing.Color.Black;
                this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
                this.button1.ForeColor = System.Drawing.Color.Black;
                this.toggleButtonLabelS.ForeColor = Color.Black;
            }
                else
            {
                initialiserCouleurs();
            }
        }

        public void initiliserTextes()
        {
            /**
             * Initialiser les Texte
             **/
            this.creerQcmButton.Text = "Create a MCQ";
            this.correctQCM.Text = "Correct a MCQ";
            this.openQCM.Text = "Open";
            this.help.Text = "Help";
        }

        public void initialiserCouleurs()
        {
            this.accueilPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.correctQCM.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.correctQCM.ForeColor = System.Drawing.Color.Silver;
            this.openQCM.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.openQCM.ForeColor = System.Drawing.Color.Silver;
            this.help.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.help.ForeColor = System.Drawing.Color.Silver;
            this.creerQcmButton.ForeColor = System.Drawing.Color.Silver;
            this.pastProjectsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(110)))), ((int)(((byte)(175)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.button2.ForeColor = System.Drawing.Color.Silver;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(110)))), ((int)(((byte)(175)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.button1.ForeColor = System.Drawing.Color.Silver;
            this.toggleButtonLabelS.ForeColor = System.Drawing.Color.Silver;
        }

        private void accueilPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
