
namespace SquareLibrary
{
    /// <summary>
    /// interface for calculated shape parameters
    /// can be added a perimeter or convexity property
    /// </summary>
    internal interface IFigureComputedValues
    {
        /// <summary>
        /// get the area of ​​the figure with check
        /// </summary>
        /// <returns>area of ​​figure or -1 if error</returns>
        double GetSquare();
        /// <summary>
        /// get the area of ​​the figure without check
        /// </summary>
        /// <returns>area of ​​figure or -1 if error</returns>
        double GetSquareUnsafe();

        /// <summary>
        /// is the shape correct
        /// </summary>
        /// <returns></returns>
        bool IsCorrect();
    }
}
