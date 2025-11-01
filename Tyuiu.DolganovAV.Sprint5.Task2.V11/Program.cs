using Tyuiu.DolganovAV.Sprint5.Task2.V11.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #5 | Выполнил: Долганов А. В. | ПИНб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Класс File                                                        *");
        Console.WriteLine("* Задание #2                                                              *");
        Console.WriteLine("* Вариант #11                                                             *");
        Console.WriteLine("* Выполнил: Долганов Александр Витальевич | ПИНб-25-1                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая заменяет нечетные числа в матрице на 0      *");
        Console.WriteLine("* и сохраняет новый массив в текстовом файле                              *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int[,] matrix = new int[3, 3] { { 4, 9, 3 }, { 5, 8, 8 }, { 5, 7, 5 } };

        Console.WriteLine("Массив:");
        for (int i = 0; i < matrix.GetUpperBound(0) + 1; i++)
        {
            for (int j = 0; j < matrix.GetUpperBound(1) + 1; j++)
            {
                Console.Write   ($"{matrix[i, j]} \t");
            }
            Console.WriteLine();
        }

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        string path = ds.SaveToFileTextData(matrix);
        Console.WriteLine($"Файл: {path}");
        Console.WriteLine("Создан");
        Console.ReadKey();

    }
}