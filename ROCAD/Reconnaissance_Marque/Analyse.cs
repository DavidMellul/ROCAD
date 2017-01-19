using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using OtsuThreshold;
using ROCAD.Reconnaissance_Marque;

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
                for (int x = ZonePixel.X; x < ZonePixel.Width + ZonePixel.X; x++)
                {
                    binaryColor.Add(studentCopy.getStudentCopy().GetPixel(x, y));
                }
            }

            return binaryColor;
        }

        public double getPercentageBlackBox(List<Color> binaryColor)
        {
            Color blackColor = Color.FromArgb(0, 0, 0);
            int countBlackPixel = 0;
            double percentageBlackPixel = 0;

            foreach (Color c in binaryColor)
            {
                if (c.R.Equals(0) && c.G.Equals(0) && c.B.Equals(0))
                {
                    countBlackPixel += 1;
                }
            }

            percentageBlackPixel = (((double)countBlackPixel / binaryColor.Count)) * 100;



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
            List<Color> r = getColorPixel(this.copieEtudiant, zoneCase);
            double pourcentNoir = getPercentageBlackBox(r);

            if (pourcentNoir >= ZoneNumeroEtudiant.seuilNoirceur) {
                return true;
            }

            return false;

        }


        public int getNumeroSujetCopie(CopyOtsu copieEtudiant)
        {

            Dictionary<Case, List<Color>> caseCouleurs = new Dictionary<Case, List<Color>>();

            for (int x = 12 * (Case.HEIGHT); x > 0; x -= (Case.HEIGHT)){
                for (int y = Case.HEIGHT; y >= 0; y -= (Case.HEIGHT))
                {
                    caseCouleurs.Add(new Case(), this.getColorPixel(copieEtudiant, new Rectangle(ZoneNumSujet.X + (12 * Case.HEIGHT) - (x + 1), ZoneNumSujet.Y + y, Case.HEIGHT, Case.WIDTH)));
                }

            }

            List<int> caseBinarys = new List<int>();
            Dictionary<int, int> premiereCases = new Dictionary<int, int>();


            foreach (KeyValuePair<Case, List<Color>> caseColor in caseCouleurs){

                if (this.getPercentageBlackBox(caseColor.Value) > ZoneNumeroEtudiant.seuilNoirceur)
                {
                    caseBinarys.Add(1);

                }
                else
                {
                    caseBinarys.Add(0);
                }

            }

            int nombreMaxSujet = 0;
            int p = 11;

            for (int i = 0; i <= (caseBinarys.Count - 1); i += 2) {

                premiereCases.Add(p, caseBinarys[i + 1]);
                p--;

            }


            foreach (KeyValuePair<int, int> numCases in premiereCases)  {
                if (numCases.Value == 1)
                {
                    nombreMaxSujet += (int)Math.Pow(2, numCases.Key);

                }

            }

            return nombreMaxSujet;

        }

        public int getNombreMaxPage(CopyOtsu copieEtudiant) {

            Dictionary<Case, List<Color>> caseCouleurs = new Dictionary<Case, List<Color>>();

            for (int x = 12 * (Case.HEIGHT); x > 0; x -= (Case.HEIGHT))
            {
                for (int y = Case.HEIGHT; y >= 0; y -= (Case.HEIGHT))
                {

                    caseCouleurs.Add(new Case(), this.getColorPixel(copieEtudiant, new Rectangle(ZoneNumSujet.X + (12 * Case.HEIGHT) - (x + 1), ZoneNumSujet.Y + y, Case.HEIGHT, Case.WIDTH)));
                }

            }

            List<int> caseBinarys = new List<int>();
            Dictionary<int, int> deuxiemeCases = new Dictionary<int, int>();

            foreach (KeyValuePair<Case, List<Color>> caseColor in caseCouleurs)  {

                if (this.getPercentageBlackBox(caseColor.Value) > ZoneNumeroEtudiant.seuilNoirceur)
                {
                    caseBinarys.Add(1);

                }
                else
                {
                    caseBinarys.Add(0);
                }

            }

            int nombreMaxPage = 0;
            int p = 11;

            for (int i = 0; i <= (caseBinarys.Count - 1); i += 2)
            {
                deuxiemeCases.Add(p, caseBinarys[i]);
                p--;

            }

            foreach (KeyValuePair<int, int> numCases1 in deuxiemeCases)
            {
                if (numCases1.Value == 1)
                {
                    nombreMaxPage += (int)Math.Pow(2, numCases1.Key);

                }

            }

            return nombreMaxPage;
        }

   


}
      

}


