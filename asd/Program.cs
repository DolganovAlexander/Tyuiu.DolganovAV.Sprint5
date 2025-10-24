internal class Program
{
    private static void Main(string[] args)
    {










        string outputFile3 = "OutPutFileTaskX3.txt";
        double x3 = 0;
        double res3 = Math.Pow(x3, 4) - 2 * Math.Pow(x3, 3) + 3 * Math.Pow(x3, 2) - 4 * x3 + 5;
        File.AppendAllText(outputFile3, res3.ToString());

        string outputFile4 = "OutPutFileTaskX4.txt";
        double x4 = 1;
        double res4 = 5 * Math.Pow(x4, 2) + 2 * x4 - 1;
        File.AppendAllText(outputFile4, res4.ToString());





        string outputFile6 = "OutPutFileTaskX6.txt";
        double x6 = 4;
        double res6 = 2 * Math.Pow(x6, 4) - 3 * Math.Pow(x6, 3) + 5 * Math.Pow(x6, 2) - 6 * x6 + 1;
        File.AppendAllText(outputFile6, res6.ToString());

        string outputFile7 = "OutPutFileTaskX7.txt";
        double x7 = -3;
        double res7 = Math.Pow(x7, 3) + 2 * Math.Pow(x7, 2) - 3 * x7 + 4;
        File.AppendAllText(outputFile7, res7.ToString());

        string outputFile8 = "OutPutFileTaskX8.txt";
        double x8 = 1;
        double res8 = 4 * Math.Pow(x8, 3) - 5 * Math.Pow(x8, 2) + 6 * x8 - 7;
        File.AppendAllText(outputFile8, res8.ToString());

        string outputFile2 = "OutPutFileTaskX2.txt";
        double x2 = -1;
        double res2 = 2 * Math.Pow(x2, 3) + 5 * Math.Pow(x2, 2) - 3 * x2 + 1;
        File.AppendAllText(outputFile2, res2.ToString());

        string outputFile10 = "OutPutFileTaskX10.txt";
        double x10 = 5;
        double res10 = Math.Pow(x10, 4) - 4 * Math.Pow(x10, 3) + 6 * Math.Pow(x10, 2) - 8 * x10 + 10;
        File.AppendAllText(outputFile10, res10.ToString());

        string outputFile1 = "OutPutFileTaskX1.txt";
        double x1 = 3;
        double res1 = 4 * Math.Pow(x1, 2) - 3 * x1 + 2;
        File.AppendAllText(outputFile1, res1.ToString());

        string outputFile9 = "OutPutFileTaskX9.txt";
        double x9 = -2;
        double res9 = 2 * Math.Pow(x9, 2) + 3 * x9 - 4;
        File.AppendAllText(outputFile9, res9.ToString());

        string outputFile5 = "OutPutFileTaskX5.txt";
        double x5 = -2;
        double res5 = 3 * Math.Pow(x5, 3) + 4 * Math.Pow(x5, 2) - 2 * x5 + 7;
        File.AppendAllText(outputFile5, res5.ToString());


    }
}