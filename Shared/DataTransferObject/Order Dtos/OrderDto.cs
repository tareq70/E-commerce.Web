using Shared.DataTransferObject.Identity_Dtod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObject.Order_Dtos
{
    public class OrderDto
    {
        public string BasketId { get; set; } = default!;
        public int DeliveryMethodId { get; set; }
        public AddressDto Address { get; set; } = default!;
    }
}
