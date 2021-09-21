namespace Triangle
{
  public class TriangleChecker
  {
    public string IsTriangle(int sideA, int sideB, int sideC)
    {
      if ((sideA > (sideB + sideC)) || (sideB > (sideA + sideC)) || (sideC > (sideA + sideB)))
      {
        return "Not a triangle";
      }
      else if ((sideA != sideB) && (sideA != sideC) && (sideB != sideC))
      {
        return "Is a scalene triangle";
      }
      else if ((sideA == sideB) && (sideA == sideC))
      {
        return "Is an equilateral triangle";
      }
      else
      {
        return "Is an isosceles triangle";
      }
    }
  }
}