using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.VyazovES.Sprint2.Task5.V8.Lib
{
    public class DataService : ISprint2Task5V8
    {
        public string FindDateOfPreviousDay(int m, int n)
        {
            int prevDay;
            int prevMonth;

            // Если текущий день первый в месяце
            if (n == 1)
            {
                prevMonth = m - 1;

                // Определяем количество дней в предыдущем месяце
                switch (prevMonth)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        prevDay = 31;
                        break;
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        prevDay = 30;
                        break;
                    case 2:
                        // Февраль - 28 дней
                        prevDay = 28;
                        break;
                    case 0:
                        // Если предыдущий месяц - декабрь предыдущего года
                        prevMonth = 12;
                        prevDay = 31;
                        break;
                    default:
                        prevDay = 0;
                        break;
                }
            }
            else
            {
                // Если не первый день месяца
                prevMonth = m;
                prevDay = n - 1;
            }

            // Добавляем ноль перед месяцем, если он от 1 до 9
            string monthFormatted = prevMonth < 10 ? $"0{prevMonth}" : prevMonth.ToString();

            // Возвращаем в формате "день.месяц"
            return $"{prevDay}.{monthFormatted}";
        }
    }
}
