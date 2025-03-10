
// REMEMBER TO REMOVE EACH QUESTION FROM COMMENTS AND RUN EACH QUESTION SEPERATELY.  WE HAVE FIVE QUESTIONS WITH ABOUT FOUR QUESTION EACH!!!



using System;

namespace Mora_Ejenavi_Assignment_Question_One
{
    class Program
    {
        static void Main(string[] args)
        {
            // Call each method for the questions
            Question1();
            Question2();
            Question3();
            Question4();
        }

        static void Question1()
        {
            Console.Write("Enter a number between 1 and 10: ");
            int number = int.Parse(Console.ReadLine());

            if (number >= 1 && number <= 10)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }

        static void Question2()
        {
            Console.Write("Enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine($"The maximum number is: {num1}");
            }
            else
            {
                Console.WriteLine($"The maximum number is: {num2}");
            }
        }

        static void Question3()
        {
            Console.Write("Enter the width of the image: ");
            int width = int.Parse(Console.ReadLine());
            Console.Write("Enter the height of the image: ");
            int height = int.Parse(Console.ReadLine());

            if (width > height)
            {
                Console.WriteLine("Landscape");
            }
            else
            {
                Console.WriteLine("Portrait");
            }
        }

        static void Question4()
        {
            Console.Write("Enter the speed limit: ");
            int speedLimit = int.Parse(Console.ReadLine());
            Console.Write("Enter the car speed: ");
            int carSpeed = int.Parse(Console.ReadLine());

            if (carSpeed <= speedLimit)
            {
                Console.WriteLine("Ok");
            }
            else
            {
                int demeritPoints = (carSpeed - speedLimit) / 5;
                if (demeritPoints > 12)
                {
                    Console.WriteLine("License Suspended");
                }
                else
                {
                    Console.WriteLine($"Demerit points: {demeritPoints}");
                }
            }
        }
    }
}









//// QuestionTwoAssignment

//using System;

//class Program
//{
//    static void Main()
//    {
//        //  menu for the user to choose which task to execute
//        Console.WriteLine("Choose an exercise:");
//        Console.WriteLine("1. Count how many numbers divisible by 3 between 1 and 100");
//        Console.WriteLine("2. Sum of all entered numbers (type 'ok' to exit)");
//        Console.WriteLine("3. Calculate the factorial of a number");
//        Console.WriteLine("4. Play the random number guessing game");
//        Console.WriteLine("5. Find the largest number in a list");
//        Console.WriteLine("6. Exit");
//        Console.Write("Your choice (1-6): ");

//        int choice = int.Parse(Console.ReadLine());  // Get user's input for the task choice

//        // Execute the selected task
//        switch (choice)
//        {
//            case 1:
//                CountNumbersDivisibleBy3();
//                break;
//            case 2:
//                CalculateTotalSum();
//                break;
//            case 3:
//                FindFactorial();
//                break;
//            case 4:
//                GuessTheNumber();
//                break;
//            case 5:
//                FindMaxFromList();
//                break;
//            case 6:
//                Console.WriteLine(" Goodbye!");
//                break;
//            default:
//                Console.WriteLine("Invalid option. Please choose a number between 1 and 6.");
//                break;
//        }
//    }

//    // QuestionOne Count how many numbers between 1 and 100 are divisible by 3
//    static void CountNumbersDivisibleBy3()
//    {
//        int count = 0;
//        for (int i = 1; i <= 100; i++)
//        {
//            if (i % 3 == 0)  // Check if number is divisible by 3
//            {
//                count++;
//            }
//        }
//        Console.WriteLine($"There are {count} numbers between 1 and 100 divisible by 3.");
//    }

//    //  QuestionTwo: Continuously ask the user for numbers and calculate the sum
//    static void CalculateTotalSum()
//    {
//        int totalSum = 0;
//        string userInput;

//        while (true)
//        {
//            Console.Write("Enter a number to add to the sum (or type 'ok' to finish): ");
//            userInput = Console.ReadLine();

//            if (userInput.ToLower() == "ok")  // Exit condition
//            {
//                break;
//            }

//            totalSum += int.Parse(userInput);  // Add the number entered by the user
//        }

//        Console.WriteLine($"The total sum of the numbers is: {totalSum}");
//    }

//    //  QuestionThree: Calculate the factorial of a given number
//    static void FindFactorial()
//    {
//        Console.Write("Enter a number to calculate its factorial: ");
//        int number = int.Parse(Console.ReadLine());

//        long factorial = 1;

//        for (int i = 1; i <= number; i++)
//        {
//            factorial *= i;  // Multiply the number iteratively
//        }

//        Console.WriteLine($"The factorial of {number} is: {factorial}");
//    }

//    //  QuestionFour: Random number guessing game (4 chances)
//    static void GuessTheNumber()
//    {
//        Random random = new Random();
//        int secretNumber = random.Next(1, 11);  // Random number between 1 and 10

//        // Optionally show the secret number for debugging purposes
//        Console.WriteLine($"(Debug Info) The secret number is: {secretNumber}");

//        bool hasGuessedCorrectly = false;
//        int attempts = 0;

//        while (attempts < 4 && !hasGuessedCorrectly)
//        {
//            Console.Write("Guess the number (between 1 and 10): ");
//            int guess = int.Parse(Console.ReadLine());

//            if (guess == secretNumber)
//            {
//                hasGuessedCorrectly = true;
//                Console.WriteLine("Congratulations! You guessed the number!");
//            }
//            else
//            {
//                attempts++;
//                Console.WriteLine($"Attempt {attempts}/4. Try again!");
//            }
//        }

//        if (!hasGuessedCorrectly)
//        {
//            Console.WriteLine($"Sorry, you lost. The correct number was {secretNumber}.");
//        }
//    }

//    // QuestionFive: Find the largest number in a comma-separated list
//    static void FindMaxFromList()
//    {
//        Console.Write("Enter a list of numbers separated by commas: ");
//        string input = Console.ReadLine();

//        string[] numbers = input.Split(',');
//        int[] parsedNumbers = Array.ConvertAll(numbers, int.Parse);  // Convert the strings to integers

//        int maxNumber = parsedNumbers[0];  // Assume the first number is the largest

//        foreach (int num in parsedNumbers)
//        {
//            if (num > maxNumber)
//            {
//                maxNumber = num;  // Update the largest number
//            }
//        }

//        Console.WriteLine($"The largest number in the list is: {maxNumber}");
//    }
//}









//QuestionNumberThree

//using System;


//class Program
//{
//    static void Main()
//    {
//        while (true)
//        {
//            // Show the menu for the user to choose which task to execute
//            Console.Clear();
//            Console.WriteLine("Choose an exercise:");
//            Console.WriteLine("1. Question One: Likes on Facebook");
//            Console.WriteLine("2. Question Two: Reverse Name");
//            Console.WriteLine("3. Question Three: Unique Numbers");
//            Console.WriteLine("4. Question Four: Unique Numbers List");
//            Console.WriteLine("5. Question Five: Three Smallest Numbers");
//            Console.WriteLine("6. Exit");
//            Console.Write("Your choice (1-6): ");

//            int choice = int.Parse(Console.ReadLine());

//            // Execute the selected task
//            switch (choice)
//            {
//                case 1:
//                    QuestionOne();
//                    break;
//                case 2:
//                    QuestionTwo();
//                    break;
//                case 3:
//                    QuestionThree();
//                    break;
//                case 4:
//                    QuestionFour();
//                    break;
//                case 5:
//                    QuestionFive();
//                    break;
//                case 6:
//                    return;  // Exit the program
//                default:
//                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 6.");
//                    break;
//            }

//            // Ask if the user wants to try another task
//            Console.WriteLine("\nPress Enter to return to the main menu or 'Esc' to exit.");
//            if (Console.ReadKey().Key == ConsoleKey.Escape)
//            {
//                break;
//            }
//        }
//    }

//    // Question One: Likes on Facebook
//    static void QuestionOne()
//    {
//        Console.WriteLine("Enter names of friends who liked your post (press Enter to stop):");
//        string name;
//        var friends = new System.Collections.Generic.List<string>();

//        while (true)
//        {
//            name = Console.ReadLine();
//            if (string.IsNullOrEmpty(name)) break;
//            friends.Add(name);
//        }

//        int count = friends.Count;

//        if (count == 0)
//        {
//            // No one liked the post, do nothing
//        }
//        else if (count == 1)
//        {
//            Console.WriteLine($"{friends[0]} likes your post.");
//        }
//        else if (count == 2)
//        {
//            Console.WriteLine($"{friends[0]} and {friends[1]} like your post.");
//        }
//        else
//        {
//            Console.WriteLine($"{friends[0]}, {friends[1]} and {count - 2} others like your post.");
//        }
//    }

//    // Question Two: Reverse Name
//    static void QuestionTwo()
//    {
//        Console.Write("Enter your name: ");
//        string name = Console.ReadLine();

//        // Reverse the name manually
//        char[] nameArray = name.ToCharArray();
//        Array.Reverse(nameArray);
//        string reversedName = new string(nameArray);

//        Console.WriteLine($"Reversed name: {reversedName}");
//    }

//    // Question Three: Unique Numbers
//    static void QuestionThree()
//    {
//        int[] numbers = new int[5];
//        int index = 0;

//        while (index < 5)
//        {
//            Console.Write("Enter a unique number: ");
//            int num = int.Parse(Console.ReadLine());

//            if (Array.Exists(numbers, element => element == num))
//            {
//                Console.WriteLine("Error: Number already entered. Please enter a unique number.");
//            }
//            else
//            {
//                numbers[index] = num;
//                index++;
//            }
//        }

//        Array.Sort(numbers);
//        Console.WriteLine($"Sorted numbers: {string.Join(", ", numbers)}");
//    }

//    // Question Four: Unique Numbers List
//    static void QuestionFour()
//    {
//        var numbers = new System.Collections.Generic.List<int>();
//        string input;

//        while (true)
//        {
//            Console.Write("Enter a number (or type 'Quit' to exit): ");
//            input = Console.ReadLine();

//            if (input.ToLower() == "quit")
//            {
//                break;
//            }

//            int num = int.Parse(input);
//            if (!numbers.Contains(num))
//            {
//                numbers.Add(num);
//            }
//        }

//        Console.WriteLine($"Unique numbers entered: {string.Join(", ", numbers)}");
//    }

//    // Question Five: Three Smallest Numbers
//    static void QuestionFive()
//    {
//        Console.Write("Enter a list of comma-separated numbers (e.g., 5, 1, 9, 2, 10): ");
//        string input = Console.ReadLine();

//        string[] inputArray = input.Split(',');
//        int[] numbers = new int[inputArray.Length];

//        for (int i = 0; i < inputArray.Length; i++)
//        {
//            numbers[i] = int.Parse(inputArray[i].Trim());
//        }

//        if (numbers.Length < 5)
//        {
//            Console.WriteLine("Invalid List. Please ensure there are at least 5 numbers.");
//        }
//        else
//        {
//            Array.Sort(numbers);
//            Console.WriteLine($"The 3 smallest numbers are: {numbers[0]}, {numbers[1]}, {numbers[2]}");
//        }
//    }
//}









////QuestionFour

//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        while (true)
//        {
//            Console.WriteLine("\nChoose an option:");
//            Console.WriteLine("1. Check consecutive numbers");
//            Console.WriteLine("2. Check for duplicates");
//            Console.WriteLine("3. Validate time");
//            Console.WriteLine("4. Create variable name");
//            Console.WriteLine("5. Count vowels");
//            Console.WriteLine("6. Exit");

//            string choice = Console.ReadLine();

//            switch (choice)
//            {
//                case "1":
//                    CheckConsecutiveNumbers();
//                    break;
//                case "2":
//                    CheckDuplicates();
//                    break;
//                case "3":
//                    ValidateTime();
//                    break;
//                case "4":
//                    CreateVariableName();
//                    break;
//                case "5":
//                    CountVowels();
//                    break;
//                case "6":
//                    Console.WriteLine("Exiting the program.");
//                    return;
//                default:
//                    Console.WriteLine("Invalid choice. Please select a number between 1 and 6.");
//                    break;
//            }
//        }
//    }

//    static void CheckConsecutiveNumbers()
//    {
//        Console.Write("Enter numbers separated by a hyphen: ");
//        string input = Console.ReadLine();
//        if (string.IsNullOrEmpty(input)) return;

//        string[] parts = input.Split('-');
//        int[] numbers = Array.ConvertAll(parts, int.Parse);
//        Array.Sort(numbers);

//        bool isConsecutive = true;
//        for (int i = 1; i < numbers.Length; i++)
//        {
//            if (numbers[i] != numbers[i - 1] + 1)
//            {
//                isConsecutive = false;
//                break;
//            }
//        }

//        Console.WriteLine(isConsecutive ? "Consecutive" : "Not Consecutive");
//    }

//    static void CheckDuplicates()
//    {
//        Console.Write("Enter numbers separated by a hyphen: ");
//        string input = Console.ReadLine();
//        if (string.IsNullOrEmpty(input)) return;

//        string[] parts = input.Split('-');
//        for (int i = 0; i < parts.Length; i++)
//        {
//            for (int j = i + 1; j < parts.Length; j++)
//            {
//                if (parts[i] == parts[j])
//                {
//                    Console.WriteLine("Duplicate");
//                    return;
//                }
//            }
//        }
//        Console.WriteLine("No duplicates");
//    }

//    static void ValidateTime()
//    {
//        Console.Write("Enter time in 24-hour format (e.g. 19:00): ");
//        string input = Console.ReadLine();
//        if (string.IsNullOrEmpty(input))
//        {
//            Console.WriteLine("Invalid Time");
//            return;
//        }

//        string[] parts = input.Split(':');
//        if (parts.Length != 2 || !int.TryParse(parts[0], out int hours) || !int.TryParse(parts[1], out int minutes))
//        {
//            Console.WriteLine("Invalid Time");
//            return;
//        }

//        if (hours >= 0 && hours < 24 && minutes >= 0 && minutes < 60)
//        {
//            Console.WriteLine("Ok");
//        }
//        else
//        {
//            Console.WriteLine("Invalid Time");
//        }
//    }

//    static void CreateVariableName()
//    {
//        Console.Write("Enter words separated by a space: ");
//        string input = Console.ReadLine();
//        if (string.IsNullOrEmpty(input)) return;

//        string[] words = input.Split(' ');
//        string variableName = "";
//        foreach (string word in words)
//        {
//            variableName += char.ToUpper(word[0]) + word.Substring(1).ToLower();
//        }

//        Console.WriteLine(variableName);
//    }

//    static void CountVowels()
//    {
//        Console.Write("Enter an English word: ");
//        string input = Console.ReadLine();
//        if (string.IsNullOrEmpty(input)) return;

//        int count = 0;
//        foreach (char c in input)
//        {
//            if ("aeiouAEIOU".IndexOf(c) >= 0)
//            {
//                count++;
//            }
//        }

//        Console.WriteLine(count);
//    }
//}







////QuestionFive

//using System; // Importing the System namespace for basic functionalities
//using System.IO; // Importing the System.IO namespace for file handling

//class Program
//{
//    static void Main(string[] args)
//    {
//        // Infinite loop to keep the program running until the user decides to exit
//        while (true)
//        {
//            // Displaying the menu options to the user
//            Console.WriteLine("\nChoose an option:");
//            Console.WriteLine("1. Count the number of words in a text file");
//            Console.WriteLine("2. Find the longest word in a text file");
//            Console.WriteLine("3. Exit");

//            // Reading the user's choice
//            string choice = Console.ReadLine();

//            // Switch statement to handle the user's choice
//            switch (choice)
//            {
//                case "1":
//                    CountWords(); // Call the method to count words
//                    break;
//                case "2":
//                    FindLongestWord(); // Call the method to find the longest word
//                    break;
//                case "3":
//                    Console.WriteLine("Exiting the program."); // Inform the user about exiting
//                    return; // Exit the program
//                default:
//                    // Handle invalid input
//                    Console.WriteLine("Invalid choice. Please select a number between 1 and 3.");
//                    break;
//            }
//        }
//    }

//    // Method to count the number of words in a text file
//    static void CountWords()
//    {
//        Console.Write("Enter the path of the text file: "); // Prompt for file path
//        string filePath = Console.ReadLine(); // Read the file path from user input

//        try
//        {
//            // Read all text from the specified file
//            string text = File.ReadAllText(filePath);
//            // Split the text into words based on whitespace characters
//            string[] words = text.Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);
//            // Display the number of words found
//            Console.WriteLine($"Number of words: {words.Length}");
//        }
//        catch (Exception ex)
//        {
//            // Handle any errors that occur during file reading
//            Console.WriteLine($"Error reading file: {ex.Message}");
//        }
//    }

//    // Method to find the longest word in a text file
//    static void FindLongestWord()
//    {
//        Console.Write("Enter the path of the text file: "); // Prompt for file path
//        string filePath = Console.ReadLine(); // Read the file path from user input

//        try
//        {
//            // Read all text from the specified file
//            string text = File.ReadAllText(filePath);
//            // Split the text into words based on whitespace characters
//            string[] words = text.Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);

//            string longestWord = ""; // Initialize a variable to hold the longest word
//            // Loop through each word to find the longest one
//            foreach (string word in words)
//            {
//                // Check if the current word is longer than the longest found so far
//                if (word.Length > longestWord.Length)
//                {
//                    longestWord = word; // Update the longest word
//                }
//            }

//            // Display the longest word found
//            Console.WriteLine($"Longest word: {longestWord}");
//        }
//        catch (Exception ex)
//        {
//            // Handle any errors that occur during file reading
//            Console.WriteLine($"Error reading file: {ex.Message}");
//        }
//    }
//}