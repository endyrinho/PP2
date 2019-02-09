using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program

    {
        public static bool getStatus(string myString)
        {
            int length = myString.Length;
            for (int i = 0; i < length / 2; i++)
            {

                if (myString[i] != myString[length - i - 1])
                    return false;
            }
            return true;


        }
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            if (getStatus(s) == true)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
            Console.ReadKey();
        }
    }
}
 

