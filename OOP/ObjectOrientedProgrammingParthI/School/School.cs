using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace School
{
    public class School
    {
        /// <summary>
        /// field
        /// </summary>
        private List<SchoolClass> classes;

        /// <summary>
        /// Constructor
        /// </summary>
        public School(SchoolClass[] classes)
        {
            this.classes = new List<SchoolClass>(classes);
        }

        /// <summary>
        /// Property
        /// </summary>
        public SchoolClass[] Classes
        {
            get
            {
                throw new System.NotImplementedException();
            }
            private set
            {
            }
        }

        public void AddClass(SchoolClass schoolclass)
        {
            this.classes.Add(schoolclass);
        }

        public void RemoveClass(SchoolClass schoolclass)
        {
            this.classes.Remove(schoolclass);
        }
    }
}
