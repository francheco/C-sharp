// Import necessary namespaces for using classes like List, IEnumerable, and LINQ
using System;
using System.Collections.Generic;
using System.Linq;

// Define a class named Student to represent student information
class Student
{
    // Define properties for the student's first name, last name, and exam points
    public string FirstName { get; set; }  // Property for the first name of the student
    public string LastName { get; set; }   // Property for the last name of the student
    public int Points { get; set; }        // Property for the points scored by the student in the exam
}

class Program
{
    // Main method where program execution begins
    static void Main()
    {
        // Create a list of Latin American students with names, last names, and assigned points
        var latinAmericanStudents = new List<Student>  // Create a new list of type Student to hold student objects
        {
            // Initialize Student objects with first name, last name, and assigned points
            new Student { FirstName = "Alejandro", LastName = "Garcia", Points = 85 },
            new Student { FirstName = "Maria", LastName = "Santos", Points = 70 },
            new Student { FirstName = "Carlos", LastName = "Martinez", Points = 92 },
            new Student { FirstName = "Isabella", LastName = "Lopez", Points = 78 },
            new Student { FirstName = "Diego", LastName = "Rodriguez", Points = 60 },
            new Student { FirstName = "Camila", LastName = "Perez", Points = 88 },
            new Student { FirstName = "Javier", LastName = "Ramirez", Points = 75 },
            new Student { FirstName = "Valentina", LastName = "Hernandez", Points = 81 },
            new Student { FirstName = "Lucas", LastName = "Gomez", Points = 73 },
            new Student { FirstName = "Laura", LastName = "Diaz", Points = 67 },
            new Student { FirstName = "Mateo", LastName = "Torres", Points = 90 },
            new Student { FirstName = "Eva", LastName = "Flores", Points = 79 },
            new Student { FirstName = "Gabriel", LastName = "Acosta", Points = 83 },
            new Student { FirstName = "Sofia", LastName = "Reyes", Points = 72 },
            new Student { FirstName = "Daniel", LastName = "Ortega", Points = 65 },
            new Student { FirstName = "Valeria", LastName = "Castillo", Points = 87 },
            new Student { FirstName = "Juan", LastName = "Jimenez", Points = 76 },
            new Student { FirstName = "Ana", LastName = "Mendoza", Points = 84 },
            // Add more students with first name, last name, and points
        };


        // Calculate the average points of all students
        double averagePoints = latinAmericanStudents.Average(s => s.Points);  // Calculate the average points using LINQ

        // Get top 3 students by points
        var topStudents = latinAmericanStudents.OrderByDescending(s => s.Points).Take(3).ToList();  // Get the top 3 students based on points

        // Get bottom 3 students by points
        var bottomStudents = latinAmericanStudents.OrderBy(s => s.Points).Take(3).ToList();  // Get the bottom 3 students based on points

        // Display the results
        Console.WriteLine("Average points: " + averagePoints);  // Output the average points
        Console.WriteLine("\nTop 3 Students:");  // Display top 3 students
        foreach (var student in topStudents)  // Loop through and display top students
        {
            Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Points} points");  // Output student details
        }
        Console.WriteLine("\nBottom 3 Students:");  // Display bottom 3 students
        foreach (var student in bottomStudents)  // Loop through and display bottom students
        {
            Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Points} points");  // Output student details
        }
    }
}
