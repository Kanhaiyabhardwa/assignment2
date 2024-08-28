using System;

class SubjectMarks
{
    public void Main3()
    {
        // Variables to store the marks
        int mark1, mark2, mark3, mark4, mark5;
        int totalMarks;
        double average;

        // Taking input from the user
        Console.WriteLine("Enter the marks of five subjects:");

        Console.Write("Subject 1: ");
        mark1 = int.Parse(Console.ReadLine());

        Console.Write("Subject 2: ");
        mark2 = int.Parse(Console.ReadLine());

        Console.Write("Subject 3: ");
        mark3 = int.Parse(Console.ReadLine());

        Console.Write("Subject 4: ");
        mark4 = int.Parse(Console.ReadLine());

        Console.Write("Subject 5: ");
        mark5 = int.Parse(Console.ReadLine());

        // Calculating the total and average marks
        totalMarks = mark1 + mark2 + mark3 + mark4 + mark5;
        average = totalMarks / 5.0;

        // Determining the grade
        char grade;
        if (average >= 90)
        {
            grade = 'A';
        }
        else if (average >= 80)
        {
            grade = 'B';
        }
        else if (average >= 70)
        {
            grade = 'C';
        }
        else if (average >= 60)
        {
            grade = 'D';
        }
        else
        {
            grade = 'F';
        }

        // Displaying the results
        Console.WriteLine($"\nTotal Marks: {totalMarks}");
        Console.WriteLine($"Average Marks: {average}");
        Console.WriteLine($"Grade: {grade}");
    }
}
