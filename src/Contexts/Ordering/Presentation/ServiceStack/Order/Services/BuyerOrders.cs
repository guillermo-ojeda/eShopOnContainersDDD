﻿using System;
using System.Collections.Generic;
using System.Text;
using Infrastructure.ServiceStack;
using ServiceStack;

namespace eShop.Ordering.Order.Services
{
    [Api("Ordering")]
    [Route("/order", "GET")]
    public class BuyerOrders : Paged<Models.OrderingOrderIndex>
    {
        public string OrderStatus { get; set; }
        public DateTime? From { get; set; }
        public DateTime? To { get; set; }
    }
}
