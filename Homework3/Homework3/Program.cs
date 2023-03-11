#region Exercise 4

using System.ComponentModel.Design;

string[] wordsArray = new string[5] { "potato", "apple", "watermelon", "strawberry", "grapes" };
double[] decimalArray = new double[5] { 1.5, 7.2, 4.2, 5.1, 2.2 };
char[] charArray = new char[5] { 's', 't', 'o', 'l', 'e' };
bool[] boolArray = new bool[5] { true, false, false, false, true };
int[][] twoDArray = new int[2][] { new int[] { 4, 2, 5 }, new int[] { 6, 3, 8 } };


#endregion



# region Exercise 5

int[] integersArray = new int[5];

for (int i = 0; i < integersArray.Length; i++)
{
    Console.WriteLine("Enter value: ");
    integersArray[i] = int.Parse(Console.ReadLine());
}

int sum = 0;
foreach (int number in integersArray)
{
    sum += number;

    Console.WriteLine(sum);

}


#endregion

Console.WriteLine("============================");

#region Exercise 6
string userInput = "";
int number1 = 0;


string[] arrayWithNames = new string[5];


for (int i = 0; i < arrayWithNames.Length; i++)
{
    Console.WriteLine("Enter a name");
    userInput = Console.ReadLine();
    arrayWithNames[number1] = userInput;
    number1++;
}

Console.WriteLine("Do you want to enter another name? (Y/N): ");
userInput = Console.ReadLine();

while (userInput.ToUpper() == "Y") ;

Console.WriteLine("All entered names:");
for (int i = 0; i < number1; i++)
{
    Console.WriteLine(arrayWithNames[i]);
}


#endregion

Console.WriteLine("================================");

#region Task 1 (SumOfEven)

int[] integers = new int[6];
int sumary = 0;
for (int i = 0; i < integers.Length; i++)
{
    Console.WriteLine("Enter a number: ");
    integers[i] = int.Parse(Console.ReadLine());
    if (integers[i] % 2 == 0)
    {
        sumary += integers[i];

    }
}

Console.WriteLine("The sum of even numbers is: " + sumary);


#endregion

Console.WriteLine("================================");

#region Task 2

string[] studentsG1 = new string[5] { "Zdravko", "Petko", "Stanko", "Branko", "Trajko" };
string[] studentsG2 = new string[5] { "Damjan", "Tosho", "Marija", "Ivo", "Stefan" };

Console.WriteLine("Enter student group: (1/2");
int userInput1 = int.Parse(Console.ReadLine());

if (userInput1 == 1)
{
    foreach (string student in studentsG1)
    {
        Console.WriteLine(student);
    }
}
else if (userInput1 == 2)
{
    foreach (string student in studentsG2)
    {
        Console.WriteLine(student);
    }
}
else
{
    Console.WriteLine("Please enter a valid number");
}


#endregion
