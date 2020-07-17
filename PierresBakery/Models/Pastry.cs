namespace PierresBakery.Models
{
  public class Pastry
  {
    public string Name {get; set;}
    public int Number {get; set;}
    public int Price {get; set;}

    public Pastry(string name, int number, int price)
    {
      Name = name;
      Number = number;
      Price = price;
    }

    public int CalculateCost()
    {
      return Number / 3 * (Price * 2 + 1) + Number % 3 * Price;
    }
  }
}