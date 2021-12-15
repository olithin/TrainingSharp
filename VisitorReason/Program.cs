interface IAnimal
{
    void Move();
    //void Sleep(); # при добавлении нового метода, необходимо во остальные классы внести новое поведение
}

class Cat : IAnimal
{
    public void Move() => Console.WriteLine("Sneaking");
}

class Dog : IAnimal
{
    public void Move() => Console.WriteLine("Running");
}

class Bird : IAnimal
{
    public void Move() => Console.WriteLine("Flying");
}

class Program
{
    static void Main(string[] args)
    {
        static void Action(IAnimal animal)
        {
            animal.Move();
        }

        var f = new List<IAnimal>
        {
            new Cat(), new Dog(), new Bird()
        };
        Action(f.First());
    }
}
