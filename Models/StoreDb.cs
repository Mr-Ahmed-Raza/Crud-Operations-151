using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_OPERATIONS__151.Models
{
    public class StoreDb:DbContext
    {
        public StoreDb(DbContextOptions<StoreDb> options) : base(options)
        {


        }
        public DbSet<OrderModel> orderModels { get; set; }
    }
}
