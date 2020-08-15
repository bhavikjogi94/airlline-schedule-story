using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightStory.Interface
{
    interface IStory
    {

        string FlightNumber { get; set; }
        string Departure { get; set; }
        string Arrival { get; set; }
        int Day { get; set; }

        void ShowStory();
    }
}
