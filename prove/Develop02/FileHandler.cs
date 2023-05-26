using static System.Console;
using System.Collections.Generic;
using System.IO;

public class FileHandler{
    private string _filePath = "myJournal.txt";

    public FileHandler(string filePath)
    {
        _filePath = filePath;
    }

    public FileHandler()
    {
    }

    public void SaveEntries(List<Entry> entries)
    {
        Write("Enter the file path (myJournal.txt): ");
        string inputFilePath = ReadLine();
        string filePath = string.IsNullOrWhiteSpace(inputFilePath) ? "myJournal.txt" : inputFilePath;

        using (StreamWriter file = new StreamWriter(filePath, append: true))
        {
            foreach (Entry entry in entries)
            {
                file.WriteLine(entry.GetEntry());
            }
        }
        Write($"Saved to {filePath}\nPress enter to continue. ");
        ReadLine();
    }

    public void LoadEntries(){

        Write("Enter the file path (myJournal.txt): ");
        string inputFilePath = ReadLine();
        string filePath = string.IsNullOrWhiteSpace(inputFilePath) ? "myJournal.txt" : inputFilePath;
        Console.Clear();

        if (!File.Exists(filePath)){

            WriteLine("File not found. Please check the file path.");
            return;
        }

        using (StreamReader file = new StreamReader(filePath)){

            string line;
            while ((line = file.ReadLine()) != null){

                WriteLine(line);
            }
        }
        WriteLine(" ");
        Write("Press enter to go back. ");
        ReadLine();
    }
}
