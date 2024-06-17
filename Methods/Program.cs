
namespace Methods
{

    class Program
    {
        static void Main(string[] args)
        {
            var point = new Point(10, 20);

            point.Move(100, 200);
            Console.WriteLine("Point is at {0}, {1}", point.X, point.Y);
        }
    }
}