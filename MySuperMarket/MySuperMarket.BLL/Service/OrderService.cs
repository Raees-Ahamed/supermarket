using AutoMapper;
using MySuperMarket.BLL.BusinessObjects;
using MySuperMarket.BLL.ServiceInterface;
using MySuperMarket.DAL.Entity;
using MySuperMarket.DAL.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MySuperMarket.BLL.Service
{
    public class OrderService : IOrderService
    {
        private IUnitOfWork unitOfWork;
        private readonly IProductService _productService;
        private readonly ICustomerService _customertService;
        private readonly IMapper _mapper;

        public OrderService(IUnitOfWork unitOfWork, IProductService productService, ICustomerService customerService)
        {
            this.unitOfWork = unitOfWork;
            _productService = productService;
            _customertService = customerService;
        }
        public int Add(OrderBO model)
        {
            if (model == null) { throw new Exception(); }
            model.ShippingAddress = _customertService.GetCustomerByID(Convert.ToInt32(model.CustomerId)).Address;
            foreach (var item in model.OrderItems)
            {
                if (item.Quantity > 10)
                {
                    throw new Exception();
                }
                else
                {
                    try
                    {
                        _productService.UpdateProductQuantity(item.ProductId, item.Quantity, false);
                    }
                    catch (Exception exp)
                    {
                        throw exp;
                    }
                }
            }
            if (model.OrderTotal > 5000)
            {
                throw new Exception();
            }
            try
            {
                var mapper = _mapper.Map<Order>(model);
                unitOfWork.OrderRepository.Insert(mapper);
                unitOfWork.Save();
            }
            catch (Exception ex)
            {

                throw new Exception("An Database Error Occured While Saving The Order", ex);
            }
            return GetRecentOrders().FirstOrDefault().Id; //first element of sequence

        }

        public IEnumerable<OrderBO> DeleteOrder(int id)
        {
            var editmodel = GetOrderByID(id, false);
            if (editmodel == null)
            {
                throw new Exception();
            }
            editmodel.OrderIsDeleted = true;
            try
            {
                var mapper = _mapper.Map<Order>(editmodel);
                unitOfWork.OrderRepository.Update(mapper);
                unitOfWork.Save();
                return GetRecentOrders();
            }
            catch (Exception ex)
            {
                throw new Exception("A Database Error Occured While Deleting The Order", ex);
            }
        }

        public OrderBO GetOrderByID(int id, bool withoutDeletedOrderItems)
        {
            OrderBO order = _mapper.Map<OrderBO>(unitOfWork.OrderRepository.GetByID(id));
            if (order == null)
            {
                throw new Exception();
            }
            if (withoutDeletedOrderItems)
            {
                var orderItemList = (unitOfWork.OrderItemRepository.Get()
              .Where(x => x.IsDeleted != true && x.OrderId == id)
              .Select(r => new OrderItemBO
              {
                  Id = r.Id,
                  ProductId = r.ProductId,
                  Quantity = r.Quantity,
                  TotalPrice = r.TotalPrice,
                  OrderId = r.OrderId,
                  Product = r.Product,
                  IsDeleted = r.IsDeleted,
                  Order = r.Order
              }));
                var mapper = _mapper.Map<IEnumerable<OrderItemBO>>(order.OrderItems);
                mapper = orderItemList.ToList();
            }
            return order;
        }

        public IEnumerable<OrderBO> GetRecentOrders()
        {
            var orderList = (unitOfWork.OrderRepository.Get()
                            .Where(x => x.OrderIsDeleted != true)
                            .OrderByDescending(x => x.Id)
                            .Select(r => new OrderBO
                            {
                                OrderCustomer = r.OrderCustomer,
                                Id = r.Id,
                                Date = r.Date,
                                ShippingAddress = r.ShippingAddress,
                                OrderTotal = r.OrderTotal
                            })).Take(5);
            return orderList;
        }

        public void UpdateOrder(OrderBO model)
        {
            if (model == null) { throw new Exception(); }
            var editmodel = GetOrderByID(model.Id, false);
            if (editmodel == null) { throw new Exception(); }
            var items = model.OrderItems.ToList();
            var i = 0;
            if (items.Count() > 0)
            {
                foreach (var orderItem in editmodel.OrderItems) 
                {
                    if (orderItem.IsDeleted == false) 
                    {
                        if (orderItem.ProductId != items[i].ProductId)
                        {
                            try
                            {
                                _productService.UpdateProductQuantity(orderItem.ProductId, orderItem.Quantity, true);

                                _productService.UpdateProductQuantity(items[i].ProductId, items[i].Quantity, false);
                            }
                            catch (Exception exp)
                            {
                                throw exp;
                            }
                            orderItem.ProductId = items[i].ProductId;
                        }
                        if (items[i].Quantity > 10)
                        {
                            throw new Exception();
                        }
                        else
                        {
                            orderItem.Quantity = items[i].Quantity; 
                        }
                        orderItem.TotalPrice = items[i].TotalPrice; 
                        if (items[i].IsDeleted)
                        {
                            orderItem.IsDeleted = items[i].IsDeleted;
                            try
                            {
                                _productService.UpdateProductQuantity(orderItem.ProductId, orderItem.Quantity, true);
                            }
                            catch (Exception ex)
                            {
                                throw ex;
                            }
                        }
                        i++;
                    }
                }
                if (model.OrderTotal > 5000)
                {
                    throw new Exception();
                }
                else
                {
                    editmodel.OrderTotal = model.OrderTotal;
                }
                try
                {
                    var mapper = _mapper.Map<Order>(editmodel);
                    unitOfWork.OrderRepository.Update(mapper);
                    unitOfWork.Save();
                }
                catch (Exception ex)
                {
                    throw new Exception("Oops A Database Error Occured While Updating The Order", ex);
                }
            }
        }
    }
}
