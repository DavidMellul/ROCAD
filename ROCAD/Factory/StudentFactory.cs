using System;
using System.Collections.Generic;
using ROCAD.Model;

namespace ROCAD.Factory
{
    [Serializable()]
    public class StudentFactory
    {
        // DATA PART
        private List<Student> m_studentList;

        // PATTERN SINGLETON
        private static StudentFactory m_instance = new StudentFactory();

        private StudentFactory()
        {
            this.m_studentList = new List<Student>();
        }

        public static StudentFactory getInstance()
        {
            return m_instance;
        }

        public Student createStudent(string id, List<Question> responseList)
        {
            Student s = new Student(id,responseList);
            this.m_studentList.Add(s);
            return s;
        }

        public List<Student> getStudentList()
        {
            return this.m_studentList;
        }
    }
}