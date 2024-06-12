using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_mediator
{
    class Runway
    {
        public readonly Guid Id = Guid.NewGuid();
        public Aircraft? IsBusyWithAircraft;

        public void Land(Aircraft aircraft)
        {
            Console.WriteLine($"Runway {this.Id}: Aircraft {aircraft.Name} is landing.");
            this.IsBusyWithAircraft = aircraft;
            HighLightRed();
        }

        public void TakeOff(Aircraft aircraft)
        {
            Console.WriteLine($"Runway {this.Id}: Aircraft {aircraft.Name} is taking off.");
            this.IsBusyWithAircraft = null;
            HighLightGreen();
        }

        public void HighLightRed()
        {
            Console.WriteLine($"Runway {this.Id} is busy!");
        }

        public void HighLightGreen()
        {
            Console.WriteLine($"Runway {this.Id} is free!");
        }
    }
}
