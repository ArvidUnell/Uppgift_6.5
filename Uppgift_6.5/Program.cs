using System;
namespace Uppgift_6_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Längst(345, 1339));
            Console.WriteLine(Längst("Hej dig","Hallå där"));
        }
        /// <summary>
        /// Returnerar den längsta av 2 strängar
        /// </summary>
        /// <param name="string1">Sträng 1</param>
        /// <param name="string2">Sträng 1</param>
        /// <returns>Den längsta strängen</returns>
        static string Längst(string string1, string string2)
        { 
            if (string1.Length >= string2.Length)
            {
                return string1;
            }
            return string2;
        }
        /// <summary>
        /// Returnerar det tal med flest siffror
        /// </summary>
        /// <param name="int1">Tal 1</param>
        /// <param name="int2">Tal 1</param>
        /// <returns>Talet med flest siffror</returns>
        static int Längst(int int1, int int2)
        {
            if (int1.ToString().Length >= int2.ToString().Length)
            {
                return int1;
            }
            return int2;
        }
    }
}