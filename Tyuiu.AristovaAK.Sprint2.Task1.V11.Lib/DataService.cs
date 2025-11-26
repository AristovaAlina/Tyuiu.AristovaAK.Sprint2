using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.AristovaAK.Sprint2.Task1.V11.Lib
{
    public class DataService : ISprint2Task1V11
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            /// ==, !=, <, >, <=, >=
            /// |,       &,     ||,   &&,   !,    ^
            /// False, False, True, False, True, False
            /// a = 145, b = 156, c = 142, d = 117

            res[0] = (a > b) | (c == d);
            res[1] = (a != c) & (b == d);
            res[2] = (a <= b) || (d == c);
            res[3] = (a == b) && (c < d);
            res[4] = !(a == d);
            res[5] = (a < b) ^ (c > d);

            return res;
        }
    }
}
