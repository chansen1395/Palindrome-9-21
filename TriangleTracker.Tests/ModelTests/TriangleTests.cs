using Microsoft.VisualStudio.TestTools.UnitTesting;
using Triangle;

namespace Triangle.Tests
{
  [TestClass]
  public class TriangleTests
  {

    [TestMethod]
    public void IsTriangle_CreatesATriangle_True()
    {
      TriangleChecker testTriangle = new TriangleChecker();
      Assert.AreEqual(true, testTriangle.IsTriangle(1, 1, 1));
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