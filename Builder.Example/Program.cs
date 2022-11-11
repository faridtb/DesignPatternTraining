using Builder.Example;



// Klassik Style
#region Klassik
House newHouse1 = new() // yarimciq infolarla yaradilan ev - 1
{
    City = "Tel Aviv",
    Country = "Israel",
    Street = "Albert Aqarunov",
    BuildYear = 2005,
    BalconyCount = 1,
    HasChildPark = true,
};

//Agent.AddHouse(newHouse1);

House newHouse2 = new() // Full info ile yaradilan ev
{
    Street = "Eli Isgenderov",
    Country = "Azerbaycan",
    City = "Baku",
    RoomCount = 4,
    BathCount = 1,
    BalconyCount = 2,
    BuildYear = 1955,
    IsDoublex = false,
    HasParking = true,
    HasChildPark = false,
    HasPool = false,
    HasStuff = true,
    HasAirConditioning = true,
};

//Agent.AddHouse(newHouse2);

#endregion


// Builder DP
#region Builder DP

// Klassik Build
House house = HouseBuilder.StartClassicBuild("AZERBAIJAN", "Ganja","M.Resulzade",1988,6)
    .setBalconyCount(1)
    .setBathCount(2)
    .Build();


//Agent.AddHouse(house);


//Hovuzlu Qelibine uygun Ev

House poolHouse = HouseBuilder.StartWithPoolBuild("AZERBAIJAN", "Ganja", "M.Resulzade", 1988, 6)
    .setBalconyCount(1)
    .setBathCount(2)
    .Build();

//Agent.AddHouse(poolHouse);

#endregion