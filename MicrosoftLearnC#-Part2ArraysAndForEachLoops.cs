//string[] names = {"Rowena", "Robins", "Bao"};
//foreach (string name in names)
//{
//    Console.WriteLine(name);
//}

int[] inventory = {200, 450, 700, 175, 250};
int sum = 0;
int bin = 0;

foreach (int i in inventory)
{
    sum += i;
    bin++;
    Console.WriteLine($"Bin {bin} = {i} items (Running total: {sum})");
}

Console.WriteLine($"We have {sum} items in inventory.");
