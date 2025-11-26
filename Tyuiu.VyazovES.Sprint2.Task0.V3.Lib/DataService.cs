using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.VyazovES.Sprint2.Task0.V3.Lib
{
    public class DataService : ISprint2Task0V3
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];
            res[0] = (x + 0) == (y + 0);
            res[1] = (x + 0) != (y + 0);
            res[2] = (x + 100) < (y + 0);
            res[3] = (x + 100) > (y + 0);
            res[4] = (x + 0) <= (y - 100);
            res[5] = (x + 0) >= (y - 100);
            return res;
        }
    }
}
