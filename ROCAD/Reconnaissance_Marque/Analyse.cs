using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using OtsuThreshold;

namespace PT_Lot4
{
    class Analyse
    {
        private CopyOtsu copieEtudiant;

        public Analyse()
        {

        }

        public Analyse(CopyOtsu copieEtudiant)
        {
            this.copieEtudiant = copieEtudiant;
        }

        public List<Color> getColorPixel(CopyOtsu studentCopy, Rectangle ZonePixel)
        {
            List<Color> binaryColor = new List<Color>();

            for (int y = ZonePixel.Y; y < ZonePixel.Height + ZonePixel.Y; y++)
            {
                for (int x = ZonePixel.X; x < ZonePixel.Width+ZonePixel.X; x++)
                {
                    binaryColor.Add(studentCopy.getStudentCopy().GetPixel(x, y));
                }
            }

            return binaryColor;
        }

        public double getPercentageBlackBox(List<Color> binaryColor)
        {
            Color blackColor = Color.FromArgb(0, 0, 0);
            int countBlackPixel=0;
            double percentageBlackPixel=0;

            foreach (Color c in binaryColor)
            {
                if(c.R.Equals(0) && c.G.Equals(0)  && c.B.Equals(0))
                {
                    countBlackPixel += 1;
                }
            }

           percentageBlackPixel = (((double)countBlackPixel/binaryColor.Count))*100;
            
           

            return percentageBlackPixel;

        }

        public Bitmap resizeImage(Bitmap bitmap, Size size)
        {
            Bitmap image = new Bitmap(size.Width, size.Height);

            return image;
        }

        public void setCopie(CopyOtsu copieEtudiant) {
            this.copieEtudiant = copieEtudiant;
        }
        
       
        public int getNumeroEtudiant(CopyOtsu copieEtudiant) {

            //Creation du dictionnaire qui servira à connaître toutes les couleurs de chaque case de la grille du numero d'etudiant
            Dictionary<Case, List<Color>> caseCouleurs = new Dictionary<Case, List<Color>>();

            // Ajouter dans un dictionnaire la liste de couleurs de chaque case
            for (int x = 0; x <= 9 * ZoneNumeroEtudiant.distanceDeuxCases; x += ZoneNumeroEtudiant.distanceDeuxCases) // la distance entre deux cases est toujours la même on peut donc en déduire la position de chaque case
            {
                for (int y = 0; y <= 9 * ZoneNumeroEtudiant.distanceDeuxCases; y += ZoneNumeroEtudiant.distanceDeuxCases)
                {
                    
                    caseCouleurs.Add(new Case(), this.getColorPixel(copieEtudiant, new Rectangle(ZoneNumeroEtudiant.X + x, ZoneNumeroEtudiant.Y + y, Case.HEIGHT, Case.WIDTH)));
                }

            }

            //Creation du dictionnaire qui servira à ajouter toutes les cases remplis selon le seuil de noirceur défini
            Dictionary<int, int> caseBinarys = new Dictionary<int, int>();

            int numeroCase = 0;

            // Ajouter dans le dictionnaire toutes les cases remplis selon le seuil de noirceur défini
            foreach (KeyValuePair<Case, List<Color>> caseColor in caseCouleurs)
            {

                if (this.getPercentageBlackBox(caseColor.Value) >= ZoneNumeroEtudiant.seuilNoirceur)
                {
                    caseBinarys.Add(numeroCase, 1);

                }

                numeroCase++;
            }


            String numeroEtudiant = "0";
 
            foreach (KeyValuePair<int, int> caseColor in caseBinarys)
            {
                numeroEtudiant += (caseColor.Key) % 10;
            }

            int numEtudiant = Convert.ToInt32(numeroEtudiant);
            return numEtudiant;

        }

        public Boolean isChecked(Rectangle zoneCase) {
            List<Color> r = getColorPixel(this.copieEtudiant,zoneCase);
            double pourcentNoir = getPercentageBlackBox(r);

            if(pourcentNoir >= ZoneNumeroEtudiant.seuilNoirceur ){
                return true;
            }

            return false;

        }

    }
      

}


