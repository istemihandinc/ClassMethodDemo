using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Name = "İstemihan DİNÇ";
            customer1.Age = 25;
            customer1.Gender = "Male";

            Customer customer2 = new Customer();
            customer2.Name = "Arzu Ece ATİLA";
            customer2.Age = 28;
            customer2.Gender = "Female";

            Customer customer3 = new Customer();
            customer3.Name = "Sercan YALÇINKAYA";
            customer3.Age = 30;
            customer3.Gender = "Male";

            Customer[] customers = new Customer[] { customer1, customer2, customer3 };
            CustomerManager customermanager = new CustomerManager();
            
            Console.WriteLine("Müşteriler Eklendi:");
            Console.WriteLine(" ");
            customermanager.Ekle(customer1);
            Console.WriteLine(" ");
            customermanager.Ekle(customer2);
            Console.WriteLine(" ");
            customermanager.Ekle(customer3);
            Console.WriteLine("--- ");
            Console.WriteLine("Müşteriler Silindi:");
            Console.WriteLine(" ");
            customermanager.Sil(customer1);
            customermanager.Sil(customer2);
            customermanager.Sil(customer3);
            Console.WriteLine("--- ");
            Console.WriteLine("Müşteriler Listelendi:");
            Console.WriteLine(" ");
            customermanager.Listele(customer1);
            customermanager.Listele(customer2);
            customermanager.Listele(customer3);



        }
    }
}
