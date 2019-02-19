/*
 * 
 * REZANINA.EMAIL@GMAIL.COM
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greetings
{
    class Program
    {
        static uint GetCount(string[] args)
        {
            uint DEFAULT_COUNT = 100;
            if (args.Length == 0)
            {
                return DEFAULT_COUNT;
            } else 
            {
                if (uint.TryParse(args[0], out uint temp))
                {
                    return temp;
                }
                else
                {
                    return DEFAULT_COUNT;
                }
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Hell World");
            Console.WriteLine("Again Hell World");

            uint count = GetCount(args);
            /*String greetings = "Hell World";
            for (uint i = 0; i < count; i++)
            {
                greetings += "again ";
            }
            greetings += "!";
            if (greetings.Length > 1)
            {
                StringBuilder sb = new StringBuilder(greetings);
                sb.Remove(greetings.Length-2, 1);
                greetings = sb.ToString();
            }*/

            StringBuilder greetings = new StringBuilder("Hell World");
            greetings.Append(" again");
            for (uint i = 0; i < count; i++)
            {
                greetings.Append(" again");
            }
            greetings.Append("!");
            
            Console.Write(greetings);
        }
    }
}
