using System;

namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Allen Anderson", "Brittany Bund", "Carl Crawford", "Debbie Dolan", "Eddie Everhart"};
            string[] food = { "Apple Pie", "Beef Stew", "Crab Cakes", "Donuts", "Egg Salad"};
            string[] homeTown = { "Ann Arbor, Michigan", "Bloomfield Hills, Michigan", "Concord, Michigan", "Dallas, Texas", "Edmond, Oklahoma"};
            string input, extraInfo, differentInfo, newStudent;
            int inputNum = 0;
            bool exceptionCheck;

            do
            {
                Console.WriteLine("Here are the students in this class:");
                foreach (string student in names)
                {
                    Console.WriteLine(student);
                }
                Console.Write("Which student would you like to learn about? (1-5): ");
                input = Console.ReadLine();

                do
                {
                    exceptionCheck = true;

                    try
                    {
                        inputNum = int.Parse(input) - 1;
                        Console.WriteLine($"You've selected {names[inputNum]}.");
                    }
                    catch (IndexOutOfRangeException ex)
                    {
                        Console.WriteLine(ex.Message);
                        Console.Write("Please enter a number from 1-5: ");
                        input = Console.ReadLine();
                        exceptionCheck = false;
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine(ex.Message);
                        Console.Write("Please only enter a number from 1-5: ");
                        input = Console.ReadLine();
                        exceptionCheck = false;
                    }

                } while (!exceptionCheck);

                do
                {
                    Console.Write("What would you like to know about them? ('Hometown', 'Favorite food', or 'None'): ");
                    extraInfo = Console.ReadLine().ToLower();

                    while (extraInfo != "hometown" && extraInfo != "favorite food" && extraInfo != "none")
                    {
                        Console.WriteLine("Invalid input. Please choose either 'Hometown', 'Favorite food', or 'None'.");
                        extraInfo = Console.ReadLine().ToLower();
                    }

                    if (extraInfo == "hometown")
                    {
                        Console.WriteLine($"{names[inputNum]}'s hometown is {homeTown[inputNum]}.");
                    }
                    else if (extraInfo == "favorite food")
                    {
                        Console.WriteLine($"{names[inputNum]}'s favorite food is {food[inputNum]}.");
                    }

                    Console.WriteLine($"Would you like to learn something else about {names[inputNum]}? (y/n):");
                    differentInfo = Console.ReadLine().ToLower();

                    while (differentInfo != "y" && differentInfo != "n")
                    {
                        Console.WriteLine("Invalid input");
                        differentInfo = Console.ReadLine().ToLower();
                    }

                } while (differentInfo == "y");
                

                Console.Write("Would you like information on a different student? (y/n): ");
                newStudent = Console.ReadLine().ToLower();

                while (newStudent != "y" && newStudent != "n")
                {
                    Console.WriteLine("Invalid input");
                    newStudent = Console.ReadLine().ToLower();
                }

            } while (newStudent == "y");

            Console.WriteLine("Goodbye!");
            return;
        }
    }
}
