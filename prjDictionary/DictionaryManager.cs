using System;

namespace prjDictionary
{
    public class DictionaryManager
    {
        private Dictionary<string, int> dicPROG7311;
        public DictionaryManager()
        {
            dicPROG7311 = new Dictionary<string, int>();
        }

        public void AddEntry(string Name, int mark)
        {
            if (!dicPROG7311.ContainsKey(Name))
            {
                dicPROG7311.Add(Name, mark);
            }
            else
            {
                Console.WriteLine($"Student '{Name}' already exists with value {dicPROG7311[Name]}.");
            }
        }

        public int? GetMark(string Name)
        {
            if (dicPROG7311.TryGetValue(Name, out int mark))
            {
                return mark;
            }
            else
            {
                Console.WriteLine($"Student '{Name}' not found.");
                return null;
            }
        }

        public void RemoveEntry(string Name)
        {
            if (dicPROG7311.ContainsKey(Name))
            {
                dicPROG7311.Remove(Name);
                Console.WriteLine($"Student '{Name}' removed successfully.");
            }
            else
            {
                Console.WriteLine($"Student '{Name}' not found.");
            }
        }

        public void DisplayEntries()
        {
            if (dicPROG7311.Count == 0)
            {
                Console.WriteLine("No entries in the dictionary.");
                return;
            }

            Console.WriteLine("Current entries in the dictionary:");
            foreach (var entry in dicPROG7311)
            {
                Console.WriteLine($"Name: {entry.Key}, Mark: {entry.Value}");
            }
        }

    }
}