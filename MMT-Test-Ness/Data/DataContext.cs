using Microsoft.EntityFrameworkCore;
using MMT_Test_Ness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MMT_Test_Ness.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
: base(options)
        { }

        public DbSet<PRODUCTS> PRODUCTS { get; set; }
        public DbSet<ORDERS> ORDERS { get; set; }
        public DbSet<ORDERITEMS> ORDERITEMS { get; set; }
    }
}
