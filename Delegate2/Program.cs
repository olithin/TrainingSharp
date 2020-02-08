using System;

namespace Delegate2
{
    class Program
    {
        delegate int Operation(int x, int y);

        static void Main(string[] args)
        {
            // присваивание адреса метода через контруктор
            
            Operation del = Add; // делегат указывает на метод Add
            int result = del(4, 5); // фактически Add(4, 5)
            Console.WriteLine(result);

            del = Multiply; // теперь делегат указывает на метод Multiply
            result = del(4, 5); // фактически Multiply(4, 5)
            Console.WriteLine(result);

            Console.Read();
        }

        private static int Add(int x, int y)
        {
            return x + y;
        }

        private static int Multiply(int x, int y)
        {
            return x * y;
        }
    }
}