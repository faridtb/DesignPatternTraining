using AbstractFactory.Example.Dtos;
using AbstractFactory.Example.Factories.Interfaces;
using AbstractFactory.Example.Models.Concretes;
using AbstractFactory.Example.Models.Interfaces;

namespace AbstractFactory.Example.Factories.Concretes
{
    internal class XiaomiFactory : IPhoneFactory
    {
        public IPhone GetPhone(PhoneCreateDto infos)
        {
            return new Xiaomi(infos.Model, infos.Count, infos.Memory);
        }
    }
}
