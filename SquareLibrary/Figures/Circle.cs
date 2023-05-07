
namespace SquareLibrary.Figures
{
    public class Circle: Figure
    {
        public double radius { get; set; }
        public Circle(double radius)
        {            
            this.radius = radius;
        }

        public override bool IsCorrect()
        {
            try
            {
                if (radius <= 0)
                {
                    throw new Exception("radius must be greater than 0");
                }
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }            
        }

        public override double GetSquareUnsafe()
        {
            try
            {
                double tmp = Math.PI * Math.Pow(radius, 2);
                if (!Double.IsInfinity(tmp))
                    return tmp;
                else
                    throw new Exception("the area is too big");
            }
            catch (Exception ex)
            {
                return -1;
            }
        }
    }
}
