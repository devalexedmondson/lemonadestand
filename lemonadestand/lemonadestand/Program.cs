﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadestand
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = string.Empty;

            Console.WriteLine("cc <Location> - Current conditions");
            Console.WriteLine("fc <Location> - Forecast conditions");
            Console.WriteLine("ex - Exit");

            // The ex command will automatically exit the application.
            while (command.ToUpper() != "EX")
            {
                // Read the command.
                Console.Write(">");
                input = Console.ReadLine();

                command = input.Substring(0, 2);

                switch (command.ToUpper())
                {
                    case "CC":
                        {
                            Conditions conditions = new Conditions();
                            conditions = Weather.GetCurrentConditions(input.Substring(2, input.Length - 2));

                            if (conditions != null)
                            {
                                Console.WriteLine("Conditions: " + conditions.Condition);
                                Console.WriteLine("Temperature (F): " + conditions.TempF);
                                Console.WriteLine("Temperature (C): " + conditions.TempC);
                                Console.WriteLine("Humidity: " + conditions.Humidity);
                                Console.WriteLine("Wind: " + conditions.Wind);
                                Console.WriteLine();
                            }
                            else
                            {
                                Console.WriteLine("There was an error processing the request.");
                                Console.WriteLine("Please, make sure you are using the correct location or try again later.");
                                Console.WriteLine();
                            }
                            break;
                        }
                    case "FC":
                        {
                            List<Conditions> conditions = new List<Conditions>();
                            conditions = Weather.GetForecast(input.Substring(2, input.Length - 2));

                            if (conditions != null)
                            {
                                foreach (Conditions c in conditions)
                                {
                                    Console.WriteLine("Day: " + c.DayOfWeek);
                                    Console.WriteLine("Conditions: " + c.Condition);
                                    Console.WriteLine("Temperature (High): " + c.High);
                                    Console.WriteLine("Temperature (Low): " + c.Low);
                                    Console.WriteLine();
                                }
                            }
                            else
                            {
                                Console.WriteLine("There was an error processing the request.");
                                Console.WriteLine("Please, make sure you are using the correct location or try again later.");
                                Console.WriteLine();
                            }
                            break;
                        }
                    case "EX":
                        {
                            Console.WriteLine("Application closing...");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Unknown command.");
                            break;
                        }
                }
            }

            // Exit the application with exit code 0 (no errors).
            Environment.Exit(0);

        }

    }
}

