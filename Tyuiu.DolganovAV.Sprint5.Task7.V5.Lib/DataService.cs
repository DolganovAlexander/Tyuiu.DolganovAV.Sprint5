using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.DolganovAV.Sprint5.Task7.V5.Lib
{
    public class DataService : ISprint5Task7V5
    {
        public string LoadDataAndSave(string path)
        {
            string output = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V5.txt");
            string content = File.ReadAllText(path);
            string res = Regex.Replace(content, "[a-zA-z]", "");
            File.WriteAllText(output, res);
            return output;
        }
    }
}
