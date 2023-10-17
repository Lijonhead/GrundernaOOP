namespace GrundernaOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle1 = new Circle(5);
            Circle circle2 = new Circle(6);

            double area1 = circle1.GetArea();
            double area2 = circle2.GetArea();

            Console.WriteLine("Arean av circle1 med radien 5: " + area1);
            Console.WriteLine("Arean av circle2 med radien 6: " + area2);

            
        }
    }
}