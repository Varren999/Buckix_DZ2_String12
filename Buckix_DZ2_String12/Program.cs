//=================================================================================================
//  Дана непустая строка S и целое число N (>0). Вывести строку, содержащую символы строки S,
//  между которыми вставлено по N символов «*» (звездочка).
//=================================================================================================
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buckix_DZ2_String12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = 0;
            string text = "";
            bool cycle = true;
            Console.WriteLine("Вывести строку, содержащую символы строки S, между которыми вставлено по N символов «*» (звездочка).");
            while (cycle)
            {
                cycle = false;
                try
                {
                    Console.Write("Введите строку:");
                    text = Console.ReadLine();
                    Console.Write("Введите число N:");
                    N = Convert.ToInt32(Console.ReadLine());
                }
                catch(Exception ex) 
                {
                    cycle = true;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                    Console.ResetColor();
                }
            }
            Console.WriteLine(InsertStars(text, N));
            Console.ReadKey();
        }

        static string InsertStars(string text, int num)
        {
            string stars = "";
            if (num < 1)
                return text;
            for(int i = 0; i < num; i++)
                stars += "*";
            return string.Join(stars, text.ToCharArray());
        }
    }
}
