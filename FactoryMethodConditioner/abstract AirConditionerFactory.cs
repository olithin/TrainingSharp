namespace FactoryMethodConditionerWay2
{
    public abstract class AirConditionerFactory
    {
        public abstract IAirConditioner Create(double temperature);
    }
}