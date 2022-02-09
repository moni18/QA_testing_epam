using System;
using System.Linq;

namespace NumberSystem
{
    class Program
    {
        static void Main(string[] args)
        {           
            string n = Console.ReadLine();
            int num = Convert.ToInt32(n);

            string c= Console.ReadLine();
            int count = Convert.ToInt32(c);

            if (count == 2)
            {
                Console.WriteLine(ChangeNumberTo2(num));
            }
            else if (count == 8)
            {
                Console.WriteLine(ChangeNumberTo8(num));
            }
            else if (count == 16)
            {
                Console.WriteLine(ChangeNumberTo16(num));
            }
        }        
        static string ChangeNumberTo2(int num)
        {
            string s = Convert.ToString(num, 2);
            return s;
        }        
        static string ChangeNumberTo8(int num)
        {            
            string s = Convert.ToString(num, 8);
            return s;
        }
        static string ChangeNumberTo16(int num)
        {      
            string s = Convert.ToString(num, 16);
            return s;
        }


    }
}
