using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread bread = new Bread(3);
      Assert.AreEqual(typeof(Bread), bread.GetType());
    }

    [TestMethod]
    public void CalculateCost_CalculateThreeBreadOrderCost_Integer()
    {
      Bread bread = new Bread(3);
      Assert.AreEqual(10, bread.CalculateCost());
    }

    [TestMethod]
    public void CalculateCost_CalculateSevenBreadOrderCost_Integer()
    {
      Bread bread = new Bread(7);
      Assert.AreEqual(25, bread.CalculateCost());
    }
  }
}