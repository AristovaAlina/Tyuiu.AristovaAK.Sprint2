using Tyuiu.AristovaAK.Sprint2.Task6.V15.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #2 | Выполнила: Аристова А. К. | СМАРТб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Получение результата из switch                                    *");
        Console.WriteLine("* Задание #6                                                              *");
        Console.WriteLine("* Вариант #15                                                             *");
        Console.WriteLine("* Выполнила: Аристова Алина Константиновна | СМАРТб-25-1                  *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дано целое число k (1 <= k <= 365). Определить, каким днем недели       *");
        Console.WriteLine("* (понедельником, вторником, …, субботой или воскресеньем) является k-й   *");
        Console.WriteLine("* день не високосного года, в котором 1 января понедельник.               *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Введите порядковый номер месяца: ");
        int k = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");


        if ((k < 1) || (k > 366))
            Console.WriteLine("Введено неправильное значение!");
        else
            Console.WriteLine("День недели: " + ds.FindDayName(k));

        Console.ReadKey();
    }
}
