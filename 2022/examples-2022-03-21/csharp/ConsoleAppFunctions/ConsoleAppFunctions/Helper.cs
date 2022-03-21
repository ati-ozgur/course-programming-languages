using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFunctions
{
    internal class Helper
    {

        public static void Hello(string name = "Unknown Person", string country = "Unknown Country")
        {
            Console.WriteLine("Hello " + name + " from "+ country);
        }
        public static void Hello(string name = "Unknown Person")
        {
            Console.WriteLine("Hello " +  name);
        }

        public static void Hello()
        {
            Console.WriteLine("Hello Unknown Person" );
        }

        public static void Hello2(string[] names)
        {
            foreach(string name in names)
            { 
                Console.WriteLine(name); 
            }
        }

        public static void Hello3( params string[] names)
        {
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }



        public static void HelloPrintCountriesVisited(string name, params string[] countries)
        {
            Console.Write("Hello " + name + " , you have visited");
            foreach (string country_name in countries)
            {
                Console.Write(" ," + country_name);
            }
            Console.WriteLine("");
        }

        public static string HelloCountriesVisited(string name, params string[] countries)
        {
            string message = "Hello " + name + " , you have visited";
            foreach (string country_name in countries)
            {
                message = message + " ," + country_name;
            }
            return message + "\n";
        }

    }
}
