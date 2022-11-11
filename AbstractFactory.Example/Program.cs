
using AbstractFactory.Example;
using AbstractFactory.Example.Dtos;
using AbstractFactory.Example.Factories.Concretes;
using AbstractFactory.Example.Models.Interfaces;

XiaomiFactory xiaomiFactory = new();
Xiaomi mi9T = (Xiaomi)xiaomiFactory.GetPhone(new PhoneCreateDto { Model = "Mi 9T Pro", Count = 55, Memory = 256 });


SamsungFactory samsungFactory = new();
Samsung galaxyZ =(Samsung)samsungFactory.GetPhone(new PhoneCreateDto { Model = "Galaxy Z", Count = 25, Memory = 512 });


Console.WriteLine(mi9T);
Console.WriteLine(galaxyZ);