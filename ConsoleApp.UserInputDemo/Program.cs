//Variable Declaration and Types

string? firstName = string.Empty;
string lastName = string.Empty;
int age = 0;
int retirementAge = 65;
decimal salary = 0;
char gender =char.MinValue; //Char only one character 
bool working = true;  //True or false (only takes two values) without setting a defualt bool is false. Only true or false is accepeted

//Promt the user for input
Console.WriteLine("Please enter your first name:");
firstName = Console.ReadLine();

Console.WriteLine("Please enter your last name:");
lastName = Console.ReadLine();

Console.WriteLine("Please enter your age:");
age = Convert.ToInt32(Console.ReadLine);

Console.WriteLine("Please enter your salary:");
salary = Convert.ToDecimal(Console.ReadLine);//as is a decimal will be converted into integer

Console.WriteLine("Please enter your gender (M or F)");
gender = Convert.ToChar(Console.ReadLine);

Console.WriteLine("Are you working? (true or false)");
working = Convert.ToBoolean(Console.ReadLine);

//Process the data
int workingYearsRemaining = retirementAge - age;

//Output the data to the user
Console.WriteLine($"Full name: {firstName} {lastName}");
Console.WriteLine($"Age: {age}");
Console.WriteLine($"Your salary is: {salary}");
Console.WriteLine($"Your gender is: {gender}");
Console.WriteLine($"Your you working?: {workingYearsRemaining}");

/* Wromg syntax

1. Writing the syntax incorrectly 
2. Using a method incorrectly
3. Violating rules of the language i.e bypassing conversions
4. Misspelling i.e no semi colon, no inverted brackets. wrong spacebar usage etc */
