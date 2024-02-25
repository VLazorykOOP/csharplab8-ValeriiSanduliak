using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab8CSharp
{
    public class Task1
    {
        public static void Task1_()
        {
            string inputFilePath = "inputTask1.txt";
            string outputFilePath = "outputTask1.txt";

            try
            {
                string inputText = File.ReadAllText(inputFilePath);

                string pattern = @"\b[\w.%-]+@ukrnet\.[a-z]{2,}\b";
                MatchCollection matches = Regex.Matches(inputText, pattern);

                Console.WriteLine($"Number of found email addresses: {matches.Count}");

                Console.WriteLine($"Content of {inputFilePath}:");
                Console.WriteLine(inputText);

                Console.WriteLine("Do you want to replace any of the email addresses? (y/n)");
                string replaceOption = Console.ReadLine();

                if (replaceOption.ToLower() == "y")
                {
                    Console.WriteLine("Enter the email address you want to replace:");
                    string emailToReplace = Console.ReadLine();

                    Console.WriteLine("Enter the new email address:");
                    string newEmail = Console.ReadLine();

                    inputText = Regex.Replace(inputText, emailToReplace, newEmail);

                    using (StreamWriter sw = new StreamWriter(outputFilePath))
                    {
                        sw.Write(inputText);
                    }
                }
                else if (replaceOption.ToLower() == "n")
                {
                    using (StreamWriter sw = new StreamWriter(outputFilePath))
                    {
                        foreach (Match match in matches)
                        {
                            sw.WriteLine(match.Value);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid option. Please enter 'y' or 'n'.");
                }
                Console.WriteLine($"Results have been written to the file {outputFilePath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
        }
    }
}
