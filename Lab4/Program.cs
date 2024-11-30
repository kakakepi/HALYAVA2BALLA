using System;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string,int> students = new Dictionary<string, int>();
        Random rnd = new Random();
        string filePath = "astz.txt";
        string[] lines = File.ReadAllLines(filePath);
        string newFilePath = "students.txt";
        int countForWhile = 0;
        while (students.Count < lines.Length && countForWhile < lines.Length)
        {
            int number = rnd.Next(1, 50);
            if (!students.ContainsValue(number))
            {
                students.Add(lines[countForWhile], number);
                countForWhile++;
            }
        }
        for (int i = 0; i < lines.Length; i++){
            
        }
        using (StreamWriter writer = File.CreateText(newFilePath))
        {
            foreach (var stud in students)
            {
                writer.WriteLine($"{stud.Key}, {stud.Value}");
            }
        }
        Console.WriteLine($"Файл '{newFilePath}' успешно создан.");
    }
}
