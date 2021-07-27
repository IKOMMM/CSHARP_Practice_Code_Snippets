using System;

namespace _OOP__01
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfEmployees;


            Console.WriteLine("Welcome in Employees  Adder v.1 2019!");
            Console.WriteLine("How many employees You want to add today?");
            Console.Write("Enter number of employees: ");
            string numberOfEmployeesString = Console.ReadLine();
            int.TryParse(numberOfEmployeesString, out numberOfEmployees);

            Worker[] workers = new Worker[numberOfEmployees];

            //Enter Emplotees
            Console.WriteLine("\n------------------------------------");

            for (int i = 0; i < workers.Length; ++i)
            {
                Console.Write("\nEmployee nr: " + (i + 1));
                workers[i] = new Worker();

                Console.Write("\nEnter name: ");
                workers[i].Name = Console.ReadLine();

                Console.Write("\nEnter surname: ");
                workers[i].Surname = Console.ReadLine();

                Console.Write("\nEnter age: ");
                workers[i].Age = int.Parse(Console.ReadLine());

                Console.Write("\nEnter job position: ");
                workers[i].JobPosition = Console.ReadLine();

                Console.Write("\nEnter hourly wage(in $): ");
                workers[i].HourlyWage = float.Parse(Console.ReadLine());

            }

            //Print
            Console.WriteLine("\n------------------------------------");
            for (int i = 0; i < workers.Length; ++i)
            {
                Console.WriteLine("\nEmployee nr:  " + (i + 1));
                Console.WriteLine("Name: " + workers[i].Name);
                Console.WriteLine("Surname: " + workers[i].Surname);
                Console.WriteLine("Age: " + workers[i].Age);
                Console.WriteLine("Workplace: " + workers[i].JobPosition);
                Console.WriteLine("Hourly wage: " + workers[i].HourlyWage + "$");
            }


            Console.WriteLine("\n------------------------------------");
            if (Worker.NumberOfEmployees == 0 || Worker.NumberOfEmployees == 1)
            {
                Console.WriteLine("There is: " + Worker.NumberOfEmployees + " employee.");
            }
            else
            {
                Console.WriteLine("There are: " + Worker.NumberOfEmployees + " employees.");
            }
            Console.ReadKey();
        }
    }

    #region Class Human
    class Human
    {
        private string name;
        private int age;
        private string surname;

        public string Surname { get => surname; set => surname = value; }
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
    }
    #endregion

    #region Class Worker (Inherits from human)
    class Worker : Human
    {
        public string JobPosition { get; set; }
        public float HourlyWage { get; set; }
        public static int NumberOfEmployees { get; set; }

        public float CalculatePaycheck(int howManyHours)
        {
            return howManyHours * HourlyWage;
        }

        // Constructor 
        public Worker()
        {
            NumberOfEmployees++;
        }
    }
    #endregion
}
}
