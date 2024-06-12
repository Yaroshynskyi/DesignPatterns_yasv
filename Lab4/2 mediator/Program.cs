using _2_mediator;
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var runway1 = new Runway();
        var runway2 = new Runway();
        var commandCentre = new CommandCentre(new[] { runway1, runway2 }, new Aircraft[] { });

        var aircraft1 = new Aircraft("Aircraft1", commandCentre);
        var aircraft2 = new Aircraft("Aircraft2", commandCentre);

        commandCentre.RequestLanding(aircraft1);
        commandCentre.RequestLanding(aircraft2);

        aircraft1.TakeOff();
        aircraft2.TakeOff();
    }
}