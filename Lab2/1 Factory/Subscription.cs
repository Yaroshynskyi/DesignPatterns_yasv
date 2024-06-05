using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Factory
{
 public abstract class Subscription
{
    public decimal MonthlyFee { get; set; }
    public int MinimumSubscriptionPeriod { get; set; }
    public List<string> Channels { get; set; }

    public Subscription(decimal monthlyFee, int minimumSubscriptionPeriod, List<string> channels)
    {
        MonthlyFee = monthlyFee;
        MinimumSubscriptionPeriod = minimumSubscriptionPeriod;
        Channels = channels;
    }

    public abstract void ShowDetails();
}
}
