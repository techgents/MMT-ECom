using MMT_Test_Ness.Dto;
using MMT_Test_Ness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MMT_Test_Ness.Data
{
    public interface IProcessRepository
    {
        Task<CUSTOMERDTO> GetCustomer(string email);
        Task<ORDERS> GetOrder(string customerid);
        Task<IEnumerable<ORDERITEMS>> GetOrderItems(int orderid);
    }
}
