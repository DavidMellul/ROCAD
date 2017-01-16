using System;

namespace ROCAD.Model
{
    public class Response
    {
        private static int ID = 1;

        // DATA PART
        private string m_id;
        private string m_description;

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
    }
}
