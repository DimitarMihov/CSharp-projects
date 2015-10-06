using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace School
{
    public class Teacher : Person
    {
        private List<Discipline> disciplines;

        
        public List<Discipline> Disciplines
        {
            get { return disciplines; }
            set { disciplines = value; }
        }

        public void AddDiscipline(Discipline discipline)
        {
            this.disciplines.Add(discipline);
        }

        public void RemoveDiscipline(Discipline discipline)
        {
            this.disciplines.Remove(discipline);
        }

        public Teacher(Discipline[] disciplines)
        {
            this.disciplines = new List<Discipline>(disciplines);
        }

    }
}
