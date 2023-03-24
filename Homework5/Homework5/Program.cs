#region Task 1 Task 2

// Task 1.

using Homework5.Models;

Human human = new Human();

Console.WriteLine("Enter first name: ");
human.FirstName = Console.ReadLine();

Console.WriteLine("Enter last name: ");
human.LastName = Console.ReadLine();

Console.WriteLine("Enter age: ");
human.Age = Convert.ToInt32(Console.ReadLine());

string result=human.GetPersonDetails();

Console.WriteLine(result);



#endregion
