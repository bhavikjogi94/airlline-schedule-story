using FlightStory.Interface;
using System;


namespace FlightStory.Implementation
{
    public class Story1 : IStory
    {
        public string FlightNumber { get; set; }
        public string Departure { get; set; }
        public string Arrival { get; set; }
        public int Day { get; set; }

        public Story1()
        {


        }

        public Story1(string flightnumber, string departure, string arrival, int day)
        {
            this.FlightNumber = flightnumber;
            this.Departure = departure;
            this.Arrival = arrival;
            this.Day = day;
        }

        public  void ShowStory()
        {
            Console.WriteLine("Flight: " + this.FlightNumber.ToString() + ", departure: " + this.Departure + ", arrival: " + this.Arrival + ", day: " + this.Day.ToString()+"\n");
        }
    }
}
