#region Exercise 5

using System.ComponentModel.Design;

int numOfBranches = 12;
int numOfApples = 8;
int basketCapacity = 5;

Console.WriteLine("Please enter number of trees");
int number1 = int.Parse(Console.ReadLine());

int totalApples = numOfBranches * numOfApples;
double totalBaskets = totalApples / basketCapacity;
double totalBranches = totalBaskets * number1;

Console.WriteLine("For " + number1 + " trees we need " + totalBranches + " baskets to collect all the apples from the trees. ");




#endregion

Console.WriteLine("================================");

#region Exercise 6

Console.WriteLine("Please enter the First Number: ");

int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Please enter the Second Number: ");

int num2 = int.Parse(Console.ReadLine());

if (num1 > num2)
{
    if (num1 % 2 == 0)
    {
        Console.WriteLine(num1 + " is bigger than " + num2 + " and it is an even number. ");
    }
    else
    {
        Console.WriteLine(num1 + " is bigger than " + num2 + " and it is an odd number. ");
    }
}
else if (num1 < num2)
{
    if (num1 % 2 == 0)
    {
        Console.WriteLine(num2 + " is bigger than " + num1 + " and it is an even number. ");
    }
    else
    {
        Console.WriteLine(num2 + " is bigger than " + num1 + " and it is an odd number. ");
    }

}
else
{
    Console.WriteLine("This two numbers are equal!... ");
}


#endregion

Console.WriteLine("================================");

#region  Exercise 7 

Console.WriteLine("Enter number from 1 to 3: ");

int userInput = Convert.ToInt32(Console.ReadLine());

switch (userInput)
{
    case 1:
        Console.WriteLine(" You got a new car. ");
        break;
    case 2:
        Console.WriteLine(" You got a new plane. ");
        break;
    case 3:
        Console.WriteLine(" You got a new bike. ");
        break;
    default:
        Console.WriteLine("Error! Something went wrong... ");
        break;
}


#endregion

Console.WriteLine("================================");


#region Task 1

Console.Write("Enter the first Number: ");
int userInput1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the Operator: ");
char userInput2 = Char.Parse(Console.ReadLine());

Console.Write("Enter the second Number: ");
int userInput3 = Convert.ToInt32(Console.ReadLine());


switch (userInput2)
{
    case '+':
        int sum = userInput1 + userInput3;
        Console.WriteLine("The result is: " + sum);
        break;

    case '-':
        int diff = userInput1 - userInput3;
        Console.WriteLine("The result is: " + diff);
        break;

    case '*':
        int mult = userInput1 * userInput3;
        Console.WriteLine("The result is: " + mult);
        break;

    case '/':
        int dev = userInput1 / userInput3;
        Console.WriteLine("The result is: " + dev);
        break;

    default:
        Console.WriteLine("Error! Something went wrong... ");
        break;
}


#endregion

Console.WriteLine("================================");


#region Task 2

int numbers1, number2, number3, number4;

Console.Write("Enter the First number: ");
numbers1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the Second number: ");
number2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the third number: ");
number3 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the fourth number: ");
number4 = Convert.ToInt32(Console.ReadLine());

int result = (numbers1 + number2 + number3 + number4) / 4;

Console.WriteLine("The average of this numbers is: " + result);


#endregion

Console.WriteLine("================================");

#region Task 3

Console.WriteLine("Input the First Number: ");
int userInputs1 = int.Parse(Console.ReadLine());

Console.WriteLine("Input the Second Number: ");
int userInputs2 = int.Parse(Console.ReadLine());

if (userInputs1 is int && userInputs2 is int)
{
    int nums1 = userInput2;
    int nums2 = userInput1;

    Console.WriteLine("First Number: " + nums1);
    Console.WriteLine("Second Number: " + nums2);
}
else
{
    Console.WriteLine("Oops ! Something went wrong!... ");
}


#endregion
