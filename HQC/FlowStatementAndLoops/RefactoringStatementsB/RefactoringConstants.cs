using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringStatementsB
{
    class RefactoringConstants
    {
        static void Main()
        {
            int x = 0;
            int y = 0;
            const int MinX = -100;
            const int MaxX = 150;
            const int MinY = -50;
            const int MaxY = 50;

            bool shouldVisitCell = true;

            if ((MinX <= x && x <= MaxX) && (MinY <= y && y <= MaxY) && shouldVisitCell)
            {
                VisitCell();
            }
        }

        private static void VisitCell()
        {
            throw new NotImplementedException();
        }
    }
}
