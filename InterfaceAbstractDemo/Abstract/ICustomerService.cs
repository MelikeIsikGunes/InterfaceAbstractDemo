using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo.Abstract
{
    // Müşteri İşlemleri
    public interface ICustomerService
    {
        void Save(Customer customer); //bütün müşterilerde bu operasyon var
    }
}
