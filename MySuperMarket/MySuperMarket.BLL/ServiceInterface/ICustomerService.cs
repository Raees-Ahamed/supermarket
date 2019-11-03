using MySuperMarket.BLL.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace MySuperMarket.BLL.ServiceInterface
{
    public interface ICustomerService
    {
        CustomerBO GetCustomerByID(int id);
        IEnumerable<CustomerBO> GetCustomerAutoCompleteList(string searchKey);
    }
}
