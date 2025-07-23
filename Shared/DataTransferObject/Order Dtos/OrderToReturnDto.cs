using Shared.DataTransferObject.Identity_Dtod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObject.Order_Dtos
{
    public class OrderToReturnDto
    {
        public int Id { get; set; }
        public string UserEmail { get; set; } = default!;
        public DateTime OrderDate { get; set; }
        public AddressDto Address { get; set; } = default!;
        public ICollection<OrderItemDto> Items { get; set; } = [];
        public string DeliveryMethod { get; set; } = default!;
        public string OrderStatus { get; set; } = default!;
        public decimal SubTotal { get; set; }
        public decimal Total { get; set; }
    }
}
