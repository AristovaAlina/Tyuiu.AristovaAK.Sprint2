using Tyuiu.AristovaAK.Sprint2.Task4.V17.Lib;
namespace Tyuiu.AristovaAK.Sprint2.Task4.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 30;
            double y = 4;
            double res = ds.Calculate(x, y);
            double wait = 1297.921;
            Assert.AreEqual(wait, res);

        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 10;
            double y = 9;
            double res = ds.Calculate(x, y);
            double wait = 9.12;
            Assert.AreEqual(wait, res);

        }
    }

}
