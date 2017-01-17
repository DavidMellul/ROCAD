using System;
using System.Collections.Generic;

namespace ROCAD.Model
{
    [Serializable()]
    public class Subject
    {
        private static int ID = 1;

        // DATA PART
        private string m_id;
        private List<Question> m_questionList;

        // STUDENT ASSOCIATED, IF NOT -> ORIGINAL SUBJECT IS THIS ONE
        private Student m_student;

        public Subject()
        {
            this.m_id = ID++.ToString();

            this.m_questionList = new List<Question>();
            this.m_student = new Student();
        }

        public Subject(List<Question> questionList)
        {
            this.m_id = ID++.ToString();
            this.m_questionList = questionList;
            this.m_student = new Student();
        }

        public Subject(List<Question> questionList, Student studentAssociated)
        {
            this.m_id = ID++.ToString();
            this.m_questionList = questionList;
            this.m_student = studentAssociated;
        }

        public string id()
        {
            return this.m_id;
        }

        public Student student()
        {
            return this.m_student;
        }

        public List<Question> questionList()
        {
            return this.m_questionList;
        }

        public void addQuestion(Question q)
        {
            this.m_questionList.Add(q);
        }
    }
}
