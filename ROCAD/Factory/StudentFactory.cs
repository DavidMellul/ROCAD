using System.Collections.Generic;
using ROCAD.Model;

namespace ROCAD.Factory
{
    public class StudentFactory
    {
        // DATA PART
        private Dictionary<string, Student> m_studentList;

        // PATTERN SINGLETON
        private static StudentFactory m_instance = new StudentFactory();

        private StudentFactory()
        {
            this.m_studentList = new Dictionary<string, Student>();
        }

        public static StudentFactory getInstance()
        {
            return m_instance;
        }

        public Student createStudent(string id, List<Question> responseList)
        {
            Student s = new Student(id,responseList);
            this.m_studentList[id] = s;
            return s;
        }
    }
}