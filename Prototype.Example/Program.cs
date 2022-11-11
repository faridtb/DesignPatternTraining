using Prototype.Example;

//Klassik

GeneralEntityService service = new();

MyFile newFile = service.CreateFile(1);
Console.WriteLine("First:"+newFile);

MyFile clonedFile = (MyFile)newFile.Clone();
clonedFile.Name = "Xirdavat";
clonedFile.Category.Name = "Haay";

Console.WriteLine("Cloned:"+ clonedFile);

Console.WriteLine("First:" + newFile);
