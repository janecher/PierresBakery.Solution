namespace PierresBakery.Models
{
  public class Bread
  {
    public int Order {get; set;}
    public const int oneBreadCost = 5;

    public Bread(int order)
    {
      Order = order;
    }

    public int CalculateCost()
    {
      return Order / 3 * 2 * oneBreadCost + Order % 3 * oneBreadCost;
    }
  }
}