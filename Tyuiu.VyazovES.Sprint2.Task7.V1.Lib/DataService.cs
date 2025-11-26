using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.VyazovES.Sprint2.Task7.V1.Lib
{
    public class DataService : ISprint2Task7V1
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool z;
            bool inCircle = (x * x + y * y <= 1);
            bool inLeftSector = (x <= 0 && y >= 0 && y <= -x);
            bool inRightSector = (x >= 0 && y >= 0 && y <= x);

            if (inCircle && (inLeftSector || inRightSector))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
