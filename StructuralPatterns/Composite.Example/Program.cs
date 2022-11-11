

#region Without Pattern
// Open close prinsipini pozaraq kod inshasi
using Composite.Example;
using Composite.Example.Composite_Pattern_Style.Concretes;

#region Terevezler & Terevez Paketi
//Product2 tomato = new("pomidor", 15);
//Product2 onion = new("sogan", 8);
//Product2 aubergine = new("badimcan", 6);
//Product2 pepper = new("biber", 10);


//Package2 vegetablePackage = new("Terevez Paket");
//vegetablePackage.Products.Add(tomato);
//vegetablePackage.Products.Add(aubergine);
//vegetablePackage.Products.Add(onion);
//vegetablePackage.Products.Add(pepper);
#endregion

#region Texnologiya & Paketi

//Product2 laptop = new("Asus", 1800);
//Product2 speaker = new("JBL", 880);
//Product2 processor = new("Nvidia RTX", 1000);

//Package2 technology = new("Texnoloji Paket");
//technology.Products.Add(laptop);
//technology.Products.Add(speaker);
//technology.Products.Add(processor);
#endregion

#region Sadeler
//Product ball = new("Ball", 75);
#endregion


//Basket2 basket = new("Farids Basket");
//basket.Packages.Add(vegetablePackage);
//basket.Packages.Add(technology);
//basket.Products.Add(ball);

//basket.GetDetailedPrice();

#endregion

#region With Pattern

Product tomato = new("pomidor", 15);
Product onion = new("sogan", 8);
Product aubergine = new("badimcan", 6);
Product pepper = new("biber", 10);
Product laptop = new("Asus", 1800);
Product speaker = new("JBL", 880);
Product processor = new("Nvidia RTX", 1000);
Product ball = new("Ball", 75);


Package vegetablePackage = new("Terevez Paket");
vegetablePackage.Products.Add(tomato);
vegetablePackage.Products.Add(aubergine);
vegetablePackage.Products.Add(onion);
vegetablePackage.Products.Add(pepper);


Package technology = new("Texnoloji Paket");
technology.Products.Add(laptop);
technology.Products.Add(speaker);
technology.Products.Add(processor);

Basket basket = new("Farids Basket");
basket.Priceables.Add(technology);
basket.Priceables.Add(vegetablePackage);
basket.Priceables.Add(ball);

MegaPackage mega = new("Ramazan Mega Paketi"); // Terkibinde birden cox paket ve birden cox mehsul ola biler
mega.Packages.Add(technology);
mega.Packages.Add(vegetablePackage);

basket.Priceables.Add(mega);

Console.WriteLine(basket.GetTotalResult());


#endregion


