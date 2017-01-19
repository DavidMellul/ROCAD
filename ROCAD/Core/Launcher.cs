
using System;
using System.Collections.Generic;
using System.Diagnostics;
using ROCAD.Controller;
using ROCAD.Model;
using ROCAD.View;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PT_Lot4;


namespace ROCAD.Core
{
    internal class Launcher
    {
        public static void Main(string[] args)
        {
            String title = "DS_deSaumon";
            String path = title + "";
            Project p_load = Project.load(path);

           MarkRecognizer.analyzeSheet(p_load.subjectList()[0], p_load.title());


/*
*/
/*
                Response rPossible1 = new Response("A");
                Response rPossible2 = new Response("B");
                Response rPossible3 = new Response("C");
                Response rPossible4 = new Response("D");

                List<Response> lrQuestionPossible = new List<Response>();
                lrQuestionPossible.Add(rPossible1);
                lrQuestionPossible.Add(rPossible2);
                lrQuestionPossible.Add(rPossible3);
                lrQuestionPossible.Add(rPossible4);

                List<Response> lrQuestionBonne = new List<Response>();
                lrQuestionBonne.Add(rPossible2);


                Question qEtudiant = new Question("MAMENE ??? TRES SALE? ", 5, 5, lrQuestionPossible, lrQuestionBonne);

                List<Question> listeQuestionsSujet = new List<Question>();
                listeQuestionsSujet.Add(qEtudiant);


                Student stu = new Student("21502022", new List<Question>());
                Subject s = new Subject(listeQuestionsSujet, stu);


                Project p = new Project("Denis Pallez", "BD", s, "60", "18/01/2017");
                p.addStudent(stu);
                p.setOriginalSubject(s);

                List<Student> l = new List<Student>();
                l.Add(stu);


                   PDFHandler pdf = new PDFHandler();
                   pdf.initDocumentCreation(p);
                   pdf.generateSheets();
            p.save(path);
            pdf.pdfToBmp(p.title());

*/

            /*  MarkRecognizer.analyzeSheet(p.subjectList()[0],"BD");
              ExportationHandler.exportAsCsv(l, p.title()+".xlsx");
*/

            /*    Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form5());
    */
        }
    }
}
