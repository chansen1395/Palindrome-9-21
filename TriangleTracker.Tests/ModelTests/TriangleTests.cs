using Microsoft.VisualStudio.TestTools.UnitTesting;
using Triangle;

namespace Triangle.Tests
{
  [TestClass]
  public class TriangleTests
  {

    // [TestMethod]
    // public void IsTriangle_CreatesATriangle_True()
    // {
    //   TriangleChecker testTriangle = new TriangleChecker();
    //   Assert.AreEqual("Is a triangle", testTriangle.IsTriangle(1, 1, 1));
    // }
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
  }
}

//   test('should correctly create a triangle object with three lengths', () => {
//     const triangle = new Triangle(2,4,5);
//     expect(triangle.side1).toEqual(2);
//     expect(triangle.side2).toEqual(4);
//     expect(triangle.side3).toEqual(5);
//   });
// });