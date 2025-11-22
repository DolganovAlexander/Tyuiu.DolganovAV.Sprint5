using Tyuiu.DolganovAV.Sprint5.Task6.V5.Lib;
namespace Tyuiu.DolganovAV.Sprint5.Task6.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint5\InPutDataFileTask6V5.txt";
            Assert.AreEqual(5, ds.LoadFromDataFile(path));
        }

        [TestMethod]
        public void CheckIfFileExists()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask6V5.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            Assert.AreEqual(true, fileExists);
        }
    }
}
