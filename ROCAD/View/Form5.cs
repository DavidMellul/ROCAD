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
    public partial class Form5 : Form
    {
        Settings s1 = new Settings();
        Form8 f8 = new Form8();
        Form6 f6 = new Form6();


        public Form5()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            new Form6().Show();
        }


        private void creerQCM_MouseOver(object sender, EventArgs e)
        {
            creerQCM.ForeColor = Color.OrangeRed;
        }

        private void creerQCM_MouseLeaver(object sender, EventArgs e)
        {
            creerQCM.ForeColor = Color.Silver;
        }

        private void correctQCM_MouseOver(object sender, EventArgs e)
        {
            correctQCM.ForeColor = Color.OrangeRed;
        }

        private void correctQCM_MouseLeaver(object sender, EventArgs e)
        {
            correctQCM.ForeColor = Color.Silver;
        }

        private void open_MouseOver(object sender, EventArgs e)
        {
            openQCM.ForeColor = Color.OrangeRed;
        }

        private void openQCM_MouseLeaver(object sender, EventArgs e)
        {
            openQCM.ForeColor = Color.Silver;
        }

        private void settings_MouseOver(object sender, EventArgs e)
        {
            settings.ForeColor = Color.OrangeRed;
        }

        private void settings_MouseLeaver(object sender, EventArgs e)
        {
            settings.ForeColor = Color.Silver;
        }

        private void help_MouseOver(object sender, EventArgs e)
        {
            help.ForeColor = Color.OrangeRed;
        }

        private void help_MouseLeaver(object sender, EventArgs e)
        {
            help.ForeColor = Color.Silver;
        }

        private void button5_Click(object sender, EventArgs e)
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

        private void button7_Click(object sender, EventArgs e)
        {
            new Form8().Show();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void settings_Click(object sender, EventArgs e)
        {
            new Settings().Show();
        }
    }
}
