//using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Bread
  {
    //public Dictionary<string, int> breadChoices = new Dictionary<string, int>(){{"white", 2}, {"sordugth", 2}, {"multigrain", 3}, {"gluten-free", 3}};
    public string Name {get; set;}
    public int Number {get; set;}
    public int Price {get; set;}

    public Bread(string name, int number, int price)
    {
      Name = name;
      Number = number;
      Price = price;
    }

    public int CalculateCost()
    {
      return (Number / 3 * 2 + Number % 3) * Price;
    }
  }
}