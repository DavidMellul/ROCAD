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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            this.Close();
            f7.Show();
        }

        

        private void metroButton2_Click(object sender, EventArgs e)
        {
            if(monthCalendar1.Visible == true)
            {
                monthCalendar1.Visible = false;
            }
            else {
                monthCalendar1.Visible = true;
            }
            
        }


        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            metroTextBox6.Text = monthCalendar1.SelectionRange.Start.ToShortDateString();
        }
    }
}
