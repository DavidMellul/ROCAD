using System.Collections.Generic;
using System.Linq;
using ROCAD.Model;

namespace ROCAD.Controller
{
    public class CorrectionHandler
    {
        public static void correct(Subject s)
        {
            Student studentBeingCorrected = s.student();
            List<Question> questionList = s.questionList();

            double finalGradeComputed = 0.0;

            for (int i = 0; i < studentBeingCorrected.responsesAnswered().Count; i++)
            {
                Question answered = studentBeingCorrected.responsesAnswered()[i];
                Question expected = questionList[i];

                finalGradeComputed += computeQuestionGrade(answered, expected);
            }

            s.student().setGrade(finalGradeComputed);
        }

        private static double computeQuestionGrade(Question answered, Question expected)
        {
            double computed = 0.0;

            for (int i = 0; i < expected.getAnswerList().Count; i++)
            {
                Response rAnswered = new Response("RANDOM-STRING-FORCED-FALSE-AS-RESPONSE");
                if(answered.getAnswerList()[i] != null)
                    rAnswered = answered.getAnswerList()[i];
                Response rExpected = expected.getAnswerList()[i];

                if (rAnswered.Equals(rExpected) == false)
                {
                    computed += expected.malus() * (-1) / expected.getAnswerList().Count;
                }
                else if (rAnswered.Equals(answered.getAnswerList().Last()))
                {
                    computed += expected.bonus() / expected.getAnswerList().Count;
                }
            }
            return computed;
        }
    }
}