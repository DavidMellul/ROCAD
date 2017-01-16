using System;
using System.Collections.Generic;
using System.Linq;
using ROCAD.Model;

namespace ROCAD.Controller
{
    public class CorrectionHandler
    {
        private static string EMPTY_RESPONSE = "RANDOM-STRING-FORCED-FALSE-AS-RESPONSE";

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
                Response rAnswered = new Response(EMPTY_RESPONSE);
                if (i < answered.getAnswerList().Count)
                    rAnswered = answered.getAnswerList()[i];

                if (expected.getAnswerList().Contains(rAnswered))
                {
                    computed += expected.bonus() / expected.getAnswerList().Count;
                }
                else
                {
                    if (rAnswered.description().Equals(EMPTY_RESPONSE) == false)
                    {
                        if(computed > expected.bonus()/2 || computed == 0)
                            computed -= expected.malus() / expected.getAnswerList().Count;
                    }
                }
            }
            return computed;
        }
    }
}