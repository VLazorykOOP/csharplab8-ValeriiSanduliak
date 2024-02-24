using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8CSharp
{
    public class Task2
    {
        public static void Task2_()
        {
            string inputFilePath = "inputTask2.txt";
            string outputFilePath = "outputTask2.txt";
            try
            {
                string inputText = File.ReadAllText(inputFilePath);

                string resultText = ReplaceSequence(inputText);

                File.WriteAllText(outputFilePath, resultText);

                Console.WriteLine("Replacement completed. Result written to outputTask2.txt");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        static string ReplaceSequence(string input)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                result.Append(input[i]);

                int j = i + 1;
                while (j < input.Length && input[j] == input[j - 1] + 1)
                {
                    j++;
                }

                if (j - i >= 3)
                {
                    result.Append("-");
                    result.Append(input[j - 1]);
                    i = j - 1;
                }
            }

            return result.ToString();
        }
    }
}
