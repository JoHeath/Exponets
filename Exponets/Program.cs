//intro statement

Console.WriteLine("Welcome to the powers table app.");

//loops program

bool runProgram = true;
while (runProgram)
{
    //declares variable

    int input = 0;

    //loop for valid input

    while (true)
    {
        Console.WriteLine("Please enter an integer.");
        input = int.Parse(Console.ReadLine());
        if (input <= 0)
        {
            Console.WriteLine("Please try again");
        }
        else if (input >= 1290)
        {
            Console.WriteLine("Too high. Please try again.");
        }

        else
        {
            break;
        }
    }

    Console.WriteLine(string.Format("{0,10} | {1,10} | {2,10}", "input", "Squared", "Cubed"));
    
    //loop to end at user input

    for (int i = 1; i <= input; i++)
        {
        
        Console.WriteLine(string.Format("{0,10} | {1,10} | {2,10}",$"{i}",$"{NumberSquared(i)}",$"{NumberCubed(i)}"));
        }
    
    //asks if user wants to continue

        Console.WriteLine("Would you like to continue? y/n");
        string response = Console.ReadLine().ToLower().Trim();

        if (response == "y")
        {
            runProgram = true;
        }
        else
        {
            Console.WriteLine("Thank you for using the powers table app");
            break;
        }
    

    
}
//methods
static int NumberSquared(int input)
{
    return input * input;

}
static int NumberCubed(int input)
{
    return input * input * input;
}