using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_key_system
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Key: ");
            string a = Console.ReadLine();
            bool key = a == "123";



            // if u wanna add more keys do this
            //-------------------------------
            //string a2 = Console.ReadLine();
            //bool key2 = a2 == "123
            //-------------------------------
            if (key /*|| key2  */)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Correct");


            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong");
         
            }
            Console.ReadKey();
        }
    }
}
