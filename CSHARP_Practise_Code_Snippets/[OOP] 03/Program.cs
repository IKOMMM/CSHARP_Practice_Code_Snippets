using System;

namespace _OOP__03
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dogA = new Dog();
            dogA.Sound = ("Wof");
            
            Dog dogB = new Dog();
            dogB.Sound = ("Woof Woof");

            dogA.MakeSound();
            dogB.MakeSound();
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
}
