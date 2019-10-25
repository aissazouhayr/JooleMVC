using DomainRepository.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainRepository.Concreate
{
    public class EFDBContext :DbContext
    {
        DbSet<Product> Products;
    }
}
