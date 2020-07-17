using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Pastry
  {
    public string Name {get; set;}
    public int Number {get; set;}
    public int Price {get; set;}
    private static List<Pastry> _order = new List<Pastry> {};

    public Pastry(string name, int number, int price)
    {
      Name = name;
      Number = number;
      Price = price;
      _order.Add(this);
    }

    public int CalculatePastryCost()
    {
      return Number / 3 * (Price * 2 + 1) + Number % 3 * Price;
    }

    public static int CalculateTotalCost()
    {
      int totalPrice = 0;
      foreach(Pastry pastry in _order)
      {
        totalPrice += pastry.CalculatePastryCost();
      }
      return totalPrice;
    }

    public static List<Pastry> GetPastryOrder()
    {
      return _order;
    }

    public static void ClearPastryOrder()
    {
      _order.Clear();
    }
  }
}