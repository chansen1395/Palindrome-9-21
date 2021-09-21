using Microsoft.VisualStudio.TestTools.UnitTesting;
using Triangle;

namespace Triangle.Tests
{
  [TestClass]
  public class TriangleTests
  {

    [TestMethod]
    public void IsTriangle_IsoscelesTriangle_True()
    {
      TriangleChecker testTriangle = new TriangleChecker();
      Assert.AreEqual("Is an isosceles triangle", testTriangle.IsTriangle(5, 5, 7));
    }

    [TestMethod]
    public void IsTriangle_DoesNotCreateATriangle_False()
    {
      TriangleChecker testTriangle = new TriangleChecker();
      Assert.AreEqual("Not a triangle", testTriangle.IsTriangle(2, 8, 2));
    }

    [TestMethod]
    public void IsTriangle_ScaleneTriangle_True()
    {
      TriangleChecker testTriangle = new TriangleChecker();
      Assert.AreEqual("Is a scalene triangle", testTriangle.IsTriangle(4, 5, 7));
    }

    [TestMethod]
    public void IsTriangle_EquilateralTriangle_True()
    {
      TriangleChecker testTriangle = new TriangleChecker();
      Assert.AreEqual("Is an equilateral triangle", testTriangle.IsTriangle(2, 2, 2));
    }
  }
}