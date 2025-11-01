namespace Tyuiu.DolganovAV.Sprint5.Task2.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckFileExist()
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask2.csv");
            FileInfo FileInfo = new FileInfo(path);
            bool FileExist = File.Exists(path);
            Assert.AreEqual(true, FileExist);
        }
    }
}
