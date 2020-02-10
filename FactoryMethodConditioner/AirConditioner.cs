using System.Collections.Generic;

namespace FactoryMethodConditionerWay2
{
    public class AirConditioner
    {
        private readonly Dictionary<Actions, AirConditionerFactory> _factories;
        public AirConditioner()
        {
            _factories = new Dictionary<Actions, AirConditionerFactory>
            {
                { Actions.Cooling, new CoolingFactory() },
                { Actions.Warming, new WarmingFactory() }
            };
        }
        public IAirConditioner ExecuteCreation(Actions action, double temperature) =>_factories[action].Create(temperature);

    }
}