using Tyuiu.AristovaAK.Sprint2.Task2.V8.Lib;
namespace Tyuiu.AristovaAK.Sprint2.Task2.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            int x = 4;
            int y = 7;
            bool wait = true;
            bool res = ds.CheckDotInShadedArea(x, y);

            Assert.AreEqual(wait, res);
        }
    }
}
