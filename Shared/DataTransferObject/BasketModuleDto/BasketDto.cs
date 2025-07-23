﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObject.BasketModuleDto
{
    public class BasketDto
    {
        public string Id { get; set; } // Guid

        public ICollection<BasketItemDto> Items { get; set; } = [];
    }
}
