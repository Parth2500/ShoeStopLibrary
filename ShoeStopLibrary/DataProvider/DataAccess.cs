using Microsoft.EntityFrameworkCore;
using ShoeStopLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoeStopLibrary.DataProvider
{
    public class DataAccess : DbContext
    {
        public DbSet<Users> Users { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<Address> Address { get; set; }

        public DataAccess(DbContextOptions<DataAccess> options)
            : base(options)
        {
        }
    }
}
