using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.DolganovAV.Sprint5.Task6.V5.Lib
{
    public class DataService : ISprint5Task6V5
    {
        public int LoadFromDataFile(string path)
        {
            string content = File.ReadAllText(path);
            int res = 0;
            foreach (char c in content)
            {
                if (char.IsUpper(c) && (c >= 'A' && c <= 'Z')) res += 1;
            }
            return res;
        }
    }
}
