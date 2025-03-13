namespace OOPIceTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle R = new Rectangle("Rectangle", 10.50, 12.50);
            R.Display();
            R.CalculateArea();

            Console.WriteLine("");

            Circle C = new Circle("Circle", 10);
            C.Display();
            C.CalculateArea();

            Console.ReadKey();
        }
    }
}
