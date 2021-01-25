using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;
using System;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new NeroCustomerManager();
            // BaseCustomerManager customerManager = new StarbucksCustomerManager(new CustomerCheckManager());
            customerManager.Save(new Customer { DateOfBirth = new DateTime(1985, 1, 6), FirstName = "Engin", LastName = "Demiroğ", NationalityId = "12345678910" });
            Console.ReadLine();


            //SENARYO : Kahve dükkanları için müşteri yönetimi yapan bir sistem yazmak istiyoruz.
            //Starbucks ve Nero Firması için çalışıyoruz.
            //İki firma da müşterilerini veritabanına kaydetmek istiyor.
            //Starbucks müşterileri kaydederken, mutlaka mernis doğrulaması istiyor. Nero müşterileri kaydederken böyle bir şey istemiyor
   
        }
    }
}
