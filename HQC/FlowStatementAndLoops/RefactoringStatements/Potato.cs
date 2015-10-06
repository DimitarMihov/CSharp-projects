namespace RefactoringStatementsA
{
    using System;
    public class Potato
    {
        public bool HasNotBeenPeeled { get; set; }
        public bool IsRotten { get; set; }

        public Potato()
        {
            this.HasNotBeenPeeled = true;
            this.IsRotten = false;
        }

        public void Cook()
        {
            // cooking potato in some way
        }
    }
}
