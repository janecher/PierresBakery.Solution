using System;
using PierresBakery.Models;
class Program
{
  static void Main()
  {
    Console.WriteLine("Welcome to Pierre's Bakery!");
    Console.WriteLine("We have delicios products and nice prices!");
    Console.WriteLine("You can order bread loaves for buy 2, get 1 free! A single loaf costs $5");
    Console.WriteLine("And you can order pastries for buy 1 for $2 or 3 for $5");
    GatherUserInput();
  }

  public static void GatherUserInput()
  {
    Console.WriteLine("Please input how many bread loaves would you like?");
    string breadInput = Console.ReadLine();
    int breadLoaves;
    Console.WriteLine("Please input how many pastries would you like?");
    string pastryInput = Console.ReadLine();
    int pastryNumber;
    if(int.TryParse(breadInput, out breadLoaves) && int.TryParse(pastryInput, out pastryNumber))
    {
      if(breadLoaves >= 0 && pastryNumber >=0)
      {
        Bread breadOrder = new Bread(breadLoaves);
        Pastry pastryOrder = new Pastry(pastryNumber);
        Console.WriteLine("Price for your order is $" + (breadOrder.CalculateCost() + pastryOrder.CalculateCost()));
      }
      else
      {
        Console.WriteLine("Your input is incorrect, please input a number 0 or more");
        GatherUserInput();
      }
    }
    else
    {
      Console.WriteLine("Your input is incorrect, please input a number 0 or more");
      GatherUserInput();
    }   
  }
}