// See https://aka.ms/new-console-template for more information

// Option 1
Console.Write("Please enter the first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

// Option 2: Prompt, store, convert
int num2 = 0;
Console.Write("Please enter the second number: ");
string numberEntered = Console.ReadLine();
num2 = Convert.ToInt32(numberEntered);

/*
Math Operations
*/

// Addition
int sum = num1 + num2;
// Multiplication
int product = num1 * num2;
// Division
int quotient = num1 / num2;
// Subtraction (negatives are taken care of)
int difference = num1 - num2;
// Modulus (returns remainder of operation)
int mod = num1 % num2;

Console.WriteLine("************** Math Results **************");
Console.WriteLine($"Sum: {sum}");
Console.WriteLine($"Difference: {difference}");
Console.WriteLine($"Product: {product}");
Console.WriteLine($"Quotient: {quotient}");
Console.WriteLine($"Modulus: {mod}");
Console.WriteLine("************** End Math Results **************");

/*
Logic Operations
*/

var isGreaterThan = num1 > num2;
bool isLessthan = num1 < num2;
bool isEqualto = num1 == num2;
bool isGreaterThanOrEqualTo = num1 >= num2;
bool isLessThanOrEqualTo = num1 <= num2;
bool isNotEqual = num1 != num2;

Console.WriteLine("************** Logic Results **************");
Console.WriteLine($"Is greater than: {isGreaterThan}");
Console.WriteLine($"Is less than: {isLessthan}");
Console.WriteLine($"Is equal to: {isEqualto}");
Console.WriteLine($"Is greater than or equal to: {isGreaterThanOrEqualTo}");
Console.WriteLine($"Is less than or equal to: {isLessThanOrEqualTo}");
Console.WriteLine($"Is not equal to: {isNotEqual}");
Console.WriteLine("************** End Logic Results **************");

/* Assignment Operator */

int num1 = 1;
string name = "Wang";

//Can be used to reduce lines of codes for calculations
num3 = num3 + 2; 
num4 +=2;

/*

+= or /= or *= or -=

*/


//Accumulator or increase by
//int randomValue = 5;
//int increaseValue = num1 + 5;
//num1 - num1 +5;
num1 =+ 5;
num1 -= 3;
num1 /=2;
num1 %= 2;
num1 *= 10;

Console.WriteLine("************** Assignment Results **************");
Console.WriteLine($"What is num1?: {num1}");
Console.WriteLine("************** Assignment Results **************");
//To show the vallue of num1 at each operation you will need to place console.WriteLine immediately after the operation