using System;

public abstract class Animal
{
    public abstract void makesound();
}
public class Dog : Animal
{
    public override void makesound()
    {
        Console.WriteLine("eeee");
    }
}
class Program
{
    static void main(string[] args)
    {
        Dog dog = new Dog();
        dog.makesound();
    }
}