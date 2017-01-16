using System.Collections.Generic;

namespace ROCAD.Model
{
    public class Student
    {
        // DATA PART
        private string m_id;
        private string m_firstname;
        private string m_lastname;
        private double m_grade;

        // RESPONSES ANSWERED PART
        private List<Question> m_responseList;

        public Student()
        {
            this.m_id = "0";
            this.m_firstname = "undefined";
            this.m_lastname = "undefined";

            this.m_responseList = new List<Question>();
        }

        public Student(string id, string firstname, string lastname, List<Question> responseList)
        {
            this.m_id = id;
            this.m_firstname = firstname;
            this.m_lastname = lastname;

            this.m_responseList = responseList;
        }

        public string id()
        {
            return this.m_id;
        }

        public string firstname()
        {
            return this.m_firstname;
        }

        public string lastname()
        {
            return this.m_lastname;
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

        public override string ToString()
        {
            return "[Étudiant] => { "+this.m_firstname+" , "+this.m_lastname + " , "+this.m_grade + " }\n";
        }
    }
}
