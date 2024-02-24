using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab8CSharp
{
    public class Task3
    {
        public static void Task3_()
        {
            string text = File.ReadAllText("inputTask3.txt");

            string[] words = text.Split(new[] { ' ', ',', '.', ';', ':', '!', '?' });

            var uniqueWordsList = new List<string>();

            foreach (string word in words)
            {
                if (!string.IsNullOrWhiteSpace(word))
                {
                    if (words.Count(w => w == word) == 1)
                    {
                        uniqueWordsList.Add(word);
                    }
                }
            }

            using (StreamWriter writer = new StreamWriter("outputTask3.txt"))
            {
                foreach (string word in uniqueWordsList)
                {
                    writer.WriteLine(word);
                }
            }

            Console.WriteLine("The results are successfully written to the file outputTask3.txt.");
        }
    }
}
