using System;

namespace ConvertNumberTask
{
    public class ExecuteSecondTask
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer in decimal system: ");
            var num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter system base: 2-binary, 8-octal, 10-decimal, 16-hexadecimal");
            var system = Convert.ToInt32(Console.ReadLine());

            switch (system)
            {

                case 2:
                    Console.WriteLine("Number in binary system: ");
                    string binaryCode = Convert.ToString(num, 2);
                    Console.WriteLine(binaryCode);
                    break;
                case 8:
                    Console.WriteLine("Number in octal system: ");
                    string octalCode = Convert.ToString(num, 8);
                    Console.WriteLine(octalCode);
                    break;
                case 10:
                    Console.WriteLine("Number in decimal system: ");
                    string decimalCode = Convert.ToString(num, 10);
                    Console.WriteLine(decimalCode);
                    break;
                case 16:
                    Console.WriteLine("Number in hexidecimal system: ");
                    string hexadecimalCode = Convert.ToString(num, 16);
                    Console.WriteLine(hexadecimalCode);
                    break;
                default:
                    Console.WriteLine("Unknown number system");
                    break;
            }

            Console.ReadKey();
        }
    }
}
