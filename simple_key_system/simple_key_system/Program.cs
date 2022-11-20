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
            string one = Console.ReadLine();
            bool key = one == "123";



            // if u wanna add more keys do this
            //-------------------------------
            //string two2 = Console.ReadLine();
            //bool key2 = two2 == "123
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
