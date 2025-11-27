using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.AristovaAK.Sprint2.Task5.V8.Lib
{
    public class DataService : ISprint2Task5V8
    {
        public string FindDateOfPreviousDay(int m, int n)
        {
            if (n > 1)
            {
                n -= 1;
            }
            else
            {
                m -= 1;
                switch (m)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        n = 31;
                        break;
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        n = 30;
                        break;
                    case 2:
                        n = 28; 
                        break;

                }
            }
            return $"{n}.{m}";

        }
    }
}
