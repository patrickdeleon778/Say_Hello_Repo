bool playAgain = true;
bool validResponse = true;
string? userAnswer;


    while(playAgain == true)
    {   
        Console.Write("What is your name: "); // console asks user what their name is

        string? userInput = Console.ReadLine(); // created a variable that grabs the users name

        Console.WriteLine($"Hello {userInput}."); // displays "Hello (name)." and the name the user inputs

        validResponse = true;

        while(validResponse == true)
        {
            Console.Write("Do you want to run the program again? (Y/N): "); // console asks if the user wants to run the program again

            userAnswer = Console.ReadLine().ToUpper();

            if(userAnswer == "Y")
            {
                playAgain = true;
                validResponse = false;
            }
            else if(userAnswer == "N")
            {
                playAgain = false;
                validResponse = false;
            }
            else
            {   
                playAgain = false;
                validResponse = true;
                Console.WriteLine(userAnswer + " isn't a valid response. Please Enter an actual valid response please.");
            }
        }
    }

        Console.WriteLine("Thanks for playing!");
    
// This is some random stuff lol