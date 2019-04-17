namespace P05_Students
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            var students = new List<Student>();

            while (true)
            {
                var studentInfo = Console.ReadLine().Split();

                if (studentInfo[0] == "end")
                {
                    break;
                }

                string firstName = studentInfo[0];
                string lastName = studentInfo[1];
                int age = int.Parse(studentInfo[2]);
                string city = studentInfo[3];

                Student student = new Student();
                student.FirstName = firstName;
                student.LastName = lastName;
                student.Age = age;
                student.City = city;

                students.Add(student);
            }

            string currentCity = Console.ReadLine();

            foreach (var currentStudent in students)
            {
                if (currentStudent.City == currentCity)
                {
                    Console.WriteLine($"{currentStudent.FirstName} {currentStudent.LastName} is " +
                        $"{currentStudent.Age} years old.");
                }
            }
        }
    }

    public class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string City { get; set; }
    }
}
