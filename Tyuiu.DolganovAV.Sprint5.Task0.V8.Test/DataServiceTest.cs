namespace Tyuiu.DolganovAV.Sprint5.Task0.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckeedExistsFile()
        {
            string path = @"C:\Users\canya\AppData\Local\Temp\OutPutFileTask0.txt";
            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            Assert.IsTrue(fileExists);
        }
    }
}
