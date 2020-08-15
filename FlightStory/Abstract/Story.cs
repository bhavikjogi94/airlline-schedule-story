using FlightStory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightStory.Abstract
{
    public abstract class Story : IStory
    {
        public string FlightNumber { get; set; }
        public string Departure { get; set; }
        public string Arrival { get; set; }
        public int Day { get; set; }


        public Story()
        {


        }

        public Story(string flightnumber, string departure, string arrival, int day)
        {
            this.FlightNumber = flightnumber;
            this.Departure = departure;
            this.Arrival = arrival;
            this.Day = day;
        }
        public abstract void ShowStory();
    }
}
