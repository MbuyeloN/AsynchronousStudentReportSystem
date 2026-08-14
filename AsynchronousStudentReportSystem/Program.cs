using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AsynchronousStudentReportSystem
{
    class Program
    {
        // Create at least 5 student records
        static List<Student> students = new List<Student>()
        {
            new Student("Lefa", "ST001", 78),
            new Student("Thabo", "ST002", 65),
            new Student("Mpho", "ST003", 82),
            new Student("Kagiso", "ST004", 71),
            new Student("Naledi", "ST005", 88)
        };

        // Asynchronous method for loading student data
        static async Task LoadStudentData()
        {
            Console.WriteLine("Loading student data...");

            // Simulate a time-consuming operation
            await Task.Delay(2000);

            Console.WriteLine("Student data loaded successfully.");
        }

        // Asynchronous method for generating the student report
        static async Task GenerateReport()
        {
            Console.WriteLine("Generating student report...");

            // Simulate a time-consuming operation
            await Task.Delay(3000);

            Console.WriteLine("Report generated successfully.");

            foreach (Student student in students)
            {
                Console.WriteLine();
                Console.WriteLine("Student: " + student.StudentName);
                Console.WriteLine("Student Number: " + student.StudentNumber);
                Console.WriteLine("Marks: " + student.Marks);
            }

            Console.WriteLine();
            Console.WriteLine("Student report completed.");
        }

        static async Task Main(string[] args)
        {
            Console.WriteLine("Starting Student Report System...");
            Console.WriteLine();

            // Call the asynchronous methods using await
            await LoadStudentData();

            Console.WriteLine();

            await GenerateReport();

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}