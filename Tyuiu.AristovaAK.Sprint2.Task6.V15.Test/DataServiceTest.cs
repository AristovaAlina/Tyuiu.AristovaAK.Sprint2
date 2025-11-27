using Tyuiu.AristovaAK.Sprint2.Task6.V15.Lib;
namespace Tyuiu.AristovaAK.Sprint2.Task6.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDayName1()
        {
            DataService ds = new DataService();
            int n = 112;
            Assert.AreEqual("Воскресенье", ds.FindDayName(n));
        }

        [TestMethod]
        public void ValidFindDayName2()
        {
            DataService ds = new DataService();
            int n = 164;
            Assert.AreEqual("Среда", ds.FindDayName(n));
        }
    }
}
