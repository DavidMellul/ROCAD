using System;
using System.Collections.Generic;

namespace ROCAD.Model
{
    [Serializable()]
    public class Student
    {
        private static int ID = 1;
        // DATA PART
        private string m_id;
        private double m_grade;

        // RESPONSES ANSWERED PART
        private List<Question> m_responseList;

        public Student()
        {
            this.m_id = ID++.ToString();
            this.m_responseList = new List<Question>();
        }

        public Student(string id, List<Question> responseList)
        {
            this.m_id = id;
            this.m_responseList = responseList;
        }

        public string id()
        {
            return this.m_id;
        }

        public double grade()
        {
            return this.m_grade;
        }

        public void setGrade(double grade)
        {
            this.m_grade = grade;
        }

        public List<Question> responsesAnswered()
        {
            return this.m_responseList;
        }

        public void addResponseAnswered(Question r)
        {
            this.m_responseList.Add(r);
        }

        public void setAnswerList(List<Question> l)
        {
            this.m_responseList = l;
        }

        public override string ToString()
        {
            return "[Étudiant] => { "+this.m_id+" , "+ " , "+this.m_grade + " }\n";
        }
    }
}
