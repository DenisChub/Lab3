namespace Figure
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Point[] points = new Point[]
            {
                new Point(1, -1, "A"),
                new Point(2, -2, "B"),
                new Point(3, -3, "C"),
                new Point(4, -4, "D"),
                new Point(5, -5, "F"),
            };

            Figure figure = new Figure(points);
            figure.PerimeterCalculator();
        }
    }
}