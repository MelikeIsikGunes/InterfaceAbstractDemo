using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo.Abstract
{
    //İki şirkette de içleri aynı olan metot. Ortak operasyonları
    public abstract class BaseCustomerManager : ICustomerService
    {
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Save to db: " + customer.FirstName);
        }
    }
}
