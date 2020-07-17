using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;
using System;
using System.Collections.Generic;

namespace PierresBakery.Tests
{
  [TestClass]
  public class PastryTests : IDisposable
  {
    public void Dispose()
    {
      Pastry.ClearPastryOrder();
    }

    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry pastry = new Pastry("croissant", 3, 3);
      Assert.AreEqual(typeof(Pastry), pastry.GetType());
    }

    [TestMethod]
    public void CalculateCost_CalculateTwoPastryOrderCost_Integer()
    {
      Pastry pastry = new Pastry("croissant", 2, 2);
      Assert.AreEqual(4, pastry.CalculatePastryCost());
    }

    [TestMethod]
    public void CalculateCost_CalculateThreePastryOrderCost_Integer()
    {
      Pastry pastry = new Pastry("croissant", 3, 2);
      Assert.AreEqual(5, pastry.CalculatePastryCost());
    }

    [TestMethod]
    public void CalculateCost_CalculateSevenPastryOrderCost_Integer()
    {
      Pastry pastry = new Pastry("croissant", 7, 2);
      Assert.AreEqual(12, pastry.CalculatePastryCost());
    }

    [TestMethod]
    public void CalculateTotalCost_CalculatePastryOrderCost_Integer()
    {
      Pastry pastry1 = new Pastry("croissant", 3, 2);
      Pastry pastry2 = new Pastry("scone", 3, 3);
      Assert.AreEqual(12, Pastry.CalculateTotalCost());
    }

    [TestMethod]
    public void GetPastryOrder_ReturnsEmptyList_PastryList()
    {
      List<Pastry> newList = new List<Pastry> { };
      List<Pastry> result = Pastry.GetPastryOrder();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetPastryOrder_ReturnsPastryOrder_PastryList()
    {
      Pastry pastry1 = new Pastry("croissant", 3, 2);
      Pastry pastry2 = new Pastry("croissant", 7, 2);
      List<Pastry> pastryList = new List<Pastry> {pastry1, pastry2};
      List<Pastry> result = Pastry.GetPastryOrder();
      CollectionAssert.AreEqual(pastryList, result);
    }
  }
}