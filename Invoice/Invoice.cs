using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoice
{
    public class Invoice
    {
        private readonly int account;
        private readonly string customer;
        private readonly string provider;
        private string article;
        private int quantity;

        public Invoice(int account, string customer, string provider, string article, int quantity)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
            this.article = article;
            this.quantity = quantity;
        }

        public void Calculate(float price, bool VAT = false)
        {
            Console.WriteLine($"Аккаунт {account}");
            Console.WriteLine($"Замовник {customer}");
            Console.WriteLine($"Постачальник {provider}");
            Console.WriteLine($"Постачальник {article}");
            Console.WriteLine($"Постачальник {quantity}");
            Console.WriteLine($"Ціна {price}");

            if (VAT)
                Console.WriteLine($"Ціна з ПДВ {price + price * 0.06f}");
        }
    }
}