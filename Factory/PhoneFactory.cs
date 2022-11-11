using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Example
{
    internal class PhoneFactory
    {
        public IPhone FactoryMethod(string Phone,string Model, int Count, int Memory)
        {
            // Klassik uslubda yazsaq asagida gelen phone parametri nedirse if-else 
            // Ve ya switch case condition bloklari vasitesile yoxlayib o halda yaza bilerik

            // Asagidaki yazilis axtardigimiz tipin hansi tip oldugunu Reflection kitabxanasini vasitesile verir

            Type type = Assembly.GetExecutingAssembly().GetTypes().FirstOrDefault(t => t.Name == Phone.ToString());
            IPhone phone = (IPhone)Activator.CreateInstance(type,Model,Count,Memory);

            return phone;
        }

    }
}
