using System.Data.Common;
using Tyuiu.DolganovAV.Sprint5.Task0.V8.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #5 | Выполнил: Долганов А. В. | ПИНб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Класс File                                                        *");
        Console.WriteLine("* Задание #0                                                              *");
        Console.WriteLine("* Вариант #8                                                              *");
        Console.WriteLine("* Выполнил: Долганов Александр Витальевич | ПИНб-25-1                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая вычисляет значение выражения и сохраняет    *");
        Console.WriteLine("* результат в текстовый файл                                              *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int x = 3; Console.WriteLine($"x = {x}");

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        string res = ds.SaveToFileTextData(x);
        Console.WriteLine($"Файл: {res}");
        Console.WriteLine("Создан");
        Console.ReadKey();
    }
}