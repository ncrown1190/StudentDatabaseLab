// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/* 01 Create 3 arrays and fill them with student information—one with name, one with hometown,
*  one with favorite food.*/
string[] studentsNames = new string[]
{
    "Joe", "Thomas Crooks", "Ellyse Chuo", "Abgil Hop", "Justin Jay", "Taj Nazima", "Andrew Black", "Jake", "Zack"
};

string[] studentsHomeTown = new string[]
{
    "Columbus", "Dearborn", "Bloomfield", "Traverse City", "Canton", "Ann Arbor", "Rochester Hills", "Birmingham", "Novi"
};


string[] studentsFavoriteFood = new string[]
{
    "Pizza", "Lasagna", "Noodles", "Burger", "Sushi", "Thai", "Spagheti", "Tacos", "Hot wings"
};


while (true)
{
    //Prompt the user to ask about a particular student by number.
    //Convert the input to an integer. Use the integer as the index for the arrays.
    //Print the student’s name.
    Console.Write($"Welcome! Which student would you like to learn more about? Enter a number from 1-{studentsNames.Length}: ");
    String userInput = "";
    int arrayIndex = -1;
    bool output = false;
    while (output == false)
    {
        userInput = Console.ReadLine();

        // Validating user number
        if (int.TryParse(userInput, out arrayIndex) == true)
        {
            if (arrayIndex >= 1 && arrayIndex <= studentsNames.Length)
            {
                output = true;
            }
            else
            {
                Console.WriteLine("Please enter a number in the range provided");
            }
        }
        else
        {
            Console.WriteLine("That is not a valid number, please try again later.");
        }
    }
    // Printing the name of student
    Console.WriteLine($"Student {userInput} is {studentsNames[arrayIndex - 1]}.");

    //Ask the user which category to display: Hometown or Favorite food.
    //Then display the relevant information.
    Console.Write($"What would you like to know? Enter \"hometown\" or \"favorite food\": ");

    //Console.WriteLine(output);

    // Validating category
    output = false;
    string userCategory = "";
    while (output == false)
    {
        userCategory = Console.ReadLine().ToLower().Trim();
        if (userCategory == "hometown" || userCategory == "home" || userCategory == "town" || userCategory == "favorite" || userCategory == "favorite food" || userCategory == "food")
        {
            output = true;
        }
        else
        {
            Console.WriteLine("That category does not exist.");
            Console.Write("Enter \\\"hometown\\\" or \\\"favorite food\\\": ");
        }
    }
    // Displaying the category.
    switch (userCategory)
    {
        case "hometown":
        case "home":
        case "town":
            Console.WriteLine($"{studentsNames[arrayIndex - 1]} is from {studentsHomeTown[arrayIndex - 1]}.");
            break;
        case "favorite food":
        case "favorite":
        case "food":
            Console.WriteLine($"{studentsNames[arrayIndex - 1]}'s favorite food is {studentsFavoriteFood[arrayIndex - 1]}.");
            break;
    }

    //Ask the user if they would like to learn about another student.
    Console.Write("Would you  to see a list of students? Enter \"y\" or \"n\": ");
    string userAnswer = Console.ReadLine().ToLower().Trim();

    // Showing the list of student and their number.
    if (userAnswer == "y")
    {
        //using ForEach Loop
        int studentCounter = 1;
        foreach (string student in studentsNames)
        {
            Console.WriteLine($"{studentCounter}: {student}");
            studentCounter++;
        }
        //Using For Loop
        //for (int i = 0; i < studentsNames.Length; i++)
        //{
        //    Console.WriteLine($"{i + 1}, {studentsNames[i]}");
        //}
    }

    // Allowing the user to search by student name
    Console.Write("Enter the student name you'd like to search for: ");

    string searchName = Console.ReadLine();

    int indexOfSearch = -1;

    for (int i = 0; i < studentsNames.Length; i++)
    {
        if (studentsNames[i].ToLower() == searchName.ToLower())
        {
            indexOfSearch = i;
            break;
        }
    }
    if (indexOfSearch > -1)
    {
        Console.WriteLine($"{searchName}'s student number is {indexOfSearch + 1}");
        //Console.WriteLine($"{searchName}'s student number is {indexOfSearch + 1}, his/her home town is {studentsHomeTown[arrayIndex - 1]}, and favorite food is {studentsFavoriteFood[arrayIndex - 1]}.");
    }
    else
    {
        Console.WriteLine($"There is no student by name {searchName}");
    }

    Console.Write("Would you like to learn about another student? Enter \"y\" or \"n\": ");
    userAnswer = Console.ReadLine().ToLower().Trim();

    if (userAnswer != "y")
    {
        Console.WriteLine("Goodbye!");
        break;
    }
}

//Console.WriteLine("Press any key to exit");
//Console.ReadKey();