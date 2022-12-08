﻿using Store.Domain.Entities;
using Store.Domain.Repositories;

namespace Store.Tests.Repositories;

public class FakeDeliveryFeeRepository : IDeliveryFeeRepository
{
    public decimal Get(string zipCod)
    {
        return 10;
    }
}