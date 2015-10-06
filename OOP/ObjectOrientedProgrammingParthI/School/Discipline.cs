using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace School
{
    public class Discipline : IComments
    {
        private string name;
        private int lecturesNumber;
        private int exercisesNumber;

        public string Name { get; set; }

        public Discipline(int exNum, int lecNum, string name)
        {
            this.ExercisesNumber = exNum;
            this.LecturesNumber = lecNum;
            this.Name = name;
        }

        /// <summary>
        /// Implements interface IComment
        /// </summary>
        public string SetComment
        {
            get
            {
                return this.SetComment;
            }
            set
            {
                this.SetComment = value;
            }
        }

        public void PrintComment(string comment = null)
        {
            string currentComment;
            if (comment != null)
            {
                currentComment = comment;
            }
            else
            {
                currentComment = this.SetComment;
            }

            Console.WriteLine("{0}'s comment: {1}", this.Name, this.SetComment);
        }

        public int ExercisesNumber
        {
            get
            {
                return this.exercisesNumber;
            }
            set
            {
                this.exercisesNumber = value;
            }
        }

        public int LecturesNumber
        {
            get
            {
                return this.lecturesNumber;
            }
            set
            {
                this.lecturesNumber = value;
            }
        }
    }
}
