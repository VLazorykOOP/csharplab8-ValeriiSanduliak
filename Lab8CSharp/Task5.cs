using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8CSharp
{
    public class Task5
    {
        public static void Task5_()
        {
            // 1
            string studentName = "Gyrka";

            string folder1Path = $"D:\\temp\\{studentName}1";
            string folder2Path = $"D:\\temp\\{studentName}2";

            Directory.CreateDirectory(folder1Path);
            Directory.CreateDirectory(folder2Path);

            // 2

            string t1FilePath = Path.Combine(folder1Path, "t1.txt");
            string t2FilePath = Path.Combine(folder1Path, "t2.txt");

            string t1Text =
                "Шевченко Степан Іванович, 2001 року народження, місце проживання м. Суми";
            string t2Text =
                "Комар Сергій Федорович, 2000 року народження, місце проживання м. Київ";

            File.WriteAllText(t1FilePath, t1Text);
            File.WriteAllText(t2FilePath, t2Text);

            // 3
            string t3FilePath = Path.Combine(folder2Path, "t3.txt");

            File.AppendAllText(t3FilePath, File.ReadAllText(t1FilePath));
            File.AppendAllText(t3FilePath, File.ReadAllText(t2FilePath));

            // 4
            PrintFileInfo(t1FilePath);
            PrintFileInfo(t2FilePath);
            PrintFileInfo(t3FilePath);

            // 5
            string movet2FilePath = Path.Combine(folder2Path, "t2.txt");
            File.Move(t2FilePath, movet2FilePath);
            // 6
            string moveT1FilePath = Path.Combine(folder2Path, "t1.txt");
            File.Copy(t1FilePath, moveT1FilePath);

            // 7
            string allFolderPath = $"D:\\temp\\ALL";
            Directory.Move(folder2Path, allFolderPath);
            Directory.Delete(folder1Path, true);
            // 8
            Console.WriteLine("\nFiles in ALL directory:");
            string[] filesInAll = Directory.GetFiles(allFolderPath);
            foreach (string file in filesInAll)
            {
                PrintFileInfo(file);
            }
        }

        static void PrintFileInfo(string filePath)
        {
            FileInfo fileInfo = new FileInfo(filePath);
            Console.WriteLine(
                $"File: {fileInfo.Name}, Size: {fileInfo.Length} bytes, Last Modified: {fileInfo.LastWriteTime}"
            );
        }
    }
}
