namespace Tyuiu.DolganovAV.Sprint5.Task4.V24.Test
{
    [TestClass]
    public sealed class DataServiceTEst
    {
        [TestMethod]
        public void CheckIfFileExist()
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask4.txt");

            FileInfo FileInfo = new FileInfo(path);
            bool FileExist = FileInfo.Exists;
            Assert.AreEqual(true, FileExist);
        }
    }
}
