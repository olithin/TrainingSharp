using System;

namespace Delegate
{
    class Program
    {
        delegate void Message(); // 1. Объявляем делегат

        static void Main(string[] args)
        {
            Message mes; // 2. Создаем переменную делегата
            if (DateTime.Now.Hour < 12)
            {
                mes = GoodMorning; // 3. Присваиваем этой переменной адрес метода
            }
            else
            {
                mes = GoodEvening;
            }

            mes(); // 4. Вызываем метод
            Console.ReadKey();
        }

        private static void GoodMorning()
        {
            Console.WriteLine("Good Morning");
        }

        private static void GoodEvening()
        {
            Console.WriteLine("Good Evening");
        }
    }
}