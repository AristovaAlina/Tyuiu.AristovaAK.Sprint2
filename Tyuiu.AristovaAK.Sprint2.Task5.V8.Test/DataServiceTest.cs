using Tyuiu.AristovaAK.Sprint2.Task5.V8.Lib;
namespace Tyuiu.AristovaAK.Sprint2.Task5.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfPreviousDay1()
        {
            DataService ds = new DataService();
            int m = 5;
            int n = 1;
            string res = ds.FindDateOfPreviousDay(m, n);
            string wait = "30.4";
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidFindDateOfPreviousDay2()
        {
            DataService ds = new DataService();
            int m = 3;
            int n = 5;
            string res = ds.FindDateOfPreviousDay(m, n);
            string wait = "4.3";
            Assert.AreEqual(wait, res);
        }
    }
}
