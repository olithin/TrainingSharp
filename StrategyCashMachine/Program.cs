using System;
using System.Collections.Generic;

namespace StrategyCashMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            var moneyReceived = new CashMachine(20, new Dollar());
            var result = moneyReceived.Calculate();
            Console.WriteLine(result);
        }

        //Context
        public class CashMachine
        {
            private readonly int _amount;

            private ICalculationCurrency Strategy { get; set; }

            public CashMachine(int amount, ICalculationCurrency strategy)
            {
                _amount = amount;
                Strategy = strategy;
            }

            public int Calculate()
            {
                return Strategy.CalculateCurrency(_amount);
            }
        }

        public interface ICalculationCurrency
        {
            int CalculateCurrency(int amount);
        }

        public class Dollar : ICalculationCurrency
        {
            public int CalculateCurrency(int amount)
            {
                Console.WriteLine("Calculate Dollar");
                return +amount * 2;
            }
        }

        public class Euro : ICalculationCurrency
        {
            public int CalculateCurrency(int amount)
            {
                Console.WriteLine("Calculate Euro");
                return +amount * 6;
            }
        }
    }
}