#region Task 1, Task 2, Task 3, Task 4


// Task 1.

using static System.Net.Mime.MediaTypeNames;

Console.WriteLine("Please print the last 5 characters of the User: ");
string userInput = Console.ReadLine();
string lastFiveChars = userInput.Substring(userInput.Length - 5);

Console.WriteLine(lastFiveChars);

Console.WriteLine("==========================================");

// Task 2.

  string text = "We are learning C-Sharp as a Programming Language ";

string[] splittedText = text.Split(" ");

for(int i = 0; i < splittedText.Length; i++)
{
    Console.WriteLine(splittedText[i]);
}

Console.WriteLine("==========================================");


// Task 3.

int Sum(int first, int second)
{
    int number;
    number = first + second;
    return number;
}

Console.WriteLine(Sum(5, 2));

Console.WriteLine("==========================================");

// Task 4.

Console.WriteLine("Enter date: ");
string day = Console.ReadLine();
int birthday = int.Parse(day);

int AgeCalculator(int myBirthday)
{
    int age = myBirthday;
    return birthday - age;
}

Console.WriteLine(AgeCalculator(1995));


#endregion
