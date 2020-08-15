using FlightStory.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightStory
{
    class Program
    {
        static void Main(string[] args)
        {
            Story1 flight1 = new Story1("1","YUL","YYZ",1);
            Story1 flight2 = new Story1("2", "YUL", "YYC", 1);
            Story1 flight3 = new Story1("3", "YUL", "YVR", 1);
            Story1 flight4 = new Story1("4", "YUL", "YYZ", 2);
            Story1 flight5 = new Story1("5", "YUL", "YYC", 2);
            Story1 flight6 = new Story1("6", "YUL", "YVR", 2);

            Console.WriteLine("****** Story 1: ****** \n");
            flight1.ShowStory();
            flight2.ShowStory();
            flight3.ShowStory();
            flight4.ShowStory();
            flight5.ShowStory();
            flight6.ShowStory();

            Console.WriteLine("****** Story 2: ****** \n");

            Story2 story2 = new Story2();
            story2.ShowStory();

            Console.ReadLine();
        }
    }
}
