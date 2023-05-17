using System;
using static System.Console;


Journal _journal = new Journal();
FileHandler _fileHandler = new FileHandler();

Menu _menu = new Menu(_journal, _fileHandler);
_menu.Display();
