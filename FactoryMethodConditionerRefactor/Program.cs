using System;

namespace FactoryMethodConditioner
{
    class Program
    {
        static void Main(string[] args)
        {
            AirConditioner
                .InitializeFactories()
                .ExecuteCreation(Actions.Cooling, 22.5)
                .Operate();
        }
    }
}