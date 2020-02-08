using System;
using System.Threading;

namespace StrategyConsoleWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задаем количество строк, которые будут выведены на экран.
            var count = 10;

            // Задаем задержку между выводом сообщений на консоль.
            var delay = TimeSpan.FromSeconds(1);

            // Создаем коллекцию из конкретных реализаций стратегии.
            // Обратите внимание, что мы используем тип IConsoleWriter,
            // что позволяет разместить в эту коллекцию любой класс,
            // который реализует данный интерфейс стратегии.
            var writers = new IConsoleWriter[]
            {
                new RedConsoleWriter(),
                new BlueConsoleWriter(),
                new GreenConsoleWriter()
            };

            // Простой цикл, чтобы вывести на консоль текст заданное количество раз.
            for (var i = 0; i < count; i++)
            {
                // Получаем индекс элемента из коллекции остатком от деления
                // текущего номера итерации на общее количество элементов в коллекции.
                var index = i % writers.Length;

                // Получаем конкретную реализацию стратегии.
                var writer = writers[index];

                // Подготавливаем случайный текст, который будет выведен на экран.
                var text = Guid.NewGuid().ToString();

                // Выводим текст конкретной реализацией стратегии.
                writer.WriteText(text);

                // Ждем заданный промежуток времени, чтобы выполнялось не слишком быстро.
                Thread.Sleep(delay);
            }

            // Ждем завершения.
            Console.ReadLine();
        }
    }

    /// <summary>
    /// Интерфейс стратегии.
    /// </summary>
    public interface IConsoleWriter
    {
        /// <summary>
        /// Вывод текста на консоль.
        /// </summary>
        /// <param name="text"> Выводимый текст. </param>
        void WriteText(string text);
    }

    /// <summary>
    /// Реализация стратегии вывода текста синим цветом.
    /// </summary>
    public class BlueConsoleWriter : IConsoleWriter
    {
        /// <summary>
        /// Вывод текста на консоль.
        /// </summary>
        /// <param name="text"> Выводимый текст. </param>
        public void WriteText(string text)
        {
            // Проверяем входные данные на корректность.
            if (string.IsNullOrWhiteSpace(text))
            {
                throw new ArgumentNullException(nameof(text));
            }

            // Устанавливаем синий цвет.
            Console.ForegroundColor = ConsoleColor.Blue;

            // Выводим на консоль.
            Console.WriteLine(text);
        }
    }

    /// <summary>
    /// Реализация стратегии вывода текста зеленым цветом.
    /// </summary>
    public class GreenConsoleWriter : IConsoleWriter
    {
        /// <summary>
        /// Вывод текста на консоль.
        /// </summary>
        /// <param name="text"> Выводимый текст. </param>
        public void WriteText(string text)
        {
            // Проверяем входные данные на корректность.
            if (string.IsNullOrWhiteSpace(text))
            {
                throw new ArgumentNullException(nameof(text));
            }

            // Устанавливаем зеленый цвет.
            Console.ForegroundColor = ConsoleColor.Green;

            // Выводим на консоль.
            Console.WriteLine(text);
        }
    }

    /// <summary>
    /// Реализация стратегии вывода текста красным цветом.
    /// </summary>
    public class RedConsoleWriter : IConsoleWriter
    {
        /// <summary>
        /// Вывод текста на консоль.
        /// </summary>
        /// <param name="text"> Выводимый текст. </param>
        public void WriteText(string text)
        {
            // Проверяем входные данные на корректность.
            if (string.IsNullOrWhiteSpace(text))
            {
                throw new ArgumentNullException(nameof(text));
            }

            // Устанавливаем красный цвет.
            Console.ForegroundColor = ConsoleColor.Red;

            // Выводим на консоль.
            Console.WriteLine(text);
        }
    }
}