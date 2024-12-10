//Declare variables
string name = string.Empty;
int age = 0;
int retirementAge = 65;

//Promt the user input
Console.WriteLine("Please enter your name?");
name = Console.ReadLine();

Console.WriteLine("Please enter your age?");
age = Convert.ToInt32(Console.ReadLine());//Console.Readline reads as string and numbers must be manually converted into string

/* Long way of converting int to string

Console.WriteLine("Please enter your age?");
string = intialAgeValue = Console.ReadLine();
age = Convert.ToInt32(intialAgeValue);

*/

//Process the data
int workingYearsRemaining = retirementAge - age;

//Output results to the user
Console.WriteLine($"Full name: {name}");
Console.WriteLine($"Full name: {name}");
Console.WriteLine($"Working Years Remaining: {workingYearsRemaining}");
