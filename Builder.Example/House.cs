using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Example
{
    internal class House
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        public int RoomCount { get; set; }
        public int BathCount { get; set; }
        public int BalconyCount { get; set; }
        public int BuildYear { get; set; }

        public bool IsDoublex { get; set; }
        public bool HasParking { get; set; }
        public bool HasChildPark { get; set; }
        public bool HasStuff { get; set; }
        public bool HasPool { get; set; }
        public bool HasAirConditioning { get; set; }


        public House()
        {

        }

        public House(string street, string city, string country, int roomCount, int bathCount, int balconyCount, int buildYear,
            bool isDoublex, bool hasParking, bool hasChildPark, bool hasStuff, bool hasPool, bool hasAirConditioning)
        {
            Street = street;
            City = city;
            Country = country;
            RoomCount = roomCount;
            BathCount = bathCount;
            BalconyCount = balconyCount;
            BuildYear = buildYear;
            IsDoublex = isDoublex;
            HasParking = hasParking;
            HasChildPark = hasChildPark;
            HasStuff = hasStuff;
            HasPool = hasPool;
            HasAirConditioning = hasAirConditioning;
        }


        public override string ToString()
        {
            return ($"Kuce:{Street}\n" +
                $"Seher:{City}\n" +
                $"Olke:{Country}\n" +
                $"Otaq Sayi:{RoomCount}\n" +
                $"Hamam Sayi:{BathCount}\n" +
                $"Balkon Sayi:{BalconyCount}\n" +
                $"Tikilme Tarixi:{BuildYear}\n" +
                $"Parking:{(HasParking == true ? "Var" : "Yoxdur")}\n" +
                $"Usaq Parki:{(HasChildPark == true ? "Var" : "Yoxdur")}\n" +
                $"Hovuz:{(HasPool == true ? "Var" : "Yoxdur")}\n");
        }
    }
}
