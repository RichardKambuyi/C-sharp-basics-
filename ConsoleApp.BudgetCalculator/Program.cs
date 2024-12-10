// See https://aka.ms/new-console-template for more information

        // Welcome message
        Console.WriteLine("Welcome to the Budget Manager!");

        // Input: User's monthly income
        Console.Write("Enter your monthly income: $");
        double income = Convert.ToDouble(Console.ReadLine());

        // Input: Monthly expenses
        Console.Write("Enter your rent expense: $");
        double rent = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter your utility expense: $");
        double utilities = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter your food expense: $");
        double food = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter your entertainment expense: $");
        double entertainment = Convert.ToDouble(Console.ReadLine());

        // Arithmetic operations: Calculate total expenses
        double totalExpenses = rent + utilities + food + entertainment;
        Console.WriteLine($"\nYour total expenses are: ${totalExpenses}");

        // Logical operations: Check if the user is over budget
        bool isOverBudget = totalExpenses > income;
        bool isWithinBudget = totalExpenses <= income;

        Console.WriteLine($"\nAre you over budget? {isOverBudget}");
        Console.WriteLine($"Are you within budget? {isWithinBudget}");

        // Suggestion based on budget comparison
        if (isOverBudget)
        {
            Console.WriteLine("You are spending more than your income. Consider cutting down on unnecessary expenses.");
        }
        else if (totalExpenses == income)
        {
            Console.WriteLine("You are breaking even. Try to save some money for emergencies.");
        }
        else
        {
            Console.WriteLine("Great job! You are within your budget. Keep saving money for the future.");
        }

        // Assignment operations: Adjust the budget for savings
        Console.Write("\nHow much do you want to save this month? $");
        double savings = Convert.ToDouble(Console.ReadLine());
        income -= savings; // Deduct savings from income

        Console.WriteLine($"After saving ${savings}, your remaining income is: ${income}");

        // End message
        Console.WriteLine("\nThank you for using the Budget Manager!");
    