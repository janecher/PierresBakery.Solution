using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Bread
  {
    //public Dictionary<string, int> breadChoices = new Dictionary<string, int>(){{"white", 2}, {"sordugth", 2}, {"multigrain", 3}, {"gluten-free", 3}};
    public string Name {get; set;}
    public int Number {get; set;}
    public int Price {get; set;}
    private static List<Bread> _order = new List<Bread> {};
    public Bread(string name, int number, int price)
    {
      Name = name;
      Number = number;
      Price = price;
      _order.Add(this);
    }

    public int CalculateBreadCost()
    {
      return (Number / 3 * 2 + Number % 3) * Price;
    }

    public static int CalculateTotalCost()
    {
      int totalPrice = 0;
      foreach(Bread bread in _order)
      {
        totalPrice += bread.CalculateBreadCost();
      }
      return totalPrice;
    }

    public static List<Bread> GetBreadOrder()
    {
      return _order;
    }

    public static void ClearBreadOrder()
    {
      _order.Clear();
    }
  }
}