using DomainRepository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainRepository.Abstarct
{
    interface IProductRepository
    {
        IEnumerable<Product> Products { get; set; }
    }
}
