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

    }
}