﻿using Store.Contractors;
using Store.domain;

namespace Store.Constractors
{
    public interface IPaymentService
    {
        string Name { get; }

        string Title { get; }

        Form FirstForm(Order order);

        Form NextForm(int step, IReadOnlyDictionary<string, string> values);

        OrderPayment GetPayment(Form form);
    }
}
