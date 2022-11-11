using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Example.Dtos;
using AbstractFactory.Example.Models.Concretes;

namespace AbstractFactory.Example.Factories.Interfaces
{
    internal interface IPhoneFactory
    {
        public IPhone GetPhone(PhoneCreateDto infos);
    }
}
