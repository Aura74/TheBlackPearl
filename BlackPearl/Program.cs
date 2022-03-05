using BlackPearl;

//var myPearl1 = new Pearl();
//var myPearl2 = new Pearl();

//Console.WriteLine(myPearl1);
//Console.WriteLine(myPearl2);

//var myPearlNecklesList = new PearlList(5);

Console.WriteLine("Factory skapa en slumpmässig pärla här");
Console.WriteLine(Pearl.Factory.CreateRandomPearl());

// Listan skaps
var myPearlNecklesList = PearlList.Factory.CreateRandomList(35);

// Sortera listan i diameter color shape
Console.WriteLine();
myPearlNecklesList.Sort();
Console.WriteLine("Listan över alla pärlor sorterad i diameter color shape (Halsbandet alltså)");
Console.WriteLine(myPearlNecklesList);

// Räkna hur många elemet det finns totalt
var totalElements = myPearlNecklesList.Count();
Console.WriteLine($"Totalt i halsbandet finns: {totalElements} element");

//Räkna hur många Saltvattenpärlor det finns det finns i halsbandet
var totalElementsSaltVatten = myPearlNecklesList.Count2();
Console.WriteLine();
Console.WriteLine($"Antal Saltvattenpärlor i halsbandet: {totalElementsSaltVatten}");

//Räkna hur många Sötvattenpärlor det finns i halsbandet
var totalElementsSötVatten = myPearlNecklesList.Count3();
Console.WriteLine();
Console.WriteLine($"Antal Sötvattenpärlor i halsbandet: {totalElementsSötVatten}");

// Hitta en pärla den första med......
var findPearl = new Pearl();
//findPearl.Color = "Vit";
findPearl.Diameter = 19;
//findPearl.Shape = "Droppformad";
Console.WriteLine();
Console.WriteLine($"Pärlan du söker efter finns på index: {myPearlNecklesList.IndexOf(findPearl)} i halsbandet");

// Det totala priset för hela halsbandet.
Console.WriteLine();
Console.WriteLine($"Totala priset för hela halsbandet: {myPearlNecklesList.totalPrice}");