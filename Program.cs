using OOP.bankAccount;
using OOP.enums;
using OOP.Person;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        var Martin = new Person();
        Martin.Name = "Martin Jose";
        Martin.DateOfBirth = new DateTime(2002, 11, 09);

        Martin.FavoriteAncientWonder = WondersOfTheAncientWorld.GreatPyramidOfGiza;

        Martin.Children.Add(new Person { Name = "Martin Elias" });
        Martin.Children.Add(new Person { Name = "Eilen" });

        Console.WriteLine($"Martin's Children {Martin.Children.Count}");
        Console.WriteLine("For");
        for (int i = 0; i < Martin.Children.Count; i++)
        {

            Console.WriteLine(Martin.Children[i].Name);

        }

        Console.WriteLine("Foreach");
        foreach (var item in Martin.Children)
        {

            Console.WriteLine(item.Name);
        }
        Console.WriteLine("This field");
        Console.WriteLine($"Sam's first child is {Martin[0].Name}");
        Console.WriteLine($"Sam's second child is {Martin[1].Name}");

        Console.WriteLine(format:
 "{0}'s favorite wonder is {1}. It's integer is {2}.",
 arg0: Martin.Name,
 arg1: Martin.FavoriteAncientWonder,
 arg2: (int)Martin.FavoriteAncientWonder);

        Console.WriteLine("------------------------------");

        //BankAccount
        BankAccount.InterestRate = 0.012M; // store a shared value

        var MartinAccount = new BankAccount();
        MartinAccount.AccountName = "Mrs. Martin";
        MartinAccount.Balance = 2400;

        Console.WriteLine(format: "{0} earned {1:C} interest.",
 arg0: MartinAccount.AccountName,
 arg1: MartinAccount.Balance * BankAccount.InterestRate);
        Console.WriteLine("------------------------------");

        var gerrierAccount = new BankAccount();
        gerrierAccount.AccountName = "Ms. Gerrier";
        gerrierAccount.Balance = 98;
        Console.WriteLine(format: "{0} earned {1:C} interest.",
         arg0: gerrierAccount.AccountName,
         arg1: gerrierAccount.Balance * BankAccount.InterestRate);

        Console.WriteLine("------------------------------");


        Martin.FavoritePrimaryColor = "Red";
        Console.WriteLine($"Martin's favorite primary color is {Martin.
        FavoritePrimaryColor}.");
    }



}