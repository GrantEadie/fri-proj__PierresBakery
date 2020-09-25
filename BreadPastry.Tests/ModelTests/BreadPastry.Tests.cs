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
    }

  }