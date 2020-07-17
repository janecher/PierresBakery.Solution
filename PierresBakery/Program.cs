using System;
using PierresBakery.Models;
using System.Collections.Generic;
class Program
{
  static void Main()
  {
    Console.WriteLine("Welcome to Pierre's Bakery!\n");
    Console.WriteLine("We have delicios products and nice prices!\n");
    Console.WriteLine("You can order bread loaves for buy 2, get 1 free! A single loaf costs depends on bread choice");
    Console.WriteLine("And you can order pastries for buy 2, get 1 for only $1! A single pastry costs depends on pastry choice\n");
    GetBreadOrder();
    GetPastryOrder();
    Console.WriteLine("\nYou ordered: " + BreadOrderInfo() + PastryOrderInfo());
    Console.WriteLine("Total price of your order is: $" + (Bread.CalculateTotalCost() + Pastry.CalculateTotalCost()));
  }

  public static string BreadOrderInfo()
  {
    string info = "";
    foreach(Bread bread in Bread.GetBreadOrder())
    {
      info += bread.Number + " " + bread.Name + " bread, ";
    }
    return info;
  }  

  public static string PastryOrderInfo()
  {
    string info = "";
    foreach(Pastry pastry in Pastry.GetPastryOrder())
    {
      info += pastry.Number + " " + pastry.Name;
    }
    return info;
  }

  public static void GetBreadOrder()
  {
    Console.WriteLine("Would you like to order bread? Y/N");
    string answer = Console.ReadLine().Trim();
    if(answer == "Y" || answer == "y")
    {
      AddBread();
      Console.WriteLine("Would you like to add more breads to your order? Y/N");
      string addBreadAnswer = Console.ReadLine().Trim();
      if(answer == "Y" || answer == "y")
      {
        AddBread();
      }
      else
      {
        return;
      }
    }
    else
    {
      return;
    }
  }

  public static Bread AddBread()
  {
    Dictionary<string, int> breadTypes = new Dictionary<string, int> {{"white", 4}, {"multigrain", 5}, {"sourdough", 4}, {"gluten-free", 5}};
    Console.WriteLine("We have these types of bread, which one would you like?\n");
    foreach(var bread in breadTypes)
    {
      Console.WriteLine(bread.Key + ", price $" + bread.Value);
    }
    string breadInput = Console.ReadLine().Trim();
    if(!breadTypes.ContainsKey(breadInput))
    {
      Console.WriteLine("\nSorry, we don't have that type of bread");
      AddBread();
    }
    int number = ItemsGetter();
    while(number == -1 )
    {
      number = ItemsGetter();
    }
    return new Bread(breadInput, number, breadTypes[breadInput]);
  }

  public static void GetPastryOrder()
  {
    Console.WriteLine("Would you like to order pastry? Y/N");
    string answer = Console.ReadLine().Trim();
    if(answer == "Y" || answer == "y")
    {
      AddPastry();
      Console.WriteLine("Would you like to add more pastry to your order? Y/N");
      string addBreadAnswer = Console.ReadLine().Trim();
      if(answer == "Y" || answer == "y")
      {
        AddPastry();
      }
      else
      {
        return;
      }
    }
    else
    {
      return;
    }
  }

  public static Pastry AddPastry()
  {
    Dictionary<string, int> pastryTypes = new Dictionary<string, int> {{"croissant", 3}, {"scone", 2}, {"tart", 4}, {"waffles", 3}};
    Console.WriteLine("We have these types of pastry, which one would you like?\n");
    foreach(var pastry in pastryTypes)
    {
      Console.WriteLine(pastry.Key + ", price $" + pastry.Value);
    }
    string pastryInput = Console.ReadLine();
    if(!pastryTypes.ContainsKey(pastryInput))
    {
      Console.WriteLine("\nSorry, we don't have that type of pastry");
      AddPastry();
    }
    int number = ItemsGetter();
    while(number == -1 )
    {
      number = ItemsGetter();
    }
    return new Pastry(pastryInput, number, pastryTypes[pastryInput]);   
  }

  public static void AddMorePastry()
  {
    Console.WriteLine("Would you like to add more pastries to your order? Y/N");
    string answer = Console.ReadLine();
    if(answer == "Y")
    {
      GetBreadOrder();
    }
    else
    {
      Console.WriteLine("Thank you, now you can choose the pastries");
      GetPastryOrder();
    }
  }

  public static int ItemsGetter()
  {
    Console.WriteLine("\nHow many items would you like to get?");
    string numberInput = Console.ReadLine();
    int number;
    if(int.TryParse(numberInput, out number) && number >=0)
    {
      return number;
    }
    else
    {
      Console.WriteLine("\nIncorrect input, should be a number no less than 0");
      return -1;
    }
  }
}