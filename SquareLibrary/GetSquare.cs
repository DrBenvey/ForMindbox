using SquareLibrary.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareLibrary
{
    /// <summary>
    /// list of calculated figures
    /// may be continued
    /// </summary>
    enum FigureType
    {
        Circle,
        Triangle
        //todo
    }

    public class Square: IFigureComputedValues
    {
        private Triangle? triangle { get; set; }
        private Circle? circle { get; set; }
        private FigureType? figureType { get; set; }
        public Square()
        {
            figureType = null;
        }
        public Square(List<double>? side = null, double? radius = null)
        {
            InitFigure(side, radius);
        }

        public double GetSquare()
        {
            switch (figureType)
            {
                case FigureType.Circle:
                    return circle.GetSquare();
                case FigureType.Triangle:
                    return triangle.GetSquare();
                default:
                    return -1;
            }
            return -1;
        }

        public double GetSquareUnsafe()
        {
            switch (figureType)
            {
                case FigureType.Circle:
                    return circle.GetSquareUnsafe();
                case FigureType.Triangle:
                    return triangle.GetSquareUnsafe();
                default:
                    return -1;
            }
        }

        public bool IsCorrect()
        {
            switch (figureType)
            {
                case FigureType.Circle:
                    return circle.IsCorrect();
                case FigureType.Triangle: 
                    return triangle.IsCorrect();
                default: 
                    return false;
            }
        }

        /// <summary>
        /// defines figure
        /// </summary>
        /// <param name="side">a list of side lengths</param>
        /// <param name="radius">radius of a circle</param>
        public bool InitFigure(List<double>? side =null, double? radius=null)
        {
            try
            {
                if (side != null && radius.HasValue)
                    throw new Exception("only one figure can be given");
                if (side == null && !radius.HasValue)
                    throw new Exception("figure parameters must be specified");
                if (side == null && radius.HasValue)
                {
                    circle=new Circle(radius.Value);
                    figureType = FigureType.Circle;
                }
                if (side != null && !radius.HasValue)
                {
                    switch (side.Count)
                    {
                        case 0:
                            throw new Exception("must be at least 3 sides");
                        case 1:
                            throw new Exception("must be at least 3 sides");
                        case 2:
                            throw new Exception("must be at least 3 sides");
                        case 3:
                            triangle = new Triangle(side[0], side[1], side[2]);
                            figureType = FigureType.Triangle;
                            break;
                        default: 
                            throw new Exception("not implemented");
                    }                    
                }
                return true;
            }
            catch(Exception ex)
            {
                figureType = null;
                return false;
            }               
        }
    }
}
