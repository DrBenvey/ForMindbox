namespace SquareLibrary.Figures
{
    public class Triangle: Figure
    {
        private OrthogonalTriangle? orthogonalTriangle { get; set; }
        public double a { get; set; }
        public double b { get; set; }
        public double c { get; set; }
        public Triangle(double a, double b, double c)
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
                double bc = b+c;
                double ac = c + a;
                if (!Double.IsInfinity(ab) && !Double.IsInfinity(ac) && !Double.IsInfinity(bc))
                {
                    if (!(ab > c && bc > a && ac > b))
                        throw new Exception("wrong sides");
                    IsOrthogonal();
                    return true;
                }
                else
                    throw new Exception("the sides are too big");
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        /// <summary>
        /// checks if a rectangle is rectangular
        /// </summary>
        /// <returns></returns>
        public void IsOrthogonal()
        {
            orthogonalTriangle = null;
            double a2 = Math.Pow(a, 2);
            double b2 = Math.Pow(b, 2);
            double c2 = Math.Pow(c, 2);
            if (!Double.IsInfinity(a2) && !Double.IsInfinity(b2) && !Double.IsInfinity(c2))
            {
                if (a2 + Math.Pow(b, 2) == c2)
                {
                    orthogonalTriangle = new OrthogonalTriangle(a, b, c);
                    return;
                }
                if (b2 + c2 == a2)
                {
                    orthogonalTriangle = new OrthogonalTriangle(b, c, a);
                    return;
                }
                if (a2 + c2 == b2)
                {
                    orthogonalTriangle = new OrthogonalTriangle(a, c, b);
                    return;
                }
            }
            else
                throw new Exception("the sides are too big");
        }

        public override double GetSquareUnsafe()
        {
            try
            {
                if (orthogonalTriangle == null)
                {
                    double p = (a + b + c) / 2.0;
                    if (!Double.IsInfinity(p))
                    {
                        var tmp = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                        if (!Double.IsInfinity(tmp))
                            return tmp;
                        else
                            throw new Exception("the area is too big");
                    }
                    else
                        throw new Exception("the area is too big");
                }
                else
                    return orthogonalTriangle.GetSquareUnsafe();
            }
            catch (Exception ex)
            {
                return -1;
            }
        }
    }
}

