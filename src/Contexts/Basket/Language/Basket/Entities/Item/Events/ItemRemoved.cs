﻿using System;
using System.Collections.Generic;
using System.Text;
using Infrastructure.Commands;

namespace eShop.Basket.Basket.Entities.Item.Events
{
    public interface ItemRemoved : IStampedEvent
    {
        Guid BasketId { get; set; }
        Guid ProductId { get; set; }
    }
}
