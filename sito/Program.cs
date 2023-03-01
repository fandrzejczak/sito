using System;

namespace sito
{
    class Program
    {
        public static bool czyPierwsza(int a)
        {
            if (a < 2)
                return false;
            for (int i = 2; i < a; i++)
            {
                if (a % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Podaj ciąg liczb oddzielając je przecinkiem.");
            string s1 = Console.ReadLine();
            string[] s2 = s1.Split(',');

            foreach (var s3 in s2)
            {
                int a = System.Int32.Parse(s3);
                bool result = czyPierwsza(a);
                if (result)
                {
                    Console.WriteLine(a);
                }
                else
                {

                }
            }
        }
    }
}
