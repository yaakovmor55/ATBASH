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
            Console.WriteLine("Hey this is main");
            string SecretMeassege = "Lfi ulixvh.\n" +
                "\nGsv ilxpvg fmrgh ziv ivzwb zmw dzrgrmt uli gsv hrtmzo.\nYlnyh szev yvvm kozxvw mvzi pvb olxzgrlmh." +
                "\nMfpsyz urtsgvih ziv hgzmwrmt yb uli tilfmw rmurogizgrlm." +
                "\nGsv zggzxp droo yv hfwwvm zmw hgilmt -- gsvb dlm’g hvv rg xlnrmt." +
                "\nDv nfhg hgzb srwwvm zmw pvvk gsv kozm hvxivg fmgro gsv ozhg nlnvmg." +
                "\nErxglib rh mvzi. Hgzb ivzwb.";
            Printmeassge(DangerousWordes(SecretMeassege), disc(SecretMeassege));
            Console.ReadKey();
            Console.WriteLine("hello");
        }


        static string disc(string str_input)
        {
            string output = "";
            str_input = str_input.ToLower();
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

        static int DangerousWordes(string message)
        {
            message = disc(message);
            List<String> MessageList = message.Split().ToList();
            List<string> Dangerous = new List<string>() { "bomb", "nukhba", "fighter", "rocket", "secret", "bombs", "fighters", "rocketes" };
            int points = 0;

            foreach (string str in MessageList)
            {
                if (Dangerous.Contains(str))
                {
                    points++;
                }
            }


            return points;
        }

        static void Printmeassge(int points, string meassege)
        {

            if (points >= 1 && points <= 5)
            {
                meassege += "\n WARNING" + " " + points;
            }
            else if (points >= 6 && points <= 10)
            {
                meassege += "\n DANGER" + " " + points;
            }
            else if (points >= 11 && points <= 15)
            {
                meassege += "\n ULTRA ALERT" + " " + points;
            }
            Console.WriteLine(meassege);



        }
    }
}


