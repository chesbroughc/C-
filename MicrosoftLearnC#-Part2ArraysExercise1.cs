//Two ways to declare arrays


//Using multiple statements (below)
//string[] fraudulentOrderIDs = new string [3];

//fraudulentOrderIDs[0] = "A123";
//fraudulentOrderIDs[1] = "B456";
//fraudulentOrderIDs[2] = "C789";
//fraudulentOrderIDs[3] = "D00";

//Using a single statement
string[] fraudulentOrderIDs = {"A123", "B456", "C789"};

Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

fraudulentOrderIDs[0] = "F000";
Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

//Use .Length to determine the size of an array
Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");