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

    public void SaveEntries(List<Entry> entries)
    {
        string filePath = "myJournal.txt";
        using (StreamWriter file = new StreamWriter(filePath))
        {
            foreach (Entry entry in entries)
            {
                file.WriteLine(entry.GetEntry());
            }
        }
    }
}
