using Microsoft.EntityFrameworkCore;
using MMT_Test_Ness.Dto;
using MMT_Test_Ness.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace MMT_Test_Ness.Data
{
    public class ProcessRepository : IProcessRepository
    {
        private readonly DataContext _context;

        public ProcessRepository(DataContext context)
        {
            this._context = context;
        }

        public async Task<CUSTOMERDTO> GetCustomer(string email)
        {
            //Place in appsettings.json when ready
            string apiKey = "1CrsOooSHlV15C7OYnLY0DHjBHyjzoI8LNHITV04cNCyNCahecPDhw ==";
;            var customerFromAPI = new CUSTOMERDTO();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://customer-account-details.azurewebsites.net/api/GetUserDetails?code=1CrsOooSHlV15C7OYnLY0DHjBHyjzoI8LNHITV04cNCyNCahecPDhw==&&email=" + email))
                {
                    var apiResponse = await response.Content.ReadAsStringAsync();
                    customerFromAPI = JsonConvert.DeserializeObject<CUSTOMERDTO>(apiResponse);
                }
            }

            return customerFromAPI;
        }

        public async Task<ORDERS> GetOrder(string customerid)
        {
                var ordersForClient = await _context.ORDERS.Where(a => a.CUSTOMERID == customerid)
                .OrderByDescending(n => n.ORDERDATE).FirstOrDefaultAsync();
                return ordersForClient;
        }

        public async Task<IEnumerable<ORDERITEMS>> GetOrderItems(int orderid)
        {
            var ordersItemsForClient = await _context.ORDERITEMS.Where(a => a.ORDERID == orderid).ToListAsync();
            return ordersItemsForClient;
        }

    }
}
