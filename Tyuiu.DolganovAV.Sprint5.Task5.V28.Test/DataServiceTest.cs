namespace Tyuiu.DolganovAV.Sprint5.Task5.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckIfFileExist()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask5V28.txt\";

            FileInfo FileInfo = new FileInfo(path);
            bool FileExist = FileInfo.Exists;
            Assert.AreEqual(true, FileExist);
        }
    }
}
