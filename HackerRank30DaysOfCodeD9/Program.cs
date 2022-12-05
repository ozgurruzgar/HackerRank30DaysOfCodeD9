using System;
using System.IO;

namespace HackerRank30DaysOfCodeD9
{
    class Program
    {
        class Result
        {

            /*
             * Complete the 'factorial' function below. Aşağıdaki factorial metodunu tamamlayın. 
             *
             * The function is expected to return an INTEGER. Metod int değer döndürsün.
             * The function accepts INTEGER n as parameter. Metod int parametre alsın.
             */

            public static int factorial(int n)
            {
                if (n == 1)
                {
                    return 1;
                }
                else
                {
                    return n * factorial(n - 1);
                }
            }

        }

        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            int result = Result.factorial(n);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
