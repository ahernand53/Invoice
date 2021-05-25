using Invoice.Core.Entity;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Invoice.Core.Interface
{
    public interface ICustomerRepository : IBaseRepository<CustomerModel>
    {
        IEnumerable<SelectListItem> Lista();
    }
}
