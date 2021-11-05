using MMT_Test_Ness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using MMT_Test_Ness.Dto;

namespace MMT_Test_Ness.Helper
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            //Map DB Structure
            CreateMap<PRODUCTS, PRODUCTSDTO>();
            CreateMap<ORDERS, OrderReturnDto>()
                .ForMember(destination => destination.OrderNumber,
                    options => options.MapFrom(source => source.ORDERID));
            CreateMap<ORDERITEMS, OrderReturnDto>();
            CreateMap<ORDERITEMS, ORDERITEMSDTO>();

            CreateMap<CUSTOMERDTO, customer>();

            CreateMap<ORDERS, customer>();

            CreateMap<ORDERITEMS, customer>();

            CreateMap<ORDERITEMS, orderItems>();




        }


    }
}
