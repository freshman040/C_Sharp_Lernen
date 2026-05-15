// See https://aka.ms/new-console-template for more information

namespace MyFirstApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            int auswahl = 2;

            switch (auswahl)
            {
                case 1:
                    // Try-Catch Blocks
                    try
                    {
                        string input = Console.ReadLine();
                        int num = int.Parse(input);
                        Console.WriteLine($"Your number is {num}");
                        int qoutient = 10 / num;
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    catch (DivideByZeroException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    catch { Console.WriteLine("An unexpected error occurred"); }
                    break;

                case 2:

                    // Dividesafely(4, 0);

                    ValidateAge(19);


                    break;

            }
        }

        public static int Dividesafely(int a, int b)
        {
          if(b == 0)
            {
                throw new DivideByZeroException("Denominator cannot be zero!");
            }
            return a / b;
        }

        public class InvalidAgeException : Exception
        {
            public InvalidAgeException(string message) : base(message)
            {
            }
        }

        public static void ValidateAge(int age)
        {
            if(age > 18)
            {
                throw new InvalidAgeException("User must be 18 or above");
            }
        }

    }
}
