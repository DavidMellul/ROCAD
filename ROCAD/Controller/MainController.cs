using ROCAD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROCAD.Controller
{
    class MainController
    {
        // DATAS
        Project m_project;

        //SINGLETON
        private static MainController m_instance = new MainController();
        private MainController()
        {
            this.m_project = new Project();
        }
        public static MainController getInstance() { return m_instance; }


        public Project getProject() { return this.m_project; }
        public void setProject(Project p) { this.m_project = p; }
        
    }
}
