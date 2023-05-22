using static System.Console;
using System.Collections.Generic;
using System.IO;

public class FileHandler{
    private string _filePath;

    public FileHandler(string filePath)
    {
        _filePath = filePath;
    }

    public FileHandler()
    {
    }

    public void SaveEntries(List<Entry> entries){
        string filePath = "myJournal.txt";
        using (StreamWriter file = new StreamWriter(filePath))
        {
            foreach (Entry entry in entries)
            {
                file.WriteLine(entry.GetEntry());
            }
        }
    }

    public List<Entry> LoadEntries(){
        List<Entry> entries = new List<Entry>();
        
        if (!File.Exists(_filePath))
        {
            WriteLine("File not found. Please check the file path.");
            return entries;
        }
        using (StreamReader file = new StreamReader(_filePath))
        {
            string line;
            while ((line = file.ReadLine()) != null)
            {
                Entry entry = new Entry(line);
                entries.Add(entry);
            }
        }

        return entries;
    }
}
