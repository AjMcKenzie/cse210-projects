// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using static System.Console;


Book mistborn = new Book("Mistborn", "Brandon Sanderson");
Book readyPO = new Book("Ready Player One", "Ernest Cline");

mistborn.Display();
readyPO.Display();

WriteLine(mistborn.IsAvailable());


