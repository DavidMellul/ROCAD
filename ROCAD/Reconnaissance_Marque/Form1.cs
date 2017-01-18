using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PT_Lot4
{
    public partial class Form1 : Form
    {

        CopyOtsu copieEtudiant = new CopyOtsu(); // Copie de l'étudiant
        Analyse analyseCopie = new Analyse();


        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
     /*       OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "All files (*.*)|*.*";
*/

        //    if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(Bitmap.FromFile("BD.jpg"));

            }

            copieEtudiant.setStudentCopy(new Bitmap(Bitmap.FromFile("BD.jpg")));
            copieEtudiant.convertirImageBinaire(); // Conversion de l'image en couleur en image binaire
            pictureBox1.Image = copieEtudiant.getStudentCopy();
           

        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

    
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Ajout de la copie à analyser
            analyseCopie.setCopie(copieEtudiant);

            // Dessin des rectangles mais facultatif c'était juste pour vérifier que les rectangles étaient bien positionnés
            Graphics g = pictureBox1.CreateGraphics();
            Pen pen = new Pen(Color.Black, 1);
            g.DrawRectangle(pen, ZoneNumeroEtudiant.X, ZoneNumeroEtudiant.Y, ZoneNumeroEtudiant.HEIGHT, ZoneNumeroEtudiant.WIDTH);


            int numeroEtudiant = analyseCopie.getNumeroEtudiant(copieEtudiant);

            textBox1.Text = numeroEtudiant.ToString();
        }
    }
}
