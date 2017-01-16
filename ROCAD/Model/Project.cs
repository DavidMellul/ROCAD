using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROCAD.Model
{

// Classe de sauvegarde d'un projet/sujet
    public class Project
    {
        // Attributs
        private String m_author;
        private String m_title;
        private Question m_questions;

        public Project() { }

        public Project(String author, String title, Question questions) {
            m_author = author;
            m_title = title;
            m_questions = questions;
        }

        

    }
}
