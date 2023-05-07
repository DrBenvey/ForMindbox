using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareLibrary.Figures
{
    public abstract class Figure : IFigureComputedValues
    {
        public abstract double GetSquareUnsafe();
        public abstract bool IsCorrect();
        public double GetSquare()
        {
            try
            {
                bool isCorrect = IsCorrect();
                if (isCorrect)
                {
                    return GetSquareUnsafe();
                }
                else
                    return -1;
            }
            catch (Exception ex)
            {
                return -1;
            }
        }
    }
}
