using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Example
{
    internal class HouseBuilder
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


        public static HouseBuilder StartClassicBuild(string country, string city, string street, int buildYear, int roomCount) // Normal
        {
            HouseBuilder newHouseBuilder = new()
            {
                Street = street,
                City = city,
                Country = country,
                RoomCount = roomCount,
                BuildYear = buildYear,
            };

            return newHouseBuilder;
        }


        public static HouseBuilder StartWithPoolBuild(string country, string city, string street, int buildYear, int roomCount) // Artiq Qelibli Build - Meselen Hovuzlu Ev 
        {
            HouseBuilder newHouseBuilder = new()
            {
                Street = street,
                City = city,
                Country = country,
                RoomCount = roomCount,
                BuildYear = buildYear,
                HasPool = true
            };

            return newHouseBuilder;
        }

        public House Build()
        {
            House house = new House()
            {
                Street = Street,
                City = City,
                Country = Country,
                RoomCount = RoomCount,
                BathCount = BathCount,
                BalconyCount = BalconyCount,
                BuildYear = BuildYear,
                IsDoublex = IsDoublex,
                HasParking = HasParking,
                HasChildPark = HasChildPark,
                HasStuff = HasStuff,
                HasPool = HasPool,
                HasAirConditioning = HasAirConditioning,
            };
            return house;
        }

        public HouseBuilder setStreet(string street)
        {
            Street = street;
            return this;
        }
        public HouseBuilder setCity(string city)
        {
            City = city;
            return this;
        }
        public HouseBuilder setCountry(string country)
        {
            Country = country;
            return this;
        }
        public HouseBuilder setRoomCount(int roomCount)
        {
            RoomCount = roomCount;
            return this;
        }
        public HouseBuilder setBathCount(int bathCount)
        {
            BathCount = bathCount;
            return this;
        }
        public HouseBuilder setBalconyCount(int balconyCount)
        {
            BalconyCount = balconyCount;
            return this;
        }
        public HouseBuilder setBuildYear(int buildYear)
        {
            BuildYear = buildYear;
            return this;
        }
    }
}
