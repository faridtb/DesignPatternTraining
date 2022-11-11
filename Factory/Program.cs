using Factory;
using Factory.Example;




PhoneFactory factory = new(); // statik olmadigina gore new ladiq 

IPhone newSamsung = factory.FactoryMethod("Samsung","Galaxy Z",33,256);
IPhone newXiaomi = factory.FactoryMethod("Xiaomi","MI 9 T Pro",50,512);


Console.WriteLine(newSamsung.ToString()); 
Console.WriteLine(newXiaomi.ToString()); 


Console.Read();