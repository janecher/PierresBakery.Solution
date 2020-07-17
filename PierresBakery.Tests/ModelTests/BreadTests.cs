using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;
using System;
using System.Collections.Generic;

namespace PierresBakery.Tests
{
  [TestClass]
  public class BreadTests : IDisposable
  {
    public void Dispose()
    {
      Bread.ClearBreadOrder();
    }

    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread bread = new Bread("multigrain", 3, 5);
      Assert.AreEqual(typeof(Bread), bread.GetType());
    }

    [TestMethod]
    public void CalculateCost_CalculateThreeBreadOrderCost_Integer()
    {
      Bread bread = new Bread("multigrain", 3, 5);
      Assert.AreEqual(10, bread.CalculateBreadCost());
    }

    [TestMethod]
    public void CalculateCost_CalculateSevenBreadOrderCost_Integer()
    {
      Bread bread = new Bread("multigrain", 7, 5);
      Assert.AreEqual(25, bread.CalculateBreadCost());
    }

    [TestMethod]
    public void GetBreadOrder_ReturnsEmptyList_BreadList()
    {
      List<Bread> newList = new List<Bread> { };
      List<Bread> result = Bread.GetBreadOrder();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetBreadOrder_ReturnsBreadOrder_BreadList()
    {
      Bread bread1 = new Bread("multigrain", 3, 5);
      Bread bread2 = new Bread("white", 1, 4);
      List<Bread> breadList = new List<Bread> {bread1, bread2};
      List<Bread> result = Bread.GetBreadOrder();
      CollectionAssert.AreEqual(breadList, result);
    }
  }
}