using System;
using static System.Console;

class Program
{
    static void Main(string[] args){

        Address lectureAddress = new Address("Hennalankatu 308", "Lahti", "", "Finland");
        Lecture lecture = new Lecture("Englanninkielisiä Oppitunteja", "Teaching English for those who want to learn.", "July 12, 2023", 18, lectureAddress, "Lecture", "Vanhimmat McKenzie ja Hal", 20);

        lecture.StandardDetails();
        WriteLine("");
        lecture.ShortDetails();
        WriteLine("");
        lecture.FullDetails();
        WriteLine("");

        WriteLine("==========================================================================");
        
        Address receptionAddress = new Address("42929 Castle Cove Cir", "Maricopa", "AZ", "USA");
        Reception reception = new Reception("John & Sarah", "John and Sarah are getting married.", "August 2, 2023", 16.30, receptionAddress, "Reception", "john.sarah4ever@gmail.com");

        reception.StandardDetails();
        WriteLine("");
        reception.ShortDetails();
        WriteLine("");
        reception.FullDetails();
        WriteLine("");
        
        WriteLine("==========================================================================");
        
        Address outdoorAddress = new Address("Kongsgårdsgata 2", "Trondheim", "", "Norway");
        OutdoorGathering outdoor = new OutdoorGathering("Cleaning up Nidarosdomen", "Picking up trash on and around Nidarosdomen's grounds.", "July 15, 2023", 15, outdoorAddress, "Outdoor Gathering", "Clear");

        outdoor.StandardDetails();
        WriteLine("");
        outdoor.ShortDetails();
        WriteLine("");
        outdoor.FullDetails();
        WriteLine("");


    }
}