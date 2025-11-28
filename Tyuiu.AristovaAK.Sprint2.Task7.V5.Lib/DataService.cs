using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.AristovaAK.Sprint2.Task7.V5.Lib
{
    public class DataService : ISprint2Task7V5
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res = false;
            if ((y >= (x * x)) && (y <= Math.Exp(x)) && (y <= Math.Exp(-x))) res = true;
            return res;
        }
    }
}
