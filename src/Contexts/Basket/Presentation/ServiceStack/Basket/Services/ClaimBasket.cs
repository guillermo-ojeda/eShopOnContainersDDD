﻿using System;
using System.Collections.Generic;
using System.Text;
using Infrastructure.ServiceStack;
using ServiceStack;

namespace eShop.Basket.Basket.Services
{
    [Api("Basket")]
    [Route("/basket/claim", "POST")]
    public class ClaimBasket : DomainCommand
    {
        public Guid BasketId { get; set; }
    }
}
