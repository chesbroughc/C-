//Create an application feature that is intended to improve the renewal
//rate of subscriptions to a software. Displays a renewal message upon login
//uses decision statements to properly add branching logic to the application

Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

if (daysUntilExpiration == 0)
{
    Console.WriteLine("Your subscription has expired.");
}

else if (daysUntilExpiration == 1)
{
    discountPercentage = 20;
    Console.WriteLine($"Your subscription expires within a day!\nRenew now and save {discountPercentage}%.");
}

else if ((daysUntilExpiration <= 5) && (daysUntilExpiration > 0)) 
{
    discountPercentage = 10;
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.\nRenew now and save {discountPercentage}%.");
}

else if ((daysUntilExpiration <= 10) && (daysUntilExpiration > 5))
{
    Console.WriteLine("Your subscription will expire soon. Renew now.");
}

else if (daysUntilExpiration > 10)
{
    Console.WriteLine("");
}

else
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}
