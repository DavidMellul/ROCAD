using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using ROCAD.Model;

namespace ROCAD.Factory
{
    [Serializable()]
    public class SubjectFactory
    {
        //DATA PART
        private List<Subject> m_subjectList;
        private Subject m_originalSubject;

        public SubjectFactory()
        {
            this.m_subjectList = new List<Subject>();
            this.m_originalSubject = new Subject();
        }

        public Subject createOriginalSubject(List<Question> questionList)
        {
            Subject s = new Subject(questionList, null);
            this.m_originalSubject = s;
            return s;
        }

        public List<Subject> createRandomSubjects()
        {
            if(m_originalSubject == null)
                throw new Exception("No original subject has been defined.");

            List<Student> students = StudentFactory.getInstance().getStudentList();

            for (int i = 0; i < students.Count; i++)
            {
                Subject s = new Subject(Utils.Utils.shuffleList(m_originalSubject.questionList()),students[i]);
                this.m_subjectList.Add(s);
            }
            return this.m_subjectList;
        }

        public List<Subject> getSubjects()
        {
            return this.m_subjectList;
        }
    }
}