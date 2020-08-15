using FlightStory.Abstract;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;


namespace FlightStory.Implementation
{
    public class Story2 : Story
    {

        public string OrderNumber { get; set; }

        public string destination { get; set; }

        public bool IsFlightScheduled { get; set; }
        public Story2()
        {
        }


        public override void ShowStory()
        {
            string directory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string filePath = Path.Combine(directory, "content", "coding-assigment-orders.json");
            using (StreamReader r = new StreamReader(filePath))
            {
                string json = r.ReadToEnd();
                Dictionary<string, Story2> OrderData = JsonConvert.DeserializeObject<Dictionary<string, Story2>>(json);
                var YYZ_totalOrder = 0;
                var YYC_totalOrder = 0;
                var YVR_totalOrder = 0;
                var YYZ_day = 1;
                var YYC_day = 1;
                var YVR_day = 1;
                var YYZ_flightnumber = 1;
                var YYC_flightnumber = 2;
                var YVR_flightnumber = 3;
                List<Story2> story = new List<Story2>();
                foreach (var order in OrderData)
                {
                    var flightstory = new Story2();
                    flightstory.Departure = "YUL";
                    switch (order.Value.destination)
                    {
                        case "YYZ":
                            YYZ_totalOrder += 1;
                            flightstory.Arrival = order.Value.destination;
                            flightstory.Day = YYZ_day;
                            flightstory.OrderNumber = order.Key;
                            flightstory.IsFlightScheduled = true;
                            flightstory.FlightNumber = YYZ_flightnumber.ToString();
                            if (YYZ_totalOrder == 20)
                            {
                                YYZ_day += 1;
                                YYZ_flightnumber += 3;
                            }

                            break;
                        case "YYC":
                            YYC_totalOrder += 1;

                            flightstory.Arrival = order.Value.destination;
                            flightstory.Day = YYC_day;
                            flightstory.OrderNumber = order.Key;
                            flightstory.IsFlightScheduled = true;
                            flightstory.FlightNumber = YYC_flightnumber.ToString();

                            if (YYC_totalOrder == 20)
                            {
                                YYC_day += 1;
                                YYC_flightnumber += 3;

                            }

                            break;
                        case "YVR":
                            YVR_totalOrder += 1;

                            flightstory.Arrival = order.Value.destination;
                            flightstory.Day = YVR_day;
                            flightstory.OrderNumber = order.Key;
                            flightstory.IsFlightScheduled = true;
                            flightstory.FlightNumber = YVR_flightnumber.ToString();

                            if (YVR_totalOrder == 20)
                            {
                                YVR_day += 1;
                                YVR_flightnumber += 3;
                            }
                            break;
                        default:
                            flightstory.FlightNumber = "not scheduled";
                            flightstory.OrderNumber = order.Key;
                            flightstory.IsFlightScheduled = false;
                            flightstory.Arrival = order.Value.destination;
                            break;
                    }

                    story.Add(flightstory);
                }

                foreach (var item in story)
                {
                    if (item.IsFlightScheduled)
                    {

                        Console.WriteLine("order: " + item.OrderNumber + ", flightNumber: " + item.FlightNumber + ", departure: "+item.Departure +", arrival: " + item.Arrival + ", day:" + item.Day.ToString());
                    }
                    else
                    {
                        Console.WriteLine("order: " + item.OrderNumber + ", flightNumber: " + item.FlightNumber);

                    }

                }
                Console.ReadLine();
            }
        }


    }


}
