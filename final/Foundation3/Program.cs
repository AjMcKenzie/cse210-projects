using System;
using static System.Console;

class Program
{
    static void Main(string[] args){

        Address lectureAddress = new Address("34 Vesijärvenkatu", "Lahti", "Päijänne Tavastia", "Finland");
        Lectures lecture = new Lectures("Test", "This is a test of the code", "July 12, 2023", 18.35, lectureAddress, "lecture", "Tom Cod", 50);

        lecture.StandardDetails();
    }
}