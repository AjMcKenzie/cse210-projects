using static System.Console;

Dvd theWayOfKings = new Dvd("The way of Kings");
Book theHobbit = new Book("The Hobbit", "978-0-345-33968-3", 9780345339683);

theWayOfKings.CheckOut();
theWayOfKings.Display();
WriteLine("");
theHobbit.Display();