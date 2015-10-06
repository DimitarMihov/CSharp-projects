using System;

class CheckBracketsInExpression
{
    /*Write a program to check if in a given expression the brackets are put correctly.
        Example of correct expression: ((a+b)/5-d).
        Example of incorrect expression: )(a+b)).*/

    
    static void Main()
    {


        string[] expressions = new string[4] 
            {
            "(((a+b)/c)*d = (m*n)-(x+y))",
            "(((a+b)/c(*d = (m*n)-(x+y))",
            ")((a+b)/c)*d = (m*n)-(x+y))",
            "(((a+b)/c)*d = (m*n)-(x+y)("
            };

        string correct = "incorrect";
        foreach (var item in expressions)
        {
            if (CheckFirstBracket(item)
                &&
                CheckBracketsMatch(item)
                &&
                CheckLastBracket(item))
            {
                correct = "correct";
            }
            else
            {
                correct = "incorrect";
            }

            Console.WriteLine("The expression {0} is {1}", item, correct);
        }
    }

    public static bool CheckFirstBracket(string expression)
    {
        bool correct = false;
        int indexLeftBracket = expression.IndexOf("(");
        int indexRightBracket = expression.IndexOf(")");

        if (indexLeftBracket < indexRightBracket)
        {
            correct = true;
        }
        
        return correct;
    }

    public static bool CheckBracketsMatch(string expression)
    {
        bool correct = false;
        int leftBrackets = 0;
        int rightBrackets = 0;

        int indexL = 0;
        int n = 0;
        while (indexL >= 0)
        {
            indexL = expression.IndexOf("(", n);
            if (indexL >= 0)
            {
                leftBrackets++;
            }

            n = indexL + 1;
        }

        int indexR = 0;
        int m = 0;
        while (indexR >= 0)
        {
            indexR = expression.IndexOf(")", m);
            if (indexR > 0)
            {
                rightBrackets++;
            }

            m = indexR + 1;
        }

        if (leftBrackets == rightBrackets)
        {
            correct = true;
        }

        return correct;
    }

    public static bool CheckLastBracket(string expression)
    {
        bool correct = false;
        int indexLeftBracket = expression.LastIndexOf("(");
        int indexRightBracket = expression.LastIndexOf(")");

        if (indexLeftBracket < indexRightBracket)
        {
            correct = true;
        }

        return correct;
    }
}