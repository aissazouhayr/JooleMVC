using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainRepository.Entities
{
    class Product
    {
        public int ManufacturerID { get; set; }
        public string SubCategoryID { get; set; }
        public string ProductName { get; set; }
        public string ProductImage { get; set; }
        public string Series { get; set; }
        public string  Model { get; set; }
        public string  Model_Year  { get; set; }
        public string  Series_info { get; set; }
    }
}

