using System;

namespace MultilevelInheritanceDemo
{
    // Base class
    class Animal
    {
        public virtual void Sound()
        {
            Console.WriteLine("Animals make sounds.");
        }
    }

    // Derived class from Animal
    class Mammal : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("Mammals make different sounds.");
        }
    }

    // Further derived class from Mammal
    class Dog : Mammal
    {
        public override void Sound()
        {
            Console.WriteLine("Dogs bark.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Creating an object of Dog class
            Dog dog = new Dog();
            dog.Sound();

            // Creating an object of Mammal class
            Mammal mammal = new Mammal();
            mammal.Sound();

            // Creating an object of Animal class
            Animal animal = new Animal();
            animal.Sound();

            // Demonstrating polymorphism
            Animal polymorphicDog = new Dog();
            polymorphicDog.Sound();

            Animal polymorphicMammal = new Mammal();
            polymorphicMammal.Sound();
        }
    }
}
