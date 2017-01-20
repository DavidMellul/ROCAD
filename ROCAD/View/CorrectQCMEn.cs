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
    public partial class CorrectQCMEn : Form
    {
        public CorrectQCMEn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CorrectTermineeEn cEn = new CorrectTermineeEn();
            cEn.Show();
        }

        private void CorrectQCMEn_Load(object sender, EventArgs e)
        {

        }
    }
}
