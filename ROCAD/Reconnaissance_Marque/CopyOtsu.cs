using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using OtsuThreshold;

namespace PT_Lot4
{
    
    class CopyOtsu
    {
        private Bitmap studentCopy;

        public CopyOtsu()
        {
            

        }


        public CopyOtsu(Bitmap studentCopy)
        {
            this.studentCopy = studentCopy;

        }

        public void convertirImageBinaire()
        {
            Otsu ot = new Otsu();
            ot.Convert2GrayScaleFast(studentCopy);
            int otsuThreshold = ot.getOtsuThreshold((Bitmap)studentCopy);
            ot.threshold(studentCopy, otsuThreshold);
       
        }

        public Bitmap getStudentCopy()
        {
            return this.studentCopy;
        }

        public void setStudentCopy(Bitmap image)
        {
            this.studentCopy = image;
           

        }


    }
}
