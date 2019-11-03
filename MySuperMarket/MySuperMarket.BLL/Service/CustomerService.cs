using AutoMapper;
using MySuperMarket.BLL.BusinessObjects;
using MySuperMarket.BLL.ServiceInterface;
using MySuperMarket.DAL.Entity;
using MySuperMarket.DAL.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MySuperMarket.BLL.Service
{
    public class CustomerService : ICustomerService
    {
        private IUnitOfWork unitOfWork;
        private readonly IMapper _mapper;

        public CustomerService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public IEnumerable<CustomerBO> GetCustomerAutoCompleteList(string searchKey)
        {
            var customerList = (unitOfWork.CustomerRepository.Get()
                              .Where(r => r.FirstName.StartsWith(searchKey, StringComparison.InvariantCultureIgnoreCase)) //rules that to be used in overloads and ignores string comparision
                                 .Select(r => new CustomerBO
                                 {
                                     Id = r.Id,
                                     FirstName = r.FirstName
                                 }));
            if (customerList.Count() == 0)
            {
                customerList = customerList.Concat(new CustomerBO[] { new CustomerBO() { Id = "-1", FirstName = "There Is No Such A Customer In Database" } });
                return customerList;
            }
            else
            {
                return customerList;
            }
        }

        public CustomerBO GetCustomerByID(int id)
        {
            var customer = unitOfWork.CustomerRepository.GetByID(id);
            if (customer == null)
            {
                throw new Exception();
            }
            return _mapper.Map<CustomerBO>(customer);
        }
    }
}
