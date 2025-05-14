using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atbash_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(disc("abckjgl lfl90"));
            Console.WriteLine();
        }


        static string disc(string str_input)
        {
            string output = "";
            str_input.ToLower();
            foreach (char item in str_input)
            {
                if (char.IsLetter(item))
                {
                    int asciivalue = (int)item;
                    int resulte = 97 + 122 - asciivalue;
                    output += (char)resulte;
                }
                else
                {
                    output += (char)item;
                }



            }
            return output;
        }
    }
}


