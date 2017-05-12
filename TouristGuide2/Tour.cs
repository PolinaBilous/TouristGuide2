using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouristGuide2
{
    public class Tour
    {
        public string Company { get; set; }
        public string Cities { get; set; }
        public string Countries { get; set; }
        public string Accommodations { get; set; }
        public string Excursions { get; set; }
        public string Service { get; set; }
        public int Duration { get; set; }
        public string DataFrom { get; set; }
        public int Cost { get; set; }

        public Tour(string company, string cities, string countries, string accommodations, 
        string excursions, string service, int duration, string dataFrom, int cost)
        {
            Company = company;
            Cities = cities;
            Countries = countries;
            Accommodations = accommodations;
            Excursions = excursions;
            Service = service;
            Duration = duration;
            DataFrom = dataFrom;
            Cost = cost;
        }
    }
}
