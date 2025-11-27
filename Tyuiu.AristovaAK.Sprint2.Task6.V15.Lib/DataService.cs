using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.AristovaAK.Sprint2.Task6.V15.Lib
{
    public class DataService : ISprint2Task6V15
    {
        public string FindDayName(int k)
        {
            int day = k % 7;
            return day switch
            {
                1 => "Понедельник",
                2 => "Вторник",
                3 => "Среда",
                4 => "Четверг",
                5 => "Пятница",
                6 => "Суббота",
                0 => "Воскресенье",
                _ => "Не существует"
            };
        }
    }
}
