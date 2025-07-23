using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObject
{
    public class ProductDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } =default!;
        public string Description { get; set; } = default!;
        public string ProductUrl { get; set; } = default!;
        public decimal Price { get; set; }
        public string BrandName { get; set; } = default!;
        public string TypeName { get; set; } = default!;




    }
}
