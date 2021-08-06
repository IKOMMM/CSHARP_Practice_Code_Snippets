using System;

namespace _OOP__03
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dogA = new Dog();
            Dog dogB = new Dog();
            Cat cat = new Cat();

            cat.AnimalAge();
            cat.HowManyLegs();
            dogA.Sound = ("Wof");
            dogB.Sound = ("Woof Woof");
            dogA.MakeSound();
            dogB.MakeSound();

            Console.WriteLine(cat.Age);
            Console.ReadKey();
        }
    }

    #region Interfaces
    interface IMakingSound
    {
        void MakeSound();
    }

    interface ILand
    {
        void HowManyLegs();
    }

    #endregion
    abstract class Animal
    {
        public uint Age { get; set; } = 0;
        public void AnimalAge()
        {
            ++Age;
        }
    }

    class Dog : IMakingSound, ILand
    {
        public string Sound { get; set; }
        public void MakeSound()
        {
            Console.WriteLine(Sound);
        }
        public void HowManyLegs()
        {
            Console.WriteLine("Dog Has 4 legs");
        }
    }

    class Cat : Animal, ILand
    {
        public string Sound { get; set; }
        public void HowManyLegs()
        {
            Console.WriteLine("Cat Has 4 legs");
        }
    }
}
