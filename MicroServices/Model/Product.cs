using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroServices.Model
{
    public class Product
    {
        // product model
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Category { get; set; }
    }
}
