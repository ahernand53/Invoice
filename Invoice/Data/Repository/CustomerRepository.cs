using Invoice.Core.Entity;
using Invoice.Core.Interface;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Invoice.Data.Repository
{
    public class CustomerRepository : BaseRepository<CustomerModel>, ICustomerRepository
    {

        public CustomerRepository(InvoiceDbContext context): base(context)
        {

        }

        public IEnumerable<SelectListItem> Lista()
        {
            return Todos().Select(s => new SelectListItem
            {
                Text = s.Nombre,
                Value = s.ID.ToString()
            });
        }
    }
}
