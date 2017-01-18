using System;
using System.Collections.Generic;
using System.Linq;
using ROCAD.Model;

namespace ROCAD.Factory
{
    [Serializable()]
    public class StudentFactory
    {
        // DATA PART
        private Dictionary<string,Student> m_studentList;

        public StudentFactory()
        {
            this.m_studentList = new Dictionary<string, Student>();;
        }

        public Student createStudent(string id, List<Question> responseList)
        {
            Student s = new Student(id,responseList);
            this.m_studentList[id] = s;
            return s;
        }

        public List<Student> getStudentList()
        {
            return this.m_studentList.Values.ToList();
        }
    }
}