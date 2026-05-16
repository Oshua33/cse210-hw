using System;

class Journal
{
    // list to store journal entries
    public List<Entry> _entries = new List<Entry>();

    //Add a method to add a newentry to the journal
    public void AddEntry(Entry newEntry)
    {
        // Implementation for adding an entry
        _entries.Add(newEntry);
    }

    //Display all entries in the journal
    public void DisplayAll()
    {
        // Implementation for displaying all entries
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    //Save all entries in the journal to a file
    public void SaveToFile()
    {
        // Implementation for saving entries to a file
        string filename = "journal.txt";

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
            }
        }
        Console.WriteLine("Journal entries saved to file.");
    }

    public void LoadFromFile()
    {
        // Implementation for loading entries from a file
        string filename = "journal.txt";

        if (!File.Exists(filename))
        {
            Console.WriteLine("No saved file found. Starting with an empty journal.");
            return;
        }

        //read the file and create entries from the data
        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split('|');
            if (parts.Length == 3)
            {
                //create a new entry with the data and add it to the journal
                Entry entry = new Entry();
                entry._date = parts[0];
                entry._promptText = parts[1];
                entry._entryText = parts[2];

                _entries.Add(entry);
            }
        }            
        Console.WriteLine("Journal entries loaded successfully.");

    }
}