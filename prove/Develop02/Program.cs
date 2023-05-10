using System;
using static System.Console;


Journal _journal = new Journal();

Menu _menu = new Menu(_journal);
_menu.Display();
