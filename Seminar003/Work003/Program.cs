double GetDistance(double x1, double y1, double x2, double y2)
{
    double distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
    return distance;
}



double GetNumber(string name)
{
    Console.WriteLine("Введите координату " + name);
    return Convert.ToDouble(Console.ReadLine());
}
double x1 = GetNumber("x1");
double y1 = GetNumber("y1");
double x2 = GetNumber("x2");
double y2 = GetNumber("y2");

Console.WriteLine("Растояние между точками = " + GetDistance(x1, y1, x2, y2));
