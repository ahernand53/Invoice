using Invoice.Core.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Invoice.Data
{
    public class InvoiceDbContext: DbContext
    {
        public InvoiceDbContext(DbContextOptions<InvoiceDbContext> options) : base(options)
        { }

        public DbSet<CustomerModel> Customers { get; set; }
    }
}
