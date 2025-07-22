using prjDictionary;

DictionaryManager dictionaryManager = new DictionaryManager();
bool exit = false;

while (!exit)
{
    System.Console.WriteLine("Choose an option:");
    System.Console.WriteLine("1. Add Entry");
    System.Console.WriteLine("2. Search for an entry");
    System.Console.WriteLine("3. Remove Entry");
    System.Console.WriteLine("4. Display Entries");
    System.Console.WriteLine("5. Exit");
    System.Console.WriteLine("Choose an option (1-5):");

    string choice = Console.ReadLine();
    switch (choice)
    {
        case "1":
            Console.Write("Enter Student Name: ");
            string nameToAdd = Console.ReadLine();
            Console.Write("Enter Student Mark: ");
            if (int.TryParse(Console.ReadLine(), out int markToAdd))
            {
                dictionaryManager.AddEntry(nameToAdd, markToAdd);
            }
            else
            {
                Console.WriteLine("Invalid mark. Please enter a valid integer.");
            }
            break;
        case "2":
            Console.Write("Enter Name to search: ");
            string nameToSearch = Console.ReadLine();
            int? mark = dictionaryManager.GetMark(nameToSearch);
            if (mark.HasValue)
            {
                Console.WriteLine($"Mark for {nameToSearch}: {mark.Value}");
            }
            break;
        case "3":
            Console.Write("Enter Name to remove: ");
            string nameToRemove = Console.ReadLine();
            dictionaryManager.RemoveEntry(nameToRemove);
            break;
        case "4":
            dictionaryManager.DisplayEntries();
            break;
        case "5":
            exit = true;
            Console.WriteLine("Exiting the program.");
            break;
        default:
            Console.WriteLine("Invalid choice. Please choose a valid option (1-5).");
            break;
    }
}