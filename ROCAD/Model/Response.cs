using System;

namespace ROCAD.Model
{
    [Serializable()]
    public class Response
    {
        private static int ID = 1;

        // DATA PART
        private string m_id;
        private string m_description;

        // GRAPHICAL DATA PART
        private int m_x , m_y;

        public Response()
        {
            this.m_id = ID++.ToString();
            this.m_description = "undefined";
        }

        public Response(string description)
        {
            this.m_id = ID++.ToString();
            this.m_description = description;
        }

        public string id()
        {
            return this.m_id;
        }

        public string description()
        {
            return this.m_description;
        }

        public override bool Equals(Object r)
        {
            if (r.GetType() != typeof(Response))
                return false;
            return this.description().Equals(((Response)r).description());
        }


        public int x {
            get { return m_x; }
            set { m_x = value; }
        }

        public int y {
            get { return m_y; }
            set { m_y = value; }
        }
    }
}
