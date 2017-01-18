using System;
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
        
        // FACTORIES
        private SubjectFactory m_subjectFactory = SubjectFactory.getInstance();
        private StudentFactory m_studentFactory = StudentFactory.getInstance();

        public Project() { }

        public Project(String author, String title, Subject subject) {
            m_author = author;
            m_title = title;
            m_subject = subject;
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


    }
}
