#region

// Method that print in the console which doesn't have a return type.

//void SayHello()
//{
//    Console.WriteLine("Hello there! ");
//}



//void SayGoodbye(string name)

//{
//    // String Interpolation.
//    Console.WriteLine($"Goodbye {name}");
//    // Concatenation.
//    Console.WriteLine("Goodbye " + name);

//}

//void StoryTeller(string who, string when, string where)
//{
//    Console.WriteLine("There was a king called " + who + "He lived " + when + "in " + where);
//}

//SayHello();

//Console.WriteLine("===============================");

//SayGoodbye("Damjan");

//Console.WriteLine("===============================");

//StoryTeller("Damjan. "," a few years ago "," the kingdom of far away. ");


//Console.WriteLine("===============================");

//string TellMeTheDay(int day)
//{
//    switch (day)
//    {
//        case 1:
//            return "Monday";

//        case 2:
//            return "Tuesday";

//        case 3:
//            return "Wednesday";

//        case 4:
//            return "Thursday";

//        case 5:
//            return "Friday";

//        case 6:
//            return "Saturday";

//        case 7:
//            return "Sunday";

//        default:
//            return "There is no such day ! ";

//    }

//}

//string dayOfTheWeek = TellMeTheDay(3);
//Console.WriteLine(dayOfTheWeek);

//string academyName = "SEDC ";
//string academy = "Web Programming ";

//// Three ways of manipulations with strings.

//// Concatination

//string concatinationAcademy = academyName + " academy for " + academy;

//Console.WriteLine(concatinationAcademy);


//// String Interpolation.

//string interpolationAcademy = $"{academyName} academy for {academy} ";

//Console.WriteLine(interpolationAcademy);

//// String Format.

//string formattedAcademy = string.Format("{0} academy for {1} ",academyName,academy);

//Console.WriteLine(formattedAcademy);

//// String Format more Examples.

//string percent = string.Format("This is {0:P} ", 0.04);

//Console.WriteLine(percent);

//Console.WriteLine("=====================================");

//string number = string.Format("This is {0:N} ",12);

//Console.WriteLine(number);

//Console.WriteLine("=====================================");

//string phoneNumber = string.Format("The number is {0:0##-###-###} ", 075762435);

//Console.WriteLine(phoneNumber);

//Console.WriteLine("=======================================");

//string text = "We are learning C-Sharp at this moment. ";

//// ToLower() and ToUpper() Methods.
//Console.WriteLine(text.ToUpper());
//Console.WriteLine(text.ToLower());

//// Split Method.

//string[] splittedStrings = text.Split(" ");
//for (int i=0; i < splittedStrings.Length; i++)
//{
//    Console.WriteLine(splittedStrings[i]);
//}

//// How to check the Index.

//int index = Array.IndexOf(splittedStrings,"We");

//Console.WriteLine(index);

//Console.WriteLine("================================================");

//// Substring() Method.

//string substring = text.Substring(0);
//string substring1 = text.Substring(0, 6);

//Console.WriteLine(substring);
//Console.WriteLine(substring1);

#endregion

#region Class Exercises

// Exercise 1

int Sum(int num1, int num2)
{
    return num1 + num2;
}

int Subtract(int num1, int num2)
{
    return (num1 - num2);
}

Console.WriteLine("Please enter the first number ");
bool canBeParsedFirstNumber = int.TryParse(Console.ReadLine(), out int firstNumber);

Console.WriteLine("Please enter the second number ");
bool canBeParsedSecondNumber = int.TryParse(Console.ReadLine(), out int secondNumber);

Console.WriteLine("Please enter - or +: ");
string operation = Console.ReadLine();

if (canBeParsedFirstNumber && canBeParsedSecondNumber)
{
    if (operation == "+")
    {
        Console.WriteLine(Sum(firstNumber, secondNumber));
    }
    else if (operation == "-")
    {
        Console.WriteLine(Subtract(firstNumber, secondNumber));
    }
    else
    {
        Console.WriteLine("Something went wrong! ");
    }
}

#endregion

Console.WriteLine("===================================================");

#region Manipulating DateTime.

DateTime currentDateTime = DateTime.Now;

Console.WriteLine(currentDateTime);

string dataFormat = currentDateTime.ToString("MM/dd/yyyy hh:mm tt");
Console.WriteLine(dataFormat);

// Adding or Removing Days to a DateTime date.

DateTime addedDates = DateTime.Now.AddDays(2).AddHours(3).AddMonths(3);

Console.WriteLine(addedDates);

int day = addedDates.Day;

Console.WriteLine(day);

int month = addedDates.Month;   
Console.WriteLine(month);

int hour = addedDates.Hour;

Console.WriteLine(hour);



#endregion