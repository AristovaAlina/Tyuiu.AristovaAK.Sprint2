using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.AristovaAK.Sprint2.Task2.V8.Lib
{
    public class DataService : ISprint2Task2V8
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res = false;

            if ((1 < y && y < 13) && (x > 2 && x < 15))
            {
                if (y == 2)
                {
                    if ((x == 9) || (x == 10) || (x == 11)) res = true;
                }

                if (y == 3)
                {
                    if ((x == 3) || (x == 4) || (x == 5) || (x == 9) || (x == 10) || (x == 11) || (x == 12)) res = true;
                }

                if (y == 4)
                {
                    if ((x == 3) || (x == 4) || (x == 5) || (x == 9) || (x == 10) || (x == 11)) res = true;
                }

                if (y == 5)
                {
                    if (x < 10) res = true;
                }

                if (y == 6)
                {
                    if (x != 14) res = true;
                }
                
                if (y == 7)
                {
                    if (x != 7 && x != 8) res = true;
                }

                if (y == 8)
                {
                    if ((x == 6) || (x == 9) || (x == 12) || (x == 13)) res = true;
                }

                if (y == 9)
                {
                    if ((x > 5 && x < 10) || (x == 12) || (x == 13)) res = true;
                }

                if (y == 10)
                {
                    if (x > 5 && x < 10) res = true;
                }

                if (y == 11)
                {
                    if (x < 10) res = true;
                }
                
                if (y == 12)
                {
                    if ((x == 7) || (x == 8) || (x == 9)) res = true;
                }

            }
            return res;
        }
    }
}
