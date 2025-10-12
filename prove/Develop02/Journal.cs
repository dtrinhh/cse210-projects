using System;

public class Journal
{
    public string _entryDate;

    public string _writeEntry;

    public string _entryResponse;

    public List<Entry> _listEntries = new List<Entry>();
        
    public string _fileName;

    // public static void SaveToFile(List<Entry> _listEntries, string fileName)
    // {
    //     using (StreamWriter outputFile = new StreamWriter(fileName))
    //     {
    //         foreach (Entry journalEntry in _listEntries)
    //         {
    //             // outputFile.WriteLine($"Date: {journal._entryDate}~~{journal._writeEntry}~~{journal._entryResponse}");
    //         }
    //         // outputFile.WriteLine(journal._listEntries);
    //     }
    // }
    


    public void Display()
    {
        foreach (Entry journalEntry in _listEntries)
        {
            journalEntry.DisplayEntries();
        }
    }
}