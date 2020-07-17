namespace PierresBakery.Models
{
  public class Pastry
  {
    public int Order {get; set;}

    public Pastry(int order)
    {
      Order = order;
    }

    public int CalculateCost()
    {
      return Order / 3 * 5 + Order % 3 * 2;
    }
  }
}