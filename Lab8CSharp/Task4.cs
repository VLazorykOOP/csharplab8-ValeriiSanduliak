using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8CSharp
{
    public class Task4
    {
        public static void Task4_()
        {
            double[] numbers = { 3.5, 6.2, 8.9, 2, 10.4, 4.0 };
            double threshold = 7.0;

            using (
                BinaryWriter writer = new BinaryWriter(File.Open("numbers.bin", FileMode.Create))
            )
            {
                foreach (double number in numbers)
                {
                    writer.Write(number);
                }
            }

            using (BinaryReader reader = new BinaryReader(File.Open("numbers.bin", FileMode.Open)))
            {
                Console.WriteLine($"Even numbers less than {threshold} :");
                long length = reader.BaseStream.Length / sizeof(double);
                for (long i = 0; i < length; i++)
                {
                    double currentNumber = reader.ReadDouble();
                    if (currentNumber < threshold && currentNumber % 2 == 0)
                    {
                        Console.WriteLine(currentNumber);
                    }
                }
            }
        }
    }
}
