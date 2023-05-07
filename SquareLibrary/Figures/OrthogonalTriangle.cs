namespace SquareLibrary.Figures
{
    public class OrthogonalTriangle: Triangle
    {
        /// <summary>
        /// OrthogonalTriangle
        /// </summary>
        /// <param name="a">cathetus 1</param>
        /// <param name="b">cathetus 2</param>
        /// <param name="c">hypotenuse</param>
        public OrthogonalTriangle(double a, double b, double c):base(a, b, c) 
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public override bool IsCorrect()
        {
            try
            {
                double ab = a + b;
                double bc = b + c;
                double ac = c + a;
                if (!Double.IsInfinity(ab) && !Double.IsInfinity(ac) && !Double.IsInfinity(bc))
                {
                    if (!(ab > c && bc > a && ac > b))
                        throw new Exception("wrong sides");
                    double a2 = Math.Pow(a, 2);
                    double b2 = Math.Pow(b,2);
                    double c2 = Math.Pow(c,2);
                    if (!Double.IsInfinity(a2) && !Double.IsInfinity(b2) && !Double.IsInfinity(c2))
                    {
                        if (!(a2 + b2 == c2))
                            throw new Exception("not orthogonal");
                    }
                    else
                        throw new Exception("the sides are too big");
                }
                else
                    throw new Exception("the sides are too big");               
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public override double GetSquareUnsafe()
        {
            try
            {
                double tmp = (a * b) / 2.0;
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
