namespace Tyuiu.DolganovAV.Sprint5.Task3.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void SaveToFileTextData()
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");
            FileInfo FileInfo = new FileInfo(path);
            bool FileExist = File.Exists(path);
            Assert.AreEqual(true, FileExist);
        }
    }
}
