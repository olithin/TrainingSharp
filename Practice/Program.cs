using System;

namespace Practice
{
    class Program
    {
        enum Days
        {
            Mon=1,
            Tusd,
            thesday
        }
        
        static void Main(string[] args)
        {
//            //тут ошибка-> мы не можем хранить тип Fish  в типе Animal (т.к Fish - это производная от Animal)
//            Fish n = new Animal();
//            n.Foo();
            
            Fish b2 = new Fish();
            b2.Foo();
            Console.WriteLine(Days.thesday);
            
            //когда мы помечаем метод vitrual -> при вызове такого метода происходит поиск переопределенных методов -> ищем сверху вниз
            Animal b3 = new Fish();
            b3.Foo();
        }
        
    }
    class Animal
    {
        public virtual void Foo()
        {
            Console.WriteLine("Class Animal");
        }
    }
    class Fish: Animal
    {
        public override void Foo()
        {
            Console.WriteLine("Class Fish");
        }
    }
}