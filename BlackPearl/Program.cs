using BlackPearl;

//var myPearl1 = new Pearl();
//var myPearl2 = new Pearl();

//Console.WriteLine(myPearl1);
//Console.WriteLine(myPearl2);

//var myPearlNecklesList = new PearlList(5);

// Här skapas en slumpmässig pärla
Console.WriteLine("Factory skapade en slumpmässig pärla här:");
Console.WriteLine(Pearl.Factory.CreateRandomPearl());

// Listan/Halsbandet skapas här:
var myPearlNecklesList = PearlList.Factory.CreateRandomList(35);

// Här sorteras listan/halsbandet först efter diameter sedan färg(color) och sist form(shape)
Console.WriteLine();
myPearlNecklesList.Sort();
Console.WriteLine("Alla pärlor sorterad efter diameter color shape (Halsbandet alltså)");
Console.WriteLine(myPearlNecklesList);

// Här räknas det ut hur många elemet det finns totalt i listan/halsbandet.
var totalElements = myPearlNecklesList.Count();
Console.WriteLine($"Totalt i halsbandet finns: {totalElements} element");

// Här räknas det ut hur många Saltvattenpärlor det finns totalt i listan/halsbandet.
var totalElementsSaltVatten = myPearlNecklesList.Count2();
Console.WriteLine();
Console.WriteLine($"Antal Saltvattenpärlor i halsbandet: {totalElementsSaltVatten}");

// Här räknas det ut hur många Sötvattenpärlor det finns totalt i listan/halsbandet.
var totalElementsSötVatten = myPearlNecklesList.Count3();
Console.WriteLine();
Console.WriteLine($"Antal Sötvattenpärlor i halsbandet: {totalElementsSötVatten}");

// Hitta den första pärla med...... ex en vit, en med en diameter på 19mm, en som är Droppformad
var findPearl = new Pearl();
findPearl.Color = "Vit";
//findPearl.Diameter = 19;
//findPearl.Shape = "Droppformad";
Console.WriteLine();
Console.WriteLine($"Pärlan du söker efter finns på index: {myPearlNecklesList.IndexOf(findPearl)} i halsbandet");

// Det totala priset för hela halsbandet.
Console.WriteLine();
Console.WriteLine($"Totala priset för hela halsbandet: {myPearlNecklesList.totalPrice} SEK");