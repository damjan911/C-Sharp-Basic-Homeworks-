#region Task1 

Queue<int> numbersQueue = new Queue<int>();

do
{
    Console.WriteLine("Please enter a number: ");
    int number = int.Parse(Console.ReadLine());

    numbersQueue.Enqueue(number);

    Console.WriteLine("Do you want to input another number? (y/n): ");
} while (Console.ReadLine().ToLower() == "y");

Console.WriteLine("Numbers entered in the order you added them:");
foreach (int number in numbersQueue)
{
    Console.WriteLine(number);
}


#endregion
