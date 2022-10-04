namespace Book
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Book book = new Book(new Author("Крістофер Паоліні", ConsoleColor.Red), new Title("Ерагон", ConsoleColor.Blue), new Content("Зміст", ConsoleColor.Yellow));
            book.Show();
            Console.ReadLine();
        }
    }
}