using static System.Console;

// New is calling a constructor
Player neymar = new Player("Neymar Jr", 10, "Forward");

Player kobe = new Player("Kobe Bryant", 24);

// neymar._name("Neymar Jr.");
// neymar._position("Forward");
// neymar._jerseyNumber = 10;

// Calling the method
kobe.SetPosition("Shooting Guard");

WriteLine(kobe.Display());
WriteLine();

Team awesomeSauce = new Team("Awesome Sauce");

awesomeSauce.AddPlayer(kobe);
awesomeSauce.AddPlayer(neymar);

awesomeSauce.DisplayRoster();

// Variable = if ? T:F;