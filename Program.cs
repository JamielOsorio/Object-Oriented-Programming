using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_calculator_osorio
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int fn = 0; int sn = 0;                                   
            Console.WriteLine("Type the first number, and then press Enter");
            fn = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Type the second number, and then press Enter");
            sn = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("\n\n\n\n<===Choose an option from the following list===>");
            Console.WriteLine("1 - Add");
            Console.WriteLine("2 - Subtract");
            Console.WriteLine("3 - Multiply");
            Console.WriteLine("4 - Divide\n<=================[]===[]===[]==================>");
            Console.Write("\n\n\nEnter the number of the desired operation: ");

            
            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine($"\n\noooooooooooooooooooooooooo\n \t{fn} + {sn} = " + (fn + sn) + "\noooooooooooooooooooooooooo");
                    break;
                case "2":
                    Console.WriteLine($"\n\noooooooooooooooooooooooooo\n \t{fn} - {sn} = " + (fn - sn) + "\noooooooooooooooooooooooooo");
                    break;
                case "3":
                    Console.WriteLine($"\n\noooooooooooooooooooooooooo\n \t{fn} * {sn} = " + (fn * sn) + "\noooooooooooooooooooooooooo");
                    break;
                case "4":
                    Console.WriteLine($"\n\noooooooooooooooooooooooooo\n \t{fn} / {sn} = " + (fn / sn) + "\noooooooooooooooooooooooooo");
                    break;
            }
            
            Console.Write("");
            Console.ReadKey();


        }
    }
}
