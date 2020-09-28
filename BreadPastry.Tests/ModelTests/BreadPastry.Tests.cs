using Microsoft.VisualStudio.TestTools.UnitTesting;
using BreadPastry.Models;

namespace BreadPastry.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesInsanceOfBreadClass_Bread()
    {
      Bread newBread = new Bread(50);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void TotalBreadPrice_ReturnBreadPrice_Int()
    {
      Bread newBread = new Bread(9);
      Assert.AreEqual(20, newBread.TotalBreadPrice());
    }
  }

  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastryClass_Pastry()
    {
      Pastry newPastry = new Pastry(50);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

    [TestMethod]
    public void TotalBreadPrice_ReturnBreadPrice_Int()
    {
      Pastry newPastry = new Pastry(10);
      Assert.AreEqual(17, newPastry.TotalPastryPrice());
    }
  }

}