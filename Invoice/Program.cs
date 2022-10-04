namespace Invoice
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Invoice invoice = new Invoice(12, "Александр Кременчуг", "Артем Ярмак", "Капуста", 200);
            invoice.Calculate(1700, true);
        }
    }
}