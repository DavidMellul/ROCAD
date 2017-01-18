using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using PT_Lot4;
using ROCAD.Model;

namespace ROCAD.Controller
{
    public class MarkRecognizer
    {

        public static void analyzeSheet(Subject s, string path)
        {
          //OPEN AND RETRIEVE FILE DATA
          PDFHandler pdf = new PDFHandler();
     //     pdf.pdfToBmp(path);
          Bitmap image = new Bitmap(Bitmap.FromFile(path+".jpg"));


          //ANALYZER PART
            CopyOtsu copie = new CopyOtsu();
            copie.setStudentCopy(image);
            copie.convertirImageBinaire();

          Analyse analyse = new Analyse();
          analyse.setCopie(copie);

          Student studentAnalyzed = s.student();

          // Les questions du sujet
          List<Question> listSubjectQuestions = s.questionList();

          // Ce que l'étudiant a répondu
          List<Question> studentResponses = new List<Question>();
            foreach (Question q in listSubjectQuestions)
          {
              Question answer = new Question();
              foreach (Response r in q.getResponseList())
              {
                  if (analyse.isChecked(new Rectangle(r.x, r.y, 23,23)))
                  {
                      answer.getAnswerList().Add(r);
                  }
              }
              Debug.WriteLine(answer.getAnswerList().Count);
              studentResponses.Add(answer);
          }

          s.student().setAnswerList(studentResponses);
          CorrectionHandler.correct(s);
          Debug.WriteLine(s.student().grade());
        }


    }
}