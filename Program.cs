// See https://aka.ms/new-console-template for more information
using lab1.Models;

Book dune = new Book("Dune", "Frank Herbert", 528);
Book cuckoo = new Book("The Cuckoo's Egg", "Cliff Stoll", 395) { CurrentPage = 395 };

Console.WriteLine(dune);
dune.NextPage();
Console.WriteLine(dune);
dune.PrevPage();
Console.WriteLine(dune);
dune.PrevPage();

cuckoo.NextPage();
Console.WriteLine(cuckoo);