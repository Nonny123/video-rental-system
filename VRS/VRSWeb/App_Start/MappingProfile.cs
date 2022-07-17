using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VRSWeb.Dtos;
using VRSWeb.Models;

namespace VRSWeb.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<CustomerDto, Customer>();
        }
    }
}