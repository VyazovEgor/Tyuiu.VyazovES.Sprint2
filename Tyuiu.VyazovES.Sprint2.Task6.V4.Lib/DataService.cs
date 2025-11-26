using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.VyazovES.Sprint2.Task6.V4.Lib
{
    public class DataService : ISprint2Task6V4
    {
        public string FindCardSuit(int x)
        {

            string suitName = x switch
            {
                1 => "пики",
                2 => "трефы",
                3 => "бубны",
                4 => "червы",
                _ => "неизвестная масть. Введите число от 1 до 4."
            };

                return suitName;
            
        }
    }
}
