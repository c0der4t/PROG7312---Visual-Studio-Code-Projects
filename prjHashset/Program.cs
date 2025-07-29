//Create a hashset to store unique superhero names
HashSet<string> superheroes = new HashSet<string>();

superheroes.Add("Super?");
superheroes.Add("Batthey");
superheroes.Add("Wonder IT");
superheroes.Add("The Flash");
superheroes.Add("Waterman");

// Attmpt to add a duplicate
bool added = superheroes.Add("Super?"); // This will return false since "Super?" is already in the set
Console.WriteLine($"Was 'Super?' added again?\n{added}");

System.Console.WriteLine("Superheroes in the HashSet:");
foreach (string hero in superheroes)
{
    Console.WriteLine(hero);
}

bool containsFlash = superheroes.Contains("The Flash");
Console.WriteLine($"\nDoes the HashSet contain 'The Flash'? {containsFlash}");

superheroes.clear();
Console.WriteLine("\nHashSet cleared. Current count: " + superheroes.Count);


// The purpose of this:
// Hashsets are simple collections but they are 
// very useful when you need to ensure that all items are unique.