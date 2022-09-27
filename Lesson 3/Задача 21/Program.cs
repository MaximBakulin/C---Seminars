int Coordinate(string coordinatName, string pointName)
{
    Console.Write($"Введите координату {coordinatName} точки {pointName} (целое число): ");
    return Convert.ToInt32(Console.ReadLine());
}

int coordinatOnePointA = Coordinate("x", "A");
int coordinatTwoPointA = Coordinate("y", "A");
int coordinatThreePointA = Coordinate("z", "A");
int coordinatOnePointB = Coordinate("x", "B");
int coordinatTwoPointB = Coordinate("y", "B");
int coordinatThreePointB = Coordinate("z", "B");

double distanceCalculation(double x1, double x2, double y1, double y2, double z1, double z2)
{
  return Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2) + Math.Pow((z2-z1), 2));
}

double distanceBetweenPoints = distanceCalculation(coordinatOnePointA, coordinatOnePointB, coordinatTwoPointA, coordinatTwoPointB, coordinatThreePointA, coordinatThreePointB);

Console.WriteLine($"Расстояние между точками = {distanceBetweenPoints}");