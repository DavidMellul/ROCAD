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
    public partial class CorrectTermineeFr : Form
    {
        private string path;

        public CorrectTermineeFr(string path)
        {
            this.path = path;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(this.path+".xlsx");
        }

        private void CorrectTermineeFr_Load(object sender, EventArgs e)
        {

        }
    }
}
