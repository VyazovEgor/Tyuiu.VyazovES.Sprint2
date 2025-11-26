using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.VyazovES.Sprint2.Task1.V13.Lib
{
    public class DataService : ISprint2Task1V13
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];
            res[0] = (a + 0) == (a + 0);
            res[1] = (b + 0) != (c + 0) | (d + 0) == (d + 0);
            res[2] = (a + 100) < (b + 0) & (c + 0) > (d + 0);
            res[3] = (b + 0) >= (a + 0) || (c + 0) <= (d + 0);
            res[4] = !((c + 0) == (d + 0)) && (b + 0) != (a + 0);
            res[5] = (a + 0) > (b + 0) ^ (c + 0) < (d + 0);

            return res;
        }
    }
}
