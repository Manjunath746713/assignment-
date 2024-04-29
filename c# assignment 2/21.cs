using System;

class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Animal makes a sound");
    }
}

class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Dog barks");
    }
    
    public void MakeSound(string sound)
    {
        Console.WriteLine("Dog makes " + sound);
    }
}
class Program
{
    static void Main()
    {
        Animal animal = new Animal();
        animal.MakeSound(); 
        Dog dog = new Dog();
        dog.MakeSound(); 
        dog.MakeSound("woof"); 
    }
}
