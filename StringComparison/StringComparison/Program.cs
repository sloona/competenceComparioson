using System;
using System.Text.RegularExpressions;

namespace StringComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstString = "2C 35П 2Э";
            string secondString = "15П 1Э";

            Console.WriteLine($"{firstString} > {secondString} {Comparison(firstString, secondString)}");

            Console.ReadKey();
        }

        static int GetСompetence(string competenceType, string inpuString)
        {
            string pattern = string.Format(@"(\d+)({0})", competenceType);
            var match = Regex.Match(inpuString, @pattern);
            return match.Success ? Convert.ToInt16(match.Groups[1].Value) : 0;
        }

        static bool Comparison(string firstString, string secondString)
        {
            int[] s1 = new int[] { GetСompetence("Э", firstString), GetСompetence("П", firstString), GetСompetence("С", firstString) };
            int[] s2 = new int[] { GetСompetence("Э", secondString), GetСompetence("П", secondString), GetСompetence("С", secondString) };


            
                       for (int i = 0; i < 2; i++)
                       {
                           if (s1[i] > s2[i]) { return true; }
                           if (s1[i] < s2[i]) { return false; }
                       }
               
            return false;
        }
    }
}
