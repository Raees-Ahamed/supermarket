using AutoMapper;
using MySuperMarket.BLL.BusinessObjects;
using MySuperMarket.DAL.Entity;
using MySuperMarket.Web.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySuperMarket.Web.Automapper
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
            CreateMap<CustomerBO, Customer>().ReverseMap();
            CreateMap<OrderItemBO, OrderItem>().ReverseMap();
            CreateMap<OrderBO, Order>().ReverseMap();
            //CreateMap<ProductBO, Product>().ReverseMap();
            CreateMap<OrderBO, OrderItemBO>().ReverseMap();
            CreateMap<Order, OrderItem>().ReverseMap();
            CreateMap<UserBO, UserViewModel>().ReverseMap();

        }
    }
}
