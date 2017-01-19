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
    public partial class CorrectQCMFr : Form
    {
        public CorrectQCMFr()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Value = progressBar1.Maximum;
            CorrectTermineeFr f4 = new CorrectTermineeFr();
            f4.Show();


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog o1 = new OpenFileDialog();
            o1.Filter = "JPG Files (.jpg)|*.jpg";
            if (o1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.StreamReader sr = new
                   System.IO.StreamReader(o1.FileName);
                MessageBox.Show(sr.ReadToEnd());
                sr.Close();


            }
        }

        private void NomCorrection_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
