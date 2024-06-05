using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        var channels = new List<string> { "Channel 1", "Channel 2" };

        var webSite = new WebSite();
        var mobileApp = new MobileApp();
        var managerCall = new ManagerCall();

        var domesticSubscriptionWeb = (DomesticSubscription)webSite.BuySubscription("domestic", 10.99m, 6, channels);
        var educationalSubscriptionMobile = (EducationalSubscription)mobileApp.BuySubscription("educational", 15.99m, 12, channels);
        var premiumSubscriptionManager = (PremiumSubscription)managerCall.BuySubscription("premium", 29.99m, 12, channels);

        Console.WriteLine("Subscription purchased through website:");
        domesticSubscriptionWeb.ShowDetails();
        Console.WriteLine();

        Console.WriteLine("Subscription purchased through mobile app:");
        educationalSubscriptionMobile.ShowDetails();
        Console.WriteLine();

        Console.WriteLine("Subscription purchased through manager call:");
        premiumSubscriptionManager.ShowDetails();
    }
}
