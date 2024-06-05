using _1_Factory;
using System;
using System.Collections.Generic;
using System.Threading.Channels;

public class EducationalSubscription : Subscription
{
    public EducationalSubscription(decimal monthlyFee, int minimumSubscriptionPeriod, List<string> channels)
        : base(monthlyFee, minimumSubscriptionPeriod, channels)
    {
    }

    public override void ShowDetails()
    {
        Console.WriteLine("Educational Subscription Details:");
        Console.WriteLine($"Monthly Fee: ${MonthlyFee}");
        Console.WriteLine($"Minimum Period: {MinimumSubscriptionPeriod} months");
        Console.WriteLine("Channels:");
        foreach (var channel in Channels)
        {
            Console.WriteLine($"- {channel}");
        }
    }
}

