using System;
using System.Collections.Generic;

public class ManagerCall : SubscriptionFactory
{
    public override object BuySubscription(string type, decimal monthlyFee, int minimumSubscriptionPeriod, List<string> channels)
    {
        // Logic for buying a subscription via manager call
        return CreateSubscription(type, monthlyFee, minimumSubscriptionPeriod, channels);
    }

    private object CreateSubscription(string type, decimal monthlyFee, int minimumSubscriptionPeriod, List<string> channels)
    {
        switch (type.ToLower())
        {
            case "domestic":
                return new DomesticSubscription(monthlyFee, minimumSubscriptionPeriod, channels);
            case "educational":
                return new EducationalSubscription(monthlyFee, minimumSubscriptionPeriod, channels);
            case "premium":
                return new PremiumSubscription(monthlyFee, minimumSubscriptionPeriod, channels);
            default:
                throw new ArgumentException("Invalid subscription type.");
        }
    }
}
