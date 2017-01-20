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
          Bitmap image = new Bitmap(Bitmap.FromFile(path));



          //ANALYZER PART
            CopyOtsu copie = new CopyOtsu();
            copie.setStudentCopy(image);
            copie.convertirImageBinaire();

          Analyse analyse = new Analyse();
          analyse.setCopie(copie);

          Student studentAnalyzed = new Student(analyse.getNumeroEtudiant(copie).ToString(),new List<Question>());

          // Les questions du sujet
          List<Question> listSubjectQuestions = s.questionList();

          // Ce que l'étudiant a répondu
          List<Question> studentResponses = new List<Question>();
            foreach (Question q in listSubjectQuestions)
          {
              Question answer = new Question();
              for (int i = 0; i < q.getResponseList().Count; i++)
              {
                    Response r = q.getResponseList()[i];
                  if (analyse.isChecked(new Rectangle(r.x, r.y, 23,23)))
                  {
                      answer.getAnswerList().Add(r);
                  }
              }
              studentResponses.Add(answer);
          }

            studentAnalyzed.setAnswerList(studentResponses);
            s.setStudent(studentAnalyzed);
            CorrectionHandler.correct(s);
        }


    }
}