using Tyuiu.AristovaAK.Sprint2.Task5.V8.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #2 | Выполнила: Аристова А. К. | СМАРТб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Оператор switch                                                   *");
        Console.WriteLine("* Задание #5                                                              *");
        Console.WriteLine("* Вариант #8                                                              *");
        Console.WriteLine("* Выполнила: Аристова Алина Константиновна | СМАРТб-25-1                  *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дата некоторого дня характеризуется двумя натуральными числами:         *");
        Console.WriteLine("* m (порядковый номер месяца) и n (число). По заданным n и m определить   *");
        Console.WriteLine("* дату предыдущего дня (принять, что n и m не характеризуют 1 января).    *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Введите порядковый номер месяца: ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите число: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");


        if ((m > 12) || (n > 31) || (m < 1) || (n < 1))
            Console.WriteLine("Введено неправильное значение!");
        else
            Console.WriteLine("Дата предыдущего дня: " + ds.FindDateOfPreviousDay(m, n));

        Console.ReadKey();
    }
}
