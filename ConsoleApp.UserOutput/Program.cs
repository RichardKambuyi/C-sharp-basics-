// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// See https://aka.ms/new-console-template for more information

// Different datatypes 

/*
     text - string
     integers - int
     decimal - double, float, decimal
     logical
*/

string name = "Trevoir Williams";

Console.WriteLine(name);
Console.WriteLine("I am " + name); //string concatenation
Console.WriteLine($"They call me {name}"); //string interpolation
Console.WriteLine("I was given the {0}", name); //Forwmatted string. Computers begin counting at Zero (0)

int age = 54;
int retirementYearsLeft = 11;
int retirementAge = age + retirementYearsLeft;

Console.WriteLine("My age is: " + age);
Console.WriteLine("My retirement age is: " + retirementAge);

bool isRetired = false;
Console.WriteLine("Am I retired? " + isRetired);

