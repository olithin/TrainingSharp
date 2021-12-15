// See https://aka.ms/new-console-template for more information

using System.Data.Common;

abstract class Animal
{
    public abstract void Accept(IVisitor visitor);
}

internal interface IVisitor
{
    void Make(Cat cat);
    void Make(Dog dog);
    void Make(Bird bird);
}

class Cat : Animal
{
    public override void Accept(IVisitor visitor) => visitor.Make(this);
}

class Dog : Animal
{
    public override void Accept(IVisitor visitor) => visitor.Make(this);
}

class Bird : Animal
{
    public override void Accept(IVisitor visitor) => visitor.Make(this);
}

class VoiceVisitor : IVisitor
{
    public virtual void Make(Cat cat) => Console.WriteLine("May-may");
    public virtual void Make(Dog dog) => Console.WriteLine("Gav-gav");
    public virtual void Make(Bird bird) => Console.WriteLine("Chirik-chirik");
}

class MoveVisitor : IVisitor
{
    public void Make(Cat cat) => Console.WriteLine("Sneaking");
    public void Make(Dog dog) => Console.WriteLine("Running");
    public void Make(Bird bird) => Console.WriteLine("Flying");
}

//появляется новый объект
class Kiwi : Bird
{
    public override void Accept(IVisitor visitor) => visitor.Make(this);
}

class UpdateVisitor : VoiceVisitor
{
    public override void Make(Bird bird)
    {
        if (bird is Kiwi) Console.WriteLine("Kiwi-kiwi");
        else base.Make(bird);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Dog dog = new();
        Cat cat = new();
        Bird bird = new();
        var voice = new VoiceVisitor();
        var move = new MoveVisitor();

        dog.Accept(voice);
        cat.Accept(voice);
        bird.Accept(voice);

        dog.Accept(move);
        cat.Accept(move);
        bird.Accept(move);

        Console.WriteLine("\n update VoiceVisitor");
        var updateVisitor = new UpdateVisitor();
        var kiwi = new Kiwi();

        kiwi.Accept(updateVisitor);
        dog.Accept(updateVisitor);
        cat.Accept(updateVisitor);
        bird.Accept(updateVisitor);
    }
}
