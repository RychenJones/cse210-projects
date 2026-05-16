using System.Reflection.Metadata;
using System.IO;

/* Save, Load, and iterate through the user's journal */
public class RJJournal
{
    // List of all entries
    public List<RJEntry> _rjEntries = new List<RJEntry>();

    /* Save the journal to the file with items separated by "|" */
    public void RJSaveJournal(string rjFilename)
    {
        using (StreamWriter rjFile = new StreamWriter(rjFilename))
        {
            foreach (RJEntry rjEntry in _rjEntries)
            {
                rjFile.WriteLine($"{rjEntry._rjDate}|{rjEntry._rjMood}|{rjEntry._rjPrompt}|{rjEntry._rjEntryText}");
            }
        }
    }

    /* Load the journal from the file and split up the string into date, mood, prompt, and entry text */
    public void RJLoadJournal(string rjFilename)
    {
        // get the data from the file
        string[] rjLines = System.IO.File.ReadAllLines(rjFilename);
        _rjEntries = [];

        // iterate through each line, splitting up each item, storing in an array, and inserting them into an Entry instance
        foreach (string rjLine in rjLines)
        {
            string[] rjParts = rjLine.Split("|");

            string rjDate = rjParts[0];
            string rjMood = rjParts[1];
            string rjPrompt = rjParts[2];
            string rjEntryText = rjParts[3];

            // create an Entry instance with the new items
            RJEntry rjNewEntry = new RJEntry();

            rjNewEntry._rjDate = rjDate;
            rjNewEntry._rjMood = rjMood;
            rjNewEntry._rjPrompt = rjPrompt;
            rjNewEntry._rjEntryText = rjEntryText;

            _rjEntries.Add(rjNewEntry);
        }
    }

    /* iterate through and display all entries*/
    public void RJDisplayEntries()
    {
        foreach (RJEntry rjEntry in _rjEntries)
        {
            Console.WriteLine($"Date: {rjEntry._rjDate}");
            Console.WriteLine($"Mood: {rjEntry._rjMood}");
            Console.WriteLine(rjEntry._rjPrompt);
            Console.WriteLine(rjEntry._rjEntryText);
        }
    }
}