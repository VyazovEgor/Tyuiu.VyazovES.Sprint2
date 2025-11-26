using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.VyazovES.Sprint2.Task2.V20.Lib
{
    public class DataService : ISprint2Task2V20
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res =
            (x == 3 && (y == 3 || y == 4 || y == 5 || y == 9)) ||
            (x == 4 && (y == 3 || y == 4 || y == 5 || y == 9)) ||
            (x == 5 && y >= 3 && y <= 9) ||
            (x == 6 && (y == 3 || (y >= 6 && y <= 9) || y == 13)) ||
            (x == 7 && ((y >= 6 && y <= 9) || y == 13)) ||
            (x == 8 && (y >= 6 && y <= 13)) ||
            (x == 9 && (y == 6 || (y >= 9 && y <= 12))) ||
            (x == 10 && (y == 6 || (y >= 9 && y <= 12))) ||
            (x == 11 && ((y >= 3 && y <= 6) || (y >= 9 && y <= 12))) ||
            (x == 12 && (y >= 9 && y <= 12)) ||
            (x == 13 && (y >= 10 && y <= 12));

            if (res)
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
