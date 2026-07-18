using System;
using System.Collections.Generic;
using System.IO;

public class Journal{
    public List<Entry> _entry = new List<Entry>();

    public void AddEntry(Entry plus) {
        _entry.Add(plus);
    }
    
    public void Display() {
        foreach (Entry e in _entry) {
            e.Display();
        }
    }

    public void Save(string file) {
        using (StreamWriter outputFile = new StreamWriter(file)) {
            foreach (Entry e in _entry) {
                outputFile.WriteLine($"{e._date}|{e._promptText}|{e._entryText}|{e._mood}");
            }
        }
        Console.WriteLine("Saved");
    }

    public void Load(string file) {
        if (File.Exists(file)) {
            string[] lines = System.IO.File.ReadAllLines(file);
            _entry.Clear(); 

            foreach (string line in lines) {
                string[] kok = line.Split('|');
                
                Entry jojo = new Entry();
                jojo._date = kok[0];
                jojo._promptText = kok[1];
                jojo._entryText = kok[2];
                jojo._mood = kok[3];
                
                _entry.Add(jojo);
            }
            Console.WriteLine("Loaded");
        }
        else {
            Console.WriteLine("File not found.");
        }
    }
}