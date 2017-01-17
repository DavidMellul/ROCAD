using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ROCAD.Model
{

// Classe de sauvegarde d'un projet/sujet
[Serializable]
    public class Project
    {
        // Attributs
        [XmlAttribute]
        private String m_author { get; set; }
        [XmlAttribute]
        private String m_title { get; set; }
        [XmlAttribute]
        private Subject m_subject { get; set; }

        

        public Project() { }

        public Project(String author, String title, Subject subject) {
            m_author = author;
            m_title = title;
            m_subject = subject;
        }

        public void save(String path) {
            XmlSerializer serializer = new XmlSerializer(typeof(Project));
            StreamWriter ecrivain = new StreamWriter(path, false);
            serializer.Serialize(ecrivain, this);
            ecrivain.Close();
        }

        public static Project load (string path)
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(Project));
            StreamReader reader = new StreamReader(path);
            Project p = (Project)deserializer.Deserialize(reader);
            reader.Close();

            return p;
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
