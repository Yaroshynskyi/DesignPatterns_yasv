using System;
using System.Collections.Generic;

public abstract class SubscriptionFactory
{
    public abstract object BuySubscription(string type, decimal monthlyFee, int minimumSubscriptionPeriod, List<string> channels);
}
