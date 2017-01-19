using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using ROCAD.Factory;

namespace ROCAD.Model
{

// Classe de sauvegarde d'un projet/sujet
[Serializable()]
    public class Project
    {
        // DATA PART
        private String m_author;
        private String m_title;
        private Subject m_subject;
        private String m_time;
        private String m_date;
        
        // FACTORIES
        private SubjectFactory m_subjectFactory ;
        private StudentFactory m_studentFactory;

        private List<Subject> m_subjects;

        public Project() { }

        public Project(String author, String title, Subject subject, String time, String date) {
            m_author = author;
            m_title = title;
            m_subject = subject;
            m_time = time;
            m_date = date;

            m_subjectFactory = new SubjectFactory(this);
            m_studentFactory = new StudentFactory();
        }

        public void save(String path) {
            Stream stream = File.Open(path, FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream,this);
            stream.Close();
        }

        public static Project load (string path)
        {
           Stream stream = File.Open(path, FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();
            Project loaded = (Project)formatter.Deserialize(stream);
            stream.Close();
            return loaded;
        }

        public String author() {
            return this.m_author;
        }

        public String title() {
            return this.m_title;
        }

        public Subject subject() {
            return this.m_subject;
        }

        public override bool Equals(Object r)
        {
            if (r.GetType() != typeof(Project))
                return false;
            return this.title().Equals(((Project)r).title());
        }

        public List<Student> studentList()
        {
            return this.m_studentFactory.getStudentList();
        }

        public List<Subject> subjectList()
        {
            return this.m_subjectFactory.getSubjects();
        }

        public Subject subject(Student s)
        {
            return this.m_subjectFactory.getSubject(s);
        }

        public void addStudent(Student s)
        {
            this.m_studentFactory.createStudent(s.id(), s.responsesAnswered());
        }

        public void setOriginalSubject(Subject s)
        {
            this.m_subject = this.m_subjectFactory.createOriginalSubject(s.questionList());
            m_subjects = this.m_subjectFactory.createRandomSubjects();
        }

        public String date()
        {
            return this.m_date;
        }

        public String time()
        {
            return this.m_time;
        }


    }
}
