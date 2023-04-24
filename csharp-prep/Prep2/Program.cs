using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your grade percentage: ");
        int grade = int.Parse(Console.ReadLine());

        // Determine letter grade
        string letterGrade = "";

        if (grade >= 90) 
        {
            letterGrade = "A";
        } 
        else if (grade >= 80) 
        {
            letterGrade = "B";
        } 
        else if (grade >= 70) 
        {
            letterGrade = "C";
        } 
        else if (grade >= 60) 
        {
            letterGrade = "D";
        } 
        else 
        {
            letterGrade = "F";
        }

        // Print out letter grade
        Console.WriteLine($"Your letter grade is: {letterGrade}");

        // Check if the student passed
        if (grade >= 70) 
        {
            Console.WriteLine("Congratulations! You passed the course.");
        } 
        else 
        {
            Console.WriteLine("Sorry, you did not pass the course. Keep trying!");
        }
    }
}