using System;

namespace _OOP__02
{
    class Program
    {        
        static void Main(string[] args)
        {

            string selectedFigureEnterd;
            string selectedFigureUpper;
            string aText, bText, cText;

            Square square = new Square();
            Rectangle rectangle = new Rectangle();//Also Parallelogram
            Triangle triangle = new Triangle();
            Trapeze trapeze = new Trapeze();
            Circle circle = new Circle();

            Console.WriteLine(
                "Welcome in geometric fields calculator v.1!" +
                "\nWhich geometric figure are you interested in?:" +
                "\nSquare [SQU]\nRectangle [REC]\nTriangle [TRI]\nTrapeze [TRA]\nParallelogram [PAR]\nCircle [CIR]" +
                "\nType shortcut form '[]' to choose:");

            //Upper text to avoid problems
            selectedFigureEnterd = Console.ReadLine();
            selectedFigureUpper = selectedFigureEnterd.ToUpper();

            Console.WriteLine("------------------------------------");

            switch (selectedFigureUpper)
            {
                case ("SQU"):
                    Console.Write("Enter the length of the side of the square: ");
                    aText = Console.ReadLine();
                    Console.WriteLine("Square field: " + square.Field(int.Parse(aText)));
                    break;
                case ("REC"):
                    Console.Write("Enter the first length of the side of the rectangle: ");
                    aText = Console.ReadLine();
                    Console.Write("Enter the second length of the side of the rectangle: ");
                    bText = Console.ReadLine();
                    Console.WriteLine("Rectangle field: " + rectangle.Field(int.Parse(aText), int.Parse(bText)));
                    break;
                case ("TRI"):
                    Console.Write("Enter the length of the side of the triangle: ");
                    aText = Console.ReadLine();
                    Console.Write("Enter the length of the height of the triangle: ");
                    bText = Console.ReadLine();
                    Console.WriteLine("Triangle field: " + triangle.Field(int.Parse(aText), int.Parse(bText)));
                    break;
                case ("TRA"):
                    Console.Write("Enter the first length of the side of the trapeze: ");
                    aText = Console.ReadLine();
                    Console.Write("Enter the second length of the side of the trapeze: ");
                    bText = Console.ReadLine();
                    Console.Write("Enter the length of the height of the trapeze: ");
                    cText = Console.ReadLine();
                    Console.WriteLine("Trapeze field: " + triangle.Field(int.Parse(aText), int.Parse(bText), int.Parse(cText)));
                    break;
                case ("PAR"):
                    Console.Write("Enter the length of the side of the parallelogram: ");
                    aText = Console.ReadLine();
                    Console.Write("Enter the length of the height of the parallelogram: ");
                    bText = Console.ReadLine();
                    Console.WriteLine("Parallelogram field: " + rectangle.Field(int.Parse(aText), int.Parse(bText)));
                    break;
                case ("CIR"):
                    Console.Write("Enter the radious of the Circle: ");
                    aText = Console.ReadLine();
                    Console.WriteLine("Circle field: " + circle.Field(int.Parse(aText)));
                    break;
                default:
                    Console.WriteLine("The figure symbol is unknown. Try Again!");
                    break;
            }

            Console.WriteLine("------------------------------------");

            Console.ReadKey();
        }           
    }
    #region Interface Figure
    interface IFigure
    {
        float Field(float a, float b, float c);        
    }
    #endregion

    #region Figure Classes
    class Square : IFigure
    {
         public float Field(float a, float b = 0f, float c = 0f)
        {
            return a*a;
        }

    }

    class Rectangle : IFigure
    {
        public float Field(float a, float b, float c = 0f)
        {
            return a * b;
        }
    }  

    class Triangle : IFigure
    {
        public float Field(float a, float b, float c=0)
        {
            return (a*b)/2;
        }
    }
    class Trapeze : IFigure
    {
        public float Field(float a, float b, float c)
        {
            return ((a+b)*c)/2;
        }
    }
    class Circle : IFigure
    {
        public float Field(float a, float b=0, float c=0)
        {
            return (a * a) * MathF.PI;
        }
    }
    #endregion
}
