using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using ROCAD.Model;

namespace ROCAD.Factory
{
    public class SubjectFactory
    {
        //DATA PART
        private List<Subject> m_subjectList;
        private Subject m_originalSubject;

        //PATTERN SINGLETON
        private static SubjectFactory m_instance = new SubjectFactory();
        private SubjectFactory()
        {
            this.m_subjectList = new List<Subject>();
        }
        public static SubjectFactory getInstance()
        {
            return m_instance;
        }

        public Subject createOriginalSubject(List<Question> questionList)
        {
            Subject s = new Subject(questionList, null);
            this.m_originalSubject = s;
            return s;
        }

        public List<Subject> createRandomSubjects(int n)
        {
            if(m_originalSubject == null)
                throw new Exception("No original subject has been defined.");

            for (int i = 0; i < n; i++)
            {
                Subject s = new Subject(Utils.Utils.shuffleList(m_originalSubject.questionList()));
                this.m_subjectList.Add(s);
            }
            return this.m_subjectList;
        }
    }
}