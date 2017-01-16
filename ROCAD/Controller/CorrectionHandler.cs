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
            if (answered.getAnswerList().Count != expected.getAnswerList().Count)
                return expected.malus() * (-1);

            double computed = 0.0;

            for (int i = 0; i < answered.getAnswerList().Count; i++)
            {
                Response rAnswered = answered.getAnswerList()[i];
                Response rExpected = expected.getAnswerList()[i];

                if (rAnswered.Equals(rExpected) == false)
                {
                    computed = expected.malus() * (-1);
                    break;
                }
                else
                {
                    if (rAnswered.Equals(answered.getAnswerList().Last()))
                        computed = expected.bonus();
                }
            }
            return computed;
        }
    }
}