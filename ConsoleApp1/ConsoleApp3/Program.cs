using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int number = int.Parse(Console.ReadLine());

            try
            {
                if (number < 0)
                {
                    throw new Exception("Ввод отрицательного числа");
                }

            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
