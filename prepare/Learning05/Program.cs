using System;
class Program
{
    static void Main(string[] args)
    {
       
        List<Shape> shapes = new List<Shape>();

        Square S1 = new Square("Red", 5);
        shapes.Add(S1);

        Circle S2 = new Circle("Orange", 10);
        shapes.Add(S2);

        Rectangle S3 = new Rectangle("Yellow", 2, 4);
        shapes.Add(S3);

        foreach (Shape S in shapes)
        { 
            string color = S.GetColor();
            double area = S.GetArea();
            Console.WriteLine($"The \"{color}\" shape has the area of: {area:F2}.");
        }
    }
}