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
    public partial class Form8 : Form
    {
        public Timer timer1 = new Timer();

        public Form8()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            metroProgressBar1.Value = metroProgressBar1.Maximum;
            Form9 f9 = new Form9();
            f9.Show();

        }

        void timer1_Tick(object sender, EventArgs e)
        {
          
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }
    }
}
