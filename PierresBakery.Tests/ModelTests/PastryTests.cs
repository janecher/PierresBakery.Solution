using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry pastry = new Pastry(3);
      Assert.AreEqual(typeof(Pastry), pastry.GetType());
    }

    [TestMethod]
    public void CalculateCost_CalculateTwoPastryOrderCost_Integer()
    {
      Pastry pastry = new Pastry(2);
      Assert.AreEqual(4, pastry.CalculateCost());
    }

    [TestMethod]
    public void CalculateCost_CalculateThreePastryOrderCost_Integer()
    {
      Pastry pastry = new Pastry(3);
      Assert.AreEqual(5, pastry.CalculateCost());
    }
  }
}