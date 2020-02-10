namespace FactoryMethodConditionerWay2
{
    public class CoolingFactory: AirConditionerFactory
    {
        public override IAirConditioner Create(double temperature) => new Cooling(temperature);
    }
}