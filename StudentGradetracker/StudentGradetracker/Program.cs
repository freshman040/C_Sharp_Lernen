// See https://aka.ms/new-console-template for more information
using StudentGradetracker.Utilities;
using StudentGradetracker.Models;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Xml.Linq;

namespace StudentGradetracker
{

    class Program
    {
        private static List<Student> students = new List<Student>();

        static void Main(string[] args)
        {

            Console.WriteLine("***Student Grade Tracker ***");
            while (true)
            {
                DisplayMenu(); // Call the menu display function
                int choice = GetChoice();

                switch (choice)
                {
                    case 1:
                        AddStudent();
                        break;
                    case 2:
                        ViewStudents();
                        break;
                    case 3:
                        AddGrade();
                        break;
                    case 4:
                        ExitApplication();
                        break;
                  
                }
            }
        }

        // Function to display the menu options
        private static void DisplayMenu()
        {
            Console.WriteLine("\n*** Menu ***");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. View Students");
            Console.WriteLine("3. Add Grade");
            Console.WriteLine("4. Exit");
        }

        // Function to get user choice from the menu
        private static int GetChoice()
        {
            Console.Write("Enter choice: ");
            string input = Console.ReadLine();
            int choice;
            while (!int.TryParse(input, out choice))
            {
                Console.WriteLine("Invalid input. Please enter an integer!");
                input = Console.ReadLine();
            }

            return choice;
        }

        // Function to add a new student
        private static void AddStudent()
        {
            Console.Write("Enter student name: ");
            string name = Console.ReadLine();
            students.Add(new Student(name)); 
            
            //new Student(name): Es wird ein neues Objekt(eine neue Instanz) 
            //der Klasse Student erstellt. Dabei wird der Konstruktor der Klasse aufgerufen und der Variable name übergeben, um den Studenten zu initialisieren.students.Add(...): 
            //Dieses neue Student - Objekt wird zu einer bestehenden Liste(wahrscheinlich List < Student > students) hinzugefügt.
            //Zusammenfassend: Es wird ein neuer Student mit dem angegebenen Namen erstellt und in die Liste students aufgenommen.
            
            Console.WriteLine("Student Added Successfully!");


        }

        //Function to view students
        private static void ViewStudents()
        {
            if(students.Count == 0)
            {
                Console.WriteLine("No student added yet.");
                return;
            }
            Console.WriteLine("\n***View Students***");
            foreach (Student student in students)
            {
                Console.WriteLine(student); // Use override ToString() for formatted output

            }

        }

        private static void AddGrade() 
        {
            if (students.Count == 0)
            {
                Console.WriteLine("No students found. Please add a student before adding grades.");
                return;
            }

            // 1. Select student
            Console.WriteLine("\nSelect student to add grade:");
            int studentIndex = GetStudentIndex(); // Function to display and get student selection 

            // 2. Get grade details
            Console.Write("Enter subject: ");
            string subject = Console.ReadLine();
            double score;

            do
            {
                Console.Write("Enter student's score: ");
                string input = Console.ReadLine();
                if (double.TryParse(input, out score) && InputValidation.IsValidScore(score))
                {
                    break; // Valid score entered
                }
                else
                {
                    Console.WriteLine("Invalid score. Please enter a numeric value betweeen 0 and 100.");
                }
            } while (true);

            // 3. Add grade to selected student
            students[studentIndex].AddGrade(new Grade(subject, score));
            Console.WriteLine("Grade added succesfully!");

        }

        // Helper function to display students and get selected index
        private static int GetStudentIndex()
        {
            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {students[i].Name}");
            }
            Console.Write("Enter student index(1-{0}): ", students.Count);
            string input = Console.ReadLine();
            int index;
            while (!int.TryParse(input, out index) || index < 1 || index > students.Count)
            {
                Console.WriteLine("Invalid selection. Please enter a number between 1 and {0}.", students.Count);
                input = Console.ReadLine();
            }
            return index - 1; // Convert 1-based selection to 0-based index
        }

        private static void ExitApplication()
        {
            Console.WriteLine("Exiting Application...");
            Environment.Exit(0); // Ensure clean exit
        }

    }
}




