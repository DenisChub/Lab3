namespace Rectangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Rectangle rectangle = new Rectangle(6, 3);
            Console.WriteLine($"Площа =  {rectangle.Area}");
            Console.WriteLine($"Периметр =  {rectangle.Perimeter}");
        }
    }
}