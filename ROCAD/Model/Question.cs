using System;
using System.Collections.Generic;

namespace ROCAD.Model
{
    public class Question
    {
        private static int ID = 1;

        // DATA PART
        private string m_id;
        private string m_description;
        private double m_bonus;
        private double m_malus;

        // RESPONSES
        private List<Response> m_responseList;
        private List<Response> m_answerList;

        public Question()
        {
            this.m_id = ID++.ToString();
            this.m_description = "undefined";
            this.m_bonus = 0;
            this.m_malus = 0;

            this.m_responseList = new List<Response>();
        }

        public Question(string description, int bonus, int malus)
        {
            this.m_id = ID++.ToString();
            this.m_description = description;
            this.m_bonus = bonus;
            this.m_malus = malus;

            this.m_responseList = new List<Response>();
            this.m_answerList = new List<Response>();
        }

        public Question( string description, int bonus, int malus, List<Response> responseList, List<Response> answerList)
        {
            this.m_id = ID++.ToString();
            this.m_description = description;
            this.m_bonus = bonus;
            this.m_malus = malus;

            this.m_responseList = responseList;
            this.m_answerList = answerList;
        }

        public string id()
        {
            return this.m_id;
        }

        public string description()
        {
            return this.m_description;
        }

        public double bonus()
        {
            return this.m_bonus;
        }

        public double malus()
        {
            return this.m_malus;
        }

        public List<Response> getResponseList()
        {
            return this.m_responseList;
        }

        public List<Response> getAnswerList()
        {
            return this.m_answerList;
        }
    }
}
