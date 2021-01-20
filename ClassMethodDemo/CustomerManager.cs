using Stripe;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        public void Ekle(Customer customer)
        {
            Console.WriteLine("Müşteri eklendi:" + customer.Name);
            Console.WriteLine("Müşteri yaşı:" + customer.Age);
            Console.WriteLine("Müşteri cinsiyeti:" + customer.Gender);
        }

        public void Sil(Customer customer)
        {
            Console.WriteLine(customer.Name);
        }
        public void Listele(Customer customer)
        {
            Console.WriteLine(customer.Name);
        }
    }
}
