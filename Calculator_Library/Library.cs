using System;


namespace Calculator_Library
{
        public class Cal_Porgram
        {
            public static void Main(string[] args)
            {
                // Declare variables and then initialize to zero.
                float value1 = 0;
                float value2 = 0;

                // Display title as the C# console calculator app.
                Console.WriteLine("-------Calculator Application------\r\n");

                // Ask User to type the first and  Second number.
                Console.WriteLine("Enter First Number, then Press Enter");
                value1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Second Number, then Press Enter");
                value2 = Convert.ToInt32(Console.ReadLine());

                // User Choose an Option.
                Console.WriteLine("Choose an option from the following list:");
                Console.WriteLine("\ta - Add");
                Console.WriteLine("\ts - Subtract");
                Console.WriteLine("\tm - Multiply");
                Console.WriteLine("\td - Divide");
                Console.Write("Your Option: ");

                // Use a switch statement to do the math.
                switch (Console.ReadLine())
                {
                    case "a":
                        Console.WriteLine($"Answer/Result: {value1} + {value2} = " + (value1 + value2));
                        break;
                    case "s":
                        Console.WriteLine($"Answer/Result: {value1} - {value2} = " + (value1 - value2));
                        break;
                    case "m":
                        Console.WriteLine($"Answer/Result: {value1} * {value2} = " + (value1 * value2));
                        break;
                    case "d":
                        while (value2 == 0)
                        {
                            Console.WriteLine("Enter a non-zero divisor: ");
                            value2 = Convert.ToInt32(Console.ReadLine());
                        }

                        Console.WriteLine($"Answer/Result: {value1} / {value2} = " + (value1 / value2));
                        break;
                }
                // Wait for User Respond before closing.
                Console.Write("Press any KEY to close the Application. Thank You");
                Console.ReadKey();
            }
        }
    }




