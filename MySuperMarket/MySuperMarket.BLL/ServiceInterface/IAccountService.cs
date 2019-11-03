using MySuperMarket.BLL.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MySuperMarket.BLL.ServiceInterface
{
    public interface IAccountService
    {
        Task<UserBO> Login(UserBO model);
        void Logout();
    }
}
