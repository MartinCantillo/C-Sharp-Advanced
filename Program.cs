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
        foreach (var item in  Martin.Children)
        {
         
            Console.WriteLine(item.Name);
        }


        Console.WriteLine(format:
 "{0}'s favorite wonder is {1}. It's integer is {2}.",
 arg0: Martin.Name,
 arg1: Martin.FavoriteAncientWonder,
 arg2: (int)Martin.FavoriteAncientWonder);
    }
}