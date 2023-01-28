/*
2    * Author: Robert Xavier LeftRidge
3    * Course: COMP-003A
4    * Purpose: Lecture activity for variables, type system, Math, and Console properties
5    * Reference: The C# Player's Guide (4e) by RB Whitaker
6   */

namespace COMP003A.Assignment 
{

        class Program
        {

                static void Main(string[ ] args)
                {
                    Console.Title = "COMP-003A - Assignment 2";
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.ForegroundColor = ConsoleColor.White;


                    string firstName;
                    Console.Write("Enter First Name:");
                    firstName = Console.ReadLine();


                    string middleName;
                    Console.Write("Enter Middle Name:");
                    middleName = Console.ReadLine();


                    string LastName;
                    Console.Write("Enter Last Name:");
                    LastName = Console.ReadLine();

                    string inputAge;
                    Console.Write("Enter age in 2023:");
                    inputAge = Console.ReadLine();

                    int yearBorn = 2023 - Convert.ToInt32(inputAge);

                    Console.WriteLine($"Hello, {firstName} {middleName} {LastName}.You were born in {yearBorn}.");

                    string integer1;
                    Console.Write("Enter an integer for integer1:");
                    integer1 = Console.ReadLine();
                    int  one = Convert.ToInt32(integer1);
                  
                    string integer2;
                    Console.Write("Enter an integer for integer2:");
                    integer2= Console.ReadLine();
                    int two = Convert.ToInt32(integer2);

                   Console.WriteLine($"{one} + {two} = {one + two}");
                   Console.WriteLine($"{one} - {two} = {one - two}");
                   Console.WriteLine($"{one} * {two} = {one * two}");
                   Console.WriteLine($"{one} / {two} = {one / two}");
                   Console.WriteLine($"{one} % {two} = {one % two}");
                
                    string circle;
                    Console.Write("Enter radius:");
                    circle = Console.ReadLine();

                    double radius = Convert.ToDouble(circle);

                    double area = Math.PI * Math.Pow(radius, 2);
                    Console.WriteLine($"The area is {area}");
                   
                   double circumference = 2 * Math.PI * radius;

                   Console.WriteLine($"The circumference is {circumference}");
                }
        }
}