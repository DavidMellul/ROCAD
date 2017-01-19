using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using ROCAD.Model;

namespace ROCAD.Factory
{
    [Serializable()]
    public class SubjectFactory
    {
        //DATA PART
        private Dictionary<string,Subject> m_subjectList;
        private Project m_referencedProject;
        private Subject m_originalSubject;

        public SubjectFactory(Project p)
        {
            this.m_subjectList = new Dictionary<string, Subject>();
            this.m_referencedProject = p;
        }


        public Subject createOriginalSubject(List<Question> questionList)
        {
            Subject s = new Subject(questionList, null);
            this.m_originalSubject = new Subject(questionList);
            return s;
        }

        public List<Subject> createRandomSubjects()
        {
            if(m_referencedProject.subject() == null)
                throw new Exception("No original subject has been defined.");

            List<Student> students = m_referencedProject.studentList();

            for (int i = 0; i < students.Count; i++)
            {
                Subject s = new Subject(Utils.Utils.shuffleList(m_referencedProject.subject().questionList()),students[i]);
                this.m_subjectList[students[i].id()] =  s;
            }
            return this.m_subjectList.Values.ToList();
        }

        public List<Subject> getSubjects()
        {
            return this.m_subjectList.Values.ToList();
        }

        public Subject getSubject(Student s)
        {
            return this.m_subjectList[s.id()];
        }
    }
}