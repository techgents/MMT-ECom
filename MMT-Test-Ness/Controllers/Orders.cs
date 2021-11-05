using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MMT_Test_Ness.Data;
using MMT_Test_Ness.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MMT_Test_Ness.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Orders : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IProcessRepository _repo;

        public string message { get; set; }
        public Orders(IMapper mapper, IProcessRepository repo)
        {
            _mapper = mapper;
            _repo = repo;
        }


        [HttpPost]
        public async Task<IActionResult> GetCustomer(ClientQueryDto clientQueryDto)
        {
            var customerFromRepo = await _repo.GetCustomer(clientQueryDto.user);
            var customerToSend = _mapper.Map<CUSTOMERDTO>(customerFromRepo);
            return Ok(customerToSend);
        }

        [HttpPost("lastest")]
        public async Task<IActionResult> GetOrder(ClientQueryDto clientQueryDto)
        {

            var customerFromRepo = await _repo.GetCustomer(clientQueryDto.user);
            var cutomerToReturn = _mapper.Map<customer>(customerFromRepo);
            var orderFromRepo = await _repo.GetOrder(customerFromRepo.customerId);
            var orderToReturn = _mapper.Map<OrderReturnDto>(orderFromRepo);
            orderToReturn.DELIVERYADDRESS = customerFromRepo.houseNumber + ", " + customerFromRepo.street + ", " + customerFromRepo.town + ", " + customerFromRepo.postcode;
            var orderItemsFromRepo= await _repo.GetOrderItems(orderFromRepo.ORDERID);
            var orderItemsToReturn = _mapper.Map<IEnumerable<orderItems>>(orderItemsFromRepo);
            foreach (var item in orderItemsToReturn)
            {
                //Still to fix this - past the 5 hours mark of coding.
                //orderToReturn.orderItems.Add(item);
            }

            var genericResult = new { customer = cutomerToReturn, order = orderToReturn };

            return Ok(genericResult);
        }


    }
}
