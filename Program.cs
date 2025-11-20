using System;

namespace CodeFirstDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new StudentContext())
            {
                var student = new Student()
                {
                    StudentName = "John Doe"
                };

                db.Students.Add(student);
                db.SaveChanges();

                Console.WriteLine("Student added successfully!");
                Console.ReadLine();
