namespace CStephens_Homework2;
class CStephens_Homework2_Program
{
    static void Main(string[] args)
    {
        // define grade gpa points on a permanent basis
        const int A_Grade = 4;
        const int B_Grade = 3;
        const int C_Grade = 2;
        const int D_Grade = 1;
        const int F_Grade = 0;
        // Get user letter input
        Choose:
        Console.WriteLine("Choose your program. You may type any of the following:\nGrade\nCompareNumbers\nLeapYear\nCancel");
        string? programChoice = Console.ReadLine();
        switch (programChoice.ToLower()){ // allows user to start anywhere in the program they would like
            default:
            goto Choose; // force repeat of choice
            case "grade":
            goto Part1; // begin part 1
            case "comparenumbers":
            goto Part2; // begin part 2
            case "leapyear":
            goto Part3; // begin part 3
            case "cancel":
            Environment.Exit(1);
            break;
        }
        Part1:
        Console.WriteLine("Please input a letter grade:");
        string? gradeInput = Console.ReadLine(); // "?" annotation to remove possible null reference error
        string? gradeInputLower = null;
        if (gradeInput is not null) // if statement to remove null reference warning 
        {
          gradeInputLower = gradeInput.ToLower();
        }
        switch (gradeInputLower)
        {
            case "a": // if the letter entered is A, B, C, D, F then return the GPA number to console.
            Console.WriteLine($"The GPA is: {A_Grade}.");
            break;
            case "b":
            Console.WriteLine($"The GPA is: {B_Grade}.");
            break; 
            case "c":
            Console.WriteLine($"The GPA is: {C_Grade}.");
            break;
            case "d":
            Console.WriteLine($"The GPA is: {D_Grade}.");
            break;
            case "f": 
            Console.WriteLine($"The GPA is: {F_Grade}.");
            break;
            default: // input error handling. if an invalid entry is provided, break from switch statemnet.
            Console.WriteLine($"Wrong letter grade! Try again.");
            goto Part1;
        }
        // Part 2 code begins
        Part2:
    Console.WriteLine("Please input the first number:");
    var num1 = Convert.ToInt16(Console.ReadLine());
    Console.WriteLine("Please input the second number:");
    var num2 = Convert.ToInt16(Console.ReadLine());
    Console.WriteLine("Please input the third number:");
    var num3 = Convert.ToInt16(Console.ReadLine());
    bool evaluateNumbers = num1<num2;
    switch(evaluateNumbers){
        case true:
        //Number 1 is less than Number 2.
        if (num2<num3){
            //1 is less than 2 and 3 and is the smallest number.
            Console.WriteLine($"The smallest value is {num1}");
            return;
        }
        else {
            //1 is less than 2, which is greater than 3.
            if (num1<num3){
                //1 is less than 2 and 3 and is the smallest number.
                Console.WriteLine($"The smallest value is {num1}");
            }
            else{
                //1 is less than 2 and greater than 3. 3 is the smallest number
                Console.WriteLine($"The smallest value is {num3}");
            }
            break;
        }
        case false:
            //Number 1 is greater than Number 2
            if (num2<num3){
            //2 is less than 1 and 3. 2 is the smallest number
            Console.WriteLine($"The smallest value is {num2}");
            break;
            }
            else {
            //3 is smaller than 2, which is smaller than 1.
            Console.WriteLine($"The smallest value is {num3}");
            }
            break;
    }
    // Part 3 code begins
    Part3:
    Console.WriteLine("Please input a year:");
    int yearInput = Convert.ToInt16(Console.ReadLine());
    // getting variable values to make it easier to calculate
    int yearInput4 = yearInput%4;
    int yearInput100 = yearInput%100;
    int yearInput400 = yearInput%400;
    int yearInputResult = yearInput4+yearInput100+yearInput400;
    Console.WriteLine($"{yearInput4}, {yearInput100}, {yearInput400}, {yearInputResult}");
    if (yearInput4==0&&yearInput400==0&&yearInput100==0){
        Console.WriteLine($"{yearInput} is a leap year!");
    }
    else if (yearInput4==0&&yearInput100==0&&yearInput400!=0){
        // divisible by 4, 100, and 400.
        Console.WriteLine($"{yearInput} is not a leap year.");
    }
    else if (yearInput4==0&&yearInput100!=0&&yearInput400!=0) {
        // divisible by 4, but not divisible by 100 or 400
        Console.WriteLine($"{yearInput} is a leap year!");
    }
    else if (yearInput4==0&&yearInput100==0){
        // divisible by 4 and divisible by 100.
        Console.WriteLine($"{yearInput} is not a leap year.");
    }
    else if (yearInput4!=0){
        // not divisible by 4.
        Console.WriteLine($"{yearInput} is not a leap year.");
    }
    else { 
        // handles non-years being entered.
        Console.WriteLine("An invalid year was entered.");
    }
    }
}