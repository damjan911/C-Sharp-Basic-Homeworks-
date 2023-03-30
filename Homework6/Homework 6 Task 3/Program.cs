#region Task 3

using Homework_6_Task_3.Models;

List<Animal> animals = new List<Animal>()
{
    new Animal("Affenpischer","brown",7,Animal.Gender.Male),
    new Animal("German Shipperd","blue",2,Animal.Gender.Female),
    new Animal("Poodles", "white", 8, Animal.Gender.Female),
    new Animal("Bulldogs", "brown", 7, Animal.Gender.Male),
    new Animal("Rottweilers", "black", 5, Animal.Gender.Male),
    new Animal("Dachshunds", "brown", 4, Animal.Gender.Female),
    new Animal("Pitbulls", "grey", 6, Animal.Gender.Female)
};

// Find the names of all the animals aged 5 or more.

//List<string> ageFiveOrMore = animals.Where(n => n.Age >= 5).Select(n => n.Name).ToList();

//foreach (var animal in ageFiveOrMore)
//{
//    Console.WriteLine(animal);
//}

// Find all the names of the animals that start with 'A' .

//List<string> namesWithFirstLetterA = animals.Where(n => n.Name.StartsWith("A")).Select(n => n.Name).ToList();

//foreach (var names in namesWithFirstLetterA)
//{
//    Console.WriteLine(names);
//}

// Find all male, brown animals .

List<string> allMaleAndBrownAnimalsNames = animals.Where(n => n.GenderType == Animal.Gender.Male && n.Color == "brown").Select(n => n.Name).ToList();

foreach (var animalsWithMalesAndBrown in allMaleAndBrownAnimalsNames)
{
    Console.WriteLine(animalsWithMalesAndBrown);
}


#endregion
