#region Task2

List<int> listOfTenNumbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

var squeredNumber = from list in listOfTenNumbers
                    let sqrNo = list * list
                    select new { list, sqrNo };

foreach (var num in squeredNumber)
{
    Console.WriteLine(num);
}

#endregion
