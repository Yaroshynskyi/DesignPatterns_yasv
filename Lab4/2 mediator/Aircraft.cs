using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_mediator
{
    class Aircraft
    {
        public string Name;
        public bool IsTakingOff { get; set; }
        public CommandCentre CommandCentre { get; set; }

        public Aircraft(string name, CommandCentre commandCentre)
        {
            this.Name = name;
            this.CommandCentre = commandCentre;
        }

        public void Land()
        {
            Console.WriteLine($"Aircraft {this.Name} is requesting to land.");
            CommandCentre.RequestLanding(this);
        }

        public void TakeOff()
        {
            Console.WriteLine($"Aircraft {this.Name} is requesting to take off.");
            CommandCentre.RequestTakeOff(this);
        }
    }
}

