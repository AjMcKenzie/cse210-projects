using System;
using static System.Console;


class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture("John3:16","For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");

        scripture.showReference();
    }
}