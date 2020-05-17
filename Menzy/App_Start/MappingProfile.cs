using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Menzy.Dtos;
using Menzy.Models;

namespace Menzy.App_Start
{
    public class MappingProfile :Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<Food, FoodDto>();
            Mapper.CreateMap<CustomerDto, Customer>().ForMember(c => c.Id, opt => opt.Ignore());
            Mapper.CreateMap<FoodDto,Food>()
                .ForMember(c => c.Id, opt => opt.Ignore());

        }
    }
}