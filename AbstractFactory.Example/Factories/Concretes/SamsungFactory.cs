using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Example.Dtos;
using AbstractFactory.Example.Factories.Interfaces;
using AbstractFactory.Example.Models;
using AbstractFactory.Example.Models.Concretes;
using AbstractFactory.Example.Models.Interfaces;

namespace AbstractFactory.Example.Factories.Concretes
{
    internal class SamsungFactory : IPhoneFactory
    {
        public IPhone GetPhone(PhoneCreateDto infos)
        {
            return new Samsung(infos.Model, infos.Count, infos.Memory);
        }
    }
}
