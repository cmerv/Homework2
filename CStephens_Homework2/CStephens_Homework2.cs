namespace CStephens_Homework2;
class Program
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
        Console.WriteLine("Please input a letter grade:");
        char gradeInput = Char.Parse(Console.ReadLine());
        char gradeInputLower = Char.ToLower(gradeInput);
        switch (gradeInput)
        {
            default: // input validation.
            Console.WriteLine($"An invalid letter grade was input.");
            break;
            case 'a': // if the letter entered is A, B, C, D, F then return the GPA number to console.
            Console.WriteLine($"The GPA is: {A_Grade}.");
            break;
            case 'b':
            Console.WriteLine($"The GPA is: {B_Grade}.");
            break; 
            case 'c':
            Console.WriteLine($"The GPA is: {C_Grade}.");
            break;
            case 'd':
            Console.WriteLine($"The GPA is: {D_Grade}.");
            break;
            case 'f': 
            Console.WriteLine($"The GPA is: {F_Grade}.");
            break;
        }
    }

}
