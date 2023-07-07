using System;
using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        //order 1 
        WriteLine("================================================================");
        Address address1 = new Address ("325 Bruce Ct.", "Hartwell", "GA", "USA");
        Customer customer1 = new Customer("Aaron Aa. Aaronson", address1);

        double order1ShippingCost = customer1.GetShippingCost();

        Product order1Product1 = new Product("Cosmic Crisp Apple", "3507", 0.25, 5);
        Product order1Product2 = new Product("Heinz Salad Cream", "4250", 10.24, 1);
        Product order1Product3 = new Product("Wooden Pencil (8 pack)", "3268", .50, 1);

        Order order1 = new Order(customer1);
        order1.AddProduct(order1Product1);
        order1.AddProduct(order1Product2);
        order1.AddProduct(order1Product3);
        double order1Subtotal = order1.CalculateSubtotal();
        double order1Total = order1.CalculateTotal();

        //display order 1
        order1.DisplayShippingLabel(); 
        WriteLine();
        order1.DisplayPackingLabel();
        WriteLine();
        order1.DisplayCosts(order1Subtotal, order1ShippingCost, order1Total);

        WriteLine("================================================================");


        //order 2
        Address address2 = new Address ("34 Vesijärvenkatu", "Lahti", "Päijänne Tavastia", "Finland");
        Customer customer2 = new Customer("Vanhimmat McKenzie ja Hal", address2);

        double order2ShippingCost = customer2.GetShippingCost();

        Product order2Product1 = new Product("Tuna", "4201", 1.00, 20);
        Product order2Product2 = new Product("Past noodles", "8474", 2.00, 4);
        Product order2Product3 = new Product("Crepe mix", "6969", 4.00, 10);

        Order order2 = new Order(customer2);
        order2.AddProduct(order2Product1);
        order2.AddProduct(order2Product2);
        order2.AddProduct(order2Product3);
        double order2Subtotal = order2.CalculateSubtotal();
        double order2Total = order2.CalculateTotal();


        //display order 2
        order2.DisplayShippingLabel(); 
        Console.WriteLine();
        order2.DisplayPackingLabel();
        Console.WriteLine();
        order2.DisplayCosts(order2Subtotal, order2ShippingCost, order2Total);


        
    }
}