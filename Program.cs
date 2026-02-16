// Program Name:

// Created on:

// Author:

using System.ComponentModel.DataAnnotations;

using System.Runtime.InteropServices;



int rating;

string name;

string car;

string edbuycar;

string money;

Console.WriteLine("what is your name?");
name = Console.ReadLine();
Console.WriteLine("what is your favourite car");
car = Console.ReadLine();
Console.WriteLine("should ed buy you a car?");
edbuycar = Console.ReadLine();
Console.WriteLine("how much is ed going to spend on your car");
money = Console.ReadLine();



Console.WriteLine($"{name} wants a {car}, smiling as Ed is about to you a {car} " +

    $" . {name} cant believe Ed will spend {money} on a car for you. As the {car} is going to be realy cool, the {car} is going " +

    $" to need lots of work . {name} is happy because ed will pay for it.");

Thread.Sleep(100);

Console.WriteLine("rate this program a 10!");

rating = Console.Read();

if (rating > 9)
{
    Console.WriteLine("good boy!");
}
else
{
    Console.WriteLine("never message me again.");
}