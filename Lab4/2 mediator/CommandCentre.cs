using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_mediator
{
    class CommandCentre
    {
        private List<Runway> _runways = new List<Runway>();
        private List<Aircraft> _aircrafts = new List<Aircraft>();

        public CommandCentre(Runway[] runways, Aircraft[] aircrafts)
        {
            this._runways.AddRange(runways);
            this._aircrafts.AddRange(aircrafts);
        }

        public void RequestLanding(Aircraft aircraft)
        {
            foreach (var runway in _runways)
            {
                if (runway.IsBusyWithAircraft == null)
                {
                    Console.WriteLine($"CommandCentre: Runway {runway.Id} is available.");
                    runway.Land(aircraft);
                    return;
                }
            }
            Console.WriteLine("CommandCentre: All runways are busy. Please wait.");
        }

        public void RequestTakeOff(Aircraft aircraft)
        {
            if (aircraft.CommandCentre != this)
            {
                Console.WriteLine("Aircraft is not registered with this command centre.");
                return;
            }

            foreach (var runway in _runways)
            {
                if (runway.IsBusyWithAircraft == aircraft)
                {
                    runway.TakeOff(aircraft);
                    return;
                }
            }
            Console.WriteLine("CommandCentre: Aircraft is not on any runway.");
        }
    }
}
