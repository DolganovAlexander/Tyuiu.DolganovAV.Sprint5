using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.DolganovAV.Sprint5.Task5.V28.Lib
{
    public class DataService : ISprint5Task5V28
    {
        public double LoadFromDataFile(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] numbers = line.Split(' ');
                    int minNubmer = int.MaxValue;

                    foreach (string numberStr in numbers)
                    {
                        if (double.TryParse(numberStr, out double number))
                        {
                            if (number > 0)
                            {
                                int numberInt = (int)number;
                                if (numberInt % 5 == 0 && numberInt < minNubmer) minNubmer = numberInt;
                            }
                        }
                    }

                    if (minNubmer != int.MaxValue)
                    {
                        double res = 1;
                        for (int i = 1; i <= minNubmer; i++)
                        {
                            res *= i;
                        }
                        return res;
                    }
                }
            }
            return -1;
        }
    }
}
