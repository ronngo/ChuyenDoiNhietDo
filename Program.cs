using System;

namespace chuyendoinhiet
{
    class Program
    {
        static void Main(string[] args)
        {
           //Sử dụng vòng lặp do/while và cấu trúc lựa chọn switch/case để hiển in ra menu lựa chọn cho người dùng.
            double fahrenheit;
            double celsius;
            int choice;

            do
            {
                Console.WriteLine("Menu.");
                Console.WriteLine("1. Fahrenheit to Celsius");
                Console.WriteLine("2. Celsius to Fahrenheit");
                Console.WriteLine("0. Exit");
                Console.WriteLine("Enter your choice: ");
                choice = Int32.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:

                    Console.WriteLine("Enter fahrenhiet : ");
                    fahrenheit = Double.Parse(Console.ReadLine());
                    Console.WriteLine("Fahrenheit to Celsius : " + FahrenheitToCelsius(fahrenheit) + "C");
                    break;

                    case 2:
                    Console.WriteLine("Enter Celsius : ");
                    celsius = Double.Parse(Console.ReadLine());
                    Console.WriteLine("Celsius to Fahrenheit : " + CelsiustoFahrenheit(celsius) + "F");
                    break;

                    case 0:
                    Environment.Exit(0);
                    break;
                }
            } while (choice !=0);
        } 
        
         //  Xây dựng phương thức chuyển đổi từ độ C sang độ F
                public static double CelsiustoFahrenheit(double celsius)
        {
            double fahrenheit = (9.0 / 5) * celsius + 32;
            return fahrenheit;
        }

    // Xây dựng phương thức chuyển đổi từ độ F sang độ C
        public static double FahrenheitToCelsius(double fahrenheit)
        {
            double celsius = (5.0 / 9) * (fahrenheit - 32);
            return celsius;
        }

    }
    }
    