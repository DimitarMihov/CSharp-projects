namespace RefactorVariableNamingAndExpressions
{
    using System;

    class NamesAndExpressions
    {
        static void Main()
        {
            Size sizeOfFigure = new Size(2.5, 4.6);
            Console.WriteLine(sizeOfFigure.GetRotatedSize(0).ToString());
        }
    }
}
