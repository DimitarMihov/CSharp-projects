using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace School
{
    public class Person: IComments
    {
        private int name;

        public int Name
        {
            get { return name; }
            set { name = value; }
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
    }
}
