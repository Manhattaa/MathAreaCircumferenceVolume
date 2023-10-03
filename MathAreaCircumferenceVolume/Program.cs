using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleCircumferenceAreaVolume //Fady Hatta .NET23
{
    class Circle
    {
        private double radius; //en privat instansvariabel för radien. Private gör så delar av denna kod inte kan komma åt radius värdet.

        public Circle(double radius)
        {
            this.radius = radius; // En konstruktor som tar en radie som en parameter som sen tilldelar det till variabeln
        }

        public double GetArea() //baserat på radien så returneras cirkelns area
        {
            return Math.PI * Math.Pow(radius, 2); //Math.PI = Pi värdet (3,14..) Math.Pow = to the power of- och höjer upp radien med 2. (radie^2)
        }
        public double GetCircumference() //omkrets
        {
            return 2 * Math.PI * radius;
        }
        public double GetVolume() //volym
        {
            //volymen för en sfär = (4/3) * PI * radie^3
            return (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);
        }
    }

    class Triangle
    {
        private double baseLength;
        private double height;

        public Triangle(double baseLength, double height)
        {
            this.baseLength = baseLength;
            this.height = height;
        }

        public double GetArea()
        {
            return 0.5 * baseLength * height;
        }
        public double GetPerimeter()
        {
            //3x Längd = omkrets av en triangel, vi använder en vinkelrät triangel här
            //en perimeter finner man oftast i en metod. exempel: int sum = a + b + c; (där a+b+c är perimetrar i detta fall)
            double sideLength = Math.Sqrt(Math.Pow(baseLength / 2, 2) + Math.Pow(height, 2));
            double perimeter = baseLength + 2 * sideLength;
            return perimeter;
        }
    }
    class Cone
    {
        private double radius;
        private double height;

        public Cone(double radius, double height)
        {
            this.radius = radius;
            this.height = height;
        }
        public double GetVolume()
        {
            //((1/3) * (pi * r^2) * h) = volymen av en kon
            return (1.0 / 3.0) * Math.PI * Math.Pow(radius, 2) * height;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.OutputEncoding = System.Text.Encoding.Unicode;
                Console.InputEncoding = System.Text.Encoding.Unicode;
                Console.WriteLine("Välj en form att beräkna (1. Cirkel1 2. Cirkel2 3. Triangel 4. Kon 0. Avsluta)");
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":

                        Circle circle1 = new Circle(5);

                        double circle1Area = circle1.GetArea();
                        double circle1Circumference = circle1.GetCircumference();
                        double circle1Volume = circle1.GetVolume();

                        Console.WriteLine("\nCirkel 1:");
                        Console.WriteLine("5 cm i Radie");
                        Console.WriteLine(" - Area: " + circle1Area);
                        Console.WriteLine(" - Omkrets: " + circle1Circumference);
                        Console.WriteLine(" - Sfärens volym: " + circle1Volume);

                        // Skapa en sfär för cirkel 1
                        Console.WriteLine("\nSfär för Cirkel 1:");
                        Console.WriteLine("5 cm i Radie");
                        Console.WriteLine(" - Volym: " + circle1Volume);
                        Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⣀⣀⣀⣀⣀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⢀⣠⠶⠞⠛⠋⠉⠉⠉⠉⠙⠛⠳⠶⣄⡀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⣠⡾⠋⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠙⢷⣄⠀⠀⠀⠀⠀\r\n⠀⠀⠀⢀⡾⠋⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠙⢷⡀⠀⠀⠀\r\n⠀⠀⢠⡞⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢳⡄⠀⠀\r\n⠀⠀⣾⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⣷⠀⠀\r\n⠀⢸⡏⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢹⡇⠀\r\n⠀⢸⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⡇⠀\r\n⠀⢸⣇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣸⡇⠀\r\n⠀⠀⢿⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⡿⠀⠀\r\n⠀⠀⠘⢧⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡼⠃⠀⠀\r\n⠀⠀⠀⠈⢷⣄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣠⡾⠁⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠙⢷⣄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣠⡾⠋⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠈⠙⠶⢦⣤⣄⣀⣀⣀⣀⣠⣤⡴⠶⠋⠁⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠉⠉⠉⠉⠉⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
                        break;

                    case "2":

                        Circle circle2 = new Circle(6);

                        double circle2Area = circle2.GetArea();
                        double circle2Circumference = circle2.GetCircumference();
                        double circle2Volume = circle2.GetVolume();

                        Console.WriteLine("\nCirkel 2:");
                        Console.WriteLine("6 cm i Radie");
                        Console.WriteLine(" - Area: " + circle2Area);
                        Console.WriteLine(" - Omkrets: " + circle2Circumference);
                        Console.WriteLine(" - Sfärens volym: " + circle2Volume);

                        // Skapa en sfär för cirkel 2
                        Console.WriteLine("\nSfär för Cirkel 2:");
                        Console.WriteLine("6 cm i Radie");
                        Console.WriteLine(" - Volym: " + circle2Volume);
                        Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⣀⣀⣀⣀⣀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⢀⣠⠶⠞⠛⠋⠉⠉⠉⠉⠙⠛⠳⠶⣄⡀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⣠⡾⠋⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠙⢷⣄⠀⠀⠀⠀⠀\r\n⠀⠀⠀⢀⡾⠋⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠙⢷⡀⠀⠀⠀\r\n⠀⠀⢠⡞⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢳⡄⠀⠀\r\n⠀⠀⣾⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⣷⠀⠀\r\n⠀⢸⡏⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢹⡇⠀\r\n⠀⢸⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⡇⠀\r\n⠀⢸⣇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣸⡇⠀\r\n⠀⠀⢿⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⡿⠀⠀\r\n⠀⠀⠘⢧⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡼⠃⠀⠀\r\n⠀⠀⠀⠈⢷⣄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣠⡾⠁⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠙⢷⣄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣠⡾⠋⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠈⠙⠶⢦⣤⣄⣀⣀⣀⣀⣠⣤⡴⠶⠋⠁⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠉⠉⠉⠉⠉⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
                        break;

                    case "3":
                        Triangle triangle = new Triangle(3, 5);

                        double triangleArea = triangle.GetArea();
                        double trianglePerimeter = triangle.GetPerimeter();

                        Console.WriteLine("\nTriangel:");
                        Console.WriteLine(" - Area: " + triangleArea);
                        Console.WriteLine(" - Omkrets: " + trianglePerimeter);
                        Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣾⢷⡄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡾⠃⠀⢻⡄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⡾⠀⠀⠀⠀⠻⣄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣰⡟⠁⠀⠀⠀⠀⠀⠸⢦⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣼⠏⠀⠀⠀⠀⠀⠀⠀⠀⠈⣷⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣾⠃⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠨⣷⡄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⡾⠟⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠋⠿⣆⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣠⣿⡧⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠐⠸⣽⣆⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣰⠟⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠉⣇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⣼⠏⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⣷⡀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⢀⣾⠃⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢺⣄⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⢠⡾⠃⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠹⣆⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⢠⡞⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠹⣆⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⣰⠟⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠘⣧⠀⠀⠀⠀\r\n⠀⠀⢀⣾⠋⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⢳⣄⠀⠀\r\n⠀⢀⡾⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢹⣄⠀\r\n⢰⡿⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡽⣦\r\n⠙⠿⠿⠛⠛⠛⠛⠛⠛⠛⠛⠛⠛⠛⠛⠛⠛⠛⠛⠛⠛⠛⠛⠛⠛⠛⠛⠛⠓⠚⠚⠛⠛⠛⠚⠛⠚⠒⠾⠾⠿⠿");
                        break;

                    case "4":
                        Cone cone = new Cone(3, 5);

                        double coneVolume = cone.GetVolume();

                        Console.WriteLine("\nKon:");
                        Console.WriteLine(" - Volym: " + coneVolume);
                        Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣠⣄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣿⣿⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣼⣿⣿⣧⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠉⠉⠉⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⣤⣄⣀⣀⣠⣤⡄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣸⣿⣿⣿⣿⣿⣿⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠻⠿⢿⣿⣿⡿⠿⠟⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⣸⣿⣶⣤⣤⣤⣤⣤⣤⣶⣿⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⣀⣠⣤⡖⠀⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠀⢶⣤⣄⣀⠀⠀⠀⠀\r\n⠀⠀⠀⠉⠙⠻⢿⣿⡀⠛⢿⣿⣿⣿⣿⣿⣿⣿⣿⡿⠛⢀⣿⡿⠟⠋⠉⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠉⠁⠢⠤⣤⣀⣈⣁⣀⣤⠤⠔⠈⠉⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠉⠛⠛⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
                        break;


                    case "0":
                        Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⣀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⠞⠉⠉⢳⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⡀⠀⠀⣠⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠙⡖⢾⠋⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⠁⠸⡄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡞⠀⠀⣇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢰⠒⠒⠒⠒⠒⠒⠲⠲⠚⠓⠒⠒⠛⠓⢒⣖⠒⠒⠒⠒⠒⠒⢲⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣼⠀⠀⠀⠀⢠⠖⠋⠉⠷⣄⠀⠀⢠⠖⠉⠉⠑⢦⠀⠀⠀⠀⢸⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡟⠉⢻⠀⠀⠀⠀⣿⣾⣿⣦⡀⢸⠀⠀⢿⣿⣿⣷⡀⢸⠀⠀⠀⠀⢸⠋⠙⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡇⠀⢸⠀⣀⠀⠀⠘⢿⣿⢟⣂⠞⠀⠀⠈⠿⣿⣿⣡⠞⠀⠀⠀⠀⢸⠀⠀⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡇⣾⠉⠉⠙⢧⡀⠀⠀⠉⠉⠁⠀⠀⠀⠀⠀⠈⠉⠀⠀⠀⣠⠞⠉⠉⡙⣇⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠉⣻⠀⠀⠀⠀⠙⢦⣀⣀⣀⣀⣀⣀⣀⣀⣀⣀⣀⣀⣠⠞⠁⠀⠀⠀⠇⡏⠃⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠿⡤⣤⣤⣤⣤⣤⣤⣤⣤⣤⢤⠤⠤⠤⠤⢤⣤⣤⣤⣤⣤⣤⡤⢤⣤⠇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⡴⠟⠛⠦⣄⡀⣀⣿⡛⣛⣛⣛⢛⢛⢛⣷⣀⣀⣴⢛⡛⠶⡄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡟⠀⠀⣿⣩⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⢿⢭⡉⡇⠀⠸⣆⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣸⡇⠀⠀⣿⣽⠀⠀⣶⡆⠀⠀⠀⠀⠀⢠⡄⠀⠀⠀⢠⣇⡇⠀⢀⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣰⠃⠘⢦⣰⣿⣿⠀⢰⡿⡇⣄⠀⠀⠀⠀⣼⣇⣠⠀⠀⢸⣿⣇⡠⠞⠈⢧⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⣰⡃⠀⠀⢠⠟⣿⣿⠤⠾⠀⢻⠛⡄⢰⠤⠽⠏⣿⡟⡷⠶⢼⡿⡟⢆⠀⠀⠈⣣⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⢠⡟⠛⠦⣴⠏⠀⣿⣼⠀⠀⠀⠀⠀⢻⡞⠀⠀⠀⠻⠇⠀⠀⠀⡇⡇⠈⢷⡴⠚⠙⣆⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⢀⡴⠿⢦⣀⡾⠁⠀⠀⣿⢾⣀⣀⣀⣀⣀⣀⣁⣀⣀⣀⣀⣀⣀⣀⣠⣷⡇⠀⠈⠻⣄⡰⠾⠶⣄⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⣀⣤⡴⣟⠀⠀⠀⣹⠀⠀⠀⠰⣿⣈⡿⢯⡉⣿⣿⣿⣿⣿⣿⣿⣿⡏⢉⡿⢯⣀⡇⠀⠀⠀⢿⠀⠀⠀⢸⡦⣤⣄⠀⠀⠀\r\n⠀⢀⡴⠋⠀⠁⠹⣤⣀⡤⠏⠀⠀⠀⠐⣿⠹⣄⡼⠟⣿⣿⣿⣿⣿⣿⣿⣿⡶⠻⣶⡴⠿⡇⠀⠀⠀⠘⢦⣀⣠⠞⠃⠀⠈⠳⡀⠀\r\n⢠⡟⠀⢠⡶⣄⠀⠀⢸⠀⠀⠀⠀⠀⠘⢿⣤⣼⣤⣤⣤⣶⣧⣶⣦⣶⣴⣦⣤⣤⣴⣤⣤⡇⠀⠀⠀⠀⠀⣼⠀⠀⣀⠶⣄⠀⠹⡄\r\n⠸⣇⡴⠋⢠⠞⠀⣰⠟⠁⠀⠀⠀⠀⠀⠀⢿⡀⠀⠀⠀⠀⣨⡷⠀⢺⣆⢀⠀⠀⠀⢀⡽⠀⠀⠀⠀⠀⠀⠹⣄⠀⠹⣄⠈⢳⣠⠇\r\n⠀⠙⠁⣴⣋⣀⡴⠋⠀⠀⠀⠀⠀⠀⠀⠀⣼⠋⠉⠉⠉⠉⠙⣦⡠⣶⠋⠉⠉⠉⠉⠉⢳⠄⠀⠀⠀⠀⠀⠀⠈⠣⣀⣙⣦⡀⠛⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣹⠖⠖⠲⠒⠒⠿⣇⡀⣨⠗⠒⠒⠒⠒⠲⣯⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠉⠉⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢹⣤⠤⠤⢴⢶⣶⡟⠂⢙⡦⠤⠤⢤⣤⣤⡟⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⡤⠖⠛⠚⠛⠚⠓⠲⢤⡷⠀⣻⠦⠖⠒⠛⠛⠛⠛⠒⠤⣀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⡞⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⣧⠀⣺⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠳⡄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⣀⣀⣀⣀⣀⣀⣀⣀⣀⣀⣀⣿⠁⢻⣄⣀⣀⣀⣀⣀⣀⣀⣀⣀⣀⣹⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
                        Console.WriteLine("Beep-Boop-Beep, Programmet avslutas.");
                        return;

                    default:
                        Console.WriteLine("Ogiltigt! Välj mellan 0-4");
                        break;
                }
            }
        }
    }
}