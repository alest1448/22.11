using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите 2 числа");
                int x = Convert.ToInt32(Console.ReadLine());
                int y = Convert.ToInt32(Console.ReadLine());
                int z = x / y;
                Console.WriteLine($"Результат: {y}");
            }
            catch
            {
                Console.WriteLine("Возникло исключение!");
            }
            finally
            {
                Console.WriteLine("------------");
            }
            Console.WriteLine("Конец программы");
        }

    }
}
