
using System;
using System.Collections.Generic;
using System.Diagnostics;
using ROCAD.Controller;
using ROCAD.Model;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PT_Lot4;
using ROCAD.View;

namespace ROCAD.Core
{
    internal class Launcher
    {
        [STAThread]
        public static void Main(string[] args)
        {
            String title = "DS_deSaumon";
            String path = title + "";
            //Project p_load = Project.load(path);

          // MarkRecognizer.analyzeSheet(p_load.subjectList()[0], p_load.title());




                Response rPossible1 = new Response("A");
                Response rPossible2 = new Response("B");
                Response rPossible3 = new Response("C");
                Response rPossible4 = new Response("D");

                List<Response> lrQuestionPossible1 = new List<Response>();
                lrQuestionPossible1.Add(rPossible1);
                lrQuestionPossible1.Add(rPossible2);
                lrQuestionPossible1.Add(rPossible3);
                lrQuestionPossible1.Add(rPossible4);

                List<Response> lrQuestionBonne1 = new List<Response>();
                lrQuestionBonne1.Add(rPossible2);


            Response rPossible5 = new Response("E");
            Response rPossible6 = new Response("F");
            Response rPossible7 = new Response("G");
            Response rPossible8 = new Response("H");

            List<Response> lrQuestionPossible2 = new List<Response>();
            lrQuestionPossible2.Add(rPossible5);
            lrQuestionPossible2.Add(rPossible6);
            lrQuestionPossible2.Add(rPossible7);
            lrQuestionPossible2.Add(rPossible8);

            List<Response> lrQuestionBonne2 = new List<Response>();
            lrQuestionBonne2.Add(rPossible6);

            Response rPossible9 = new Response("I");
            Response rPossible10 = new Response("J");
            Response rPossible11 = new Response("K");
            Response rPossible12 = new Response("L");

            List<Response> lrQuestionPossible3 = new List<Response>();
            lrQuestionPossible3.Add(rPossible9);
            lrQuestionPossible3.Add(rPossible10);
            lrQuestionPossible3.Add(rPossible11);
            lrQuestionPossible3.Add(rPossible12);

            List<Response> lrQuestionBonne3 = new List<Response>();
            lrQuestionBonne3.Add(rPossible10);

            Response rPossible13 = new Response("M");
            Response rPossible14 = new Response("N");
            Response rPossible15 = new Response("O");
            Response rPossible16 = new Response("P");

            List<Response> lrQuestionPossible4 = new List<Response>();
            lrQuestionPossible4.Add(rPossible13);
            lrQuestionPossible4.Add(rPossible14);
            lrQuestionPossible4.Add(rPossible15);
            lrQuestionPossible4.Add(rPossible16);

            List<Response> lrQuestionBonne4 = new List<Response>();
            lrQuestionBonne4.Add(rPossible14);




            Question Q1 = new Question("MAMENE 1 ", 5, 5, lrQuestionPossible1, lrQuestionBonne1);
            Question Q2 = new Question("MAMENE 2 ", 5, 5, lrQuestionPossible2, lrQuestionBonne2);
            Question Q3 = new Question("MAMENE 3 ", 5, 5, lrQuestionPossible3, lrQuestionBonne3);
            Question Q4 = new Question("MAMENE 4 ", 5, 5, lrQuestionPossible4, lrQuestionBonne4);

            List<Question> listeQuestionsSujet = new List<Question>();
            listeQuestionsSujet.Add(Q1);
            listeQuestionsSujet.Add(Q2);
            listeQuestionsSujet.Add(Q4);

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



            MarkRecognizer.analyzeSheet(p.subjectList()[0],"BD");
              ExportationHandler.exportAsCsv(l, p.title()+".xlsx");


               Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new mainWindow());

    
        }
    }
}
