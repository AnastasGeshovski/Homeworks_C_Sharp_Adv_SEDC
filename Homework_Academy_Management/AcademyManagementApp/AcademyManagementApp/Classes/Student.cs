using System;
using System.Collections.Generic;
using AcademyManagementApp.Interfaces;
using AcademyManagementApp.Enums;

namespace AcademyManagementApp
{
    public class Student : User, IStudent
    {
        public Dictionary<Subject, Grade> Grades = new Dictionary<Subject, Grade>
        {
            {Subject.Geography, Grade.A },
            {Subject.History, Grade.B },
            {Subject.Math, Grade.C }
        };
        public Subject ActiveSubject { get; set; }
        public Student(string firstName, string lastName, string username, string password, UserType userType, Subject activeSubject) :
            base(firstName, lastName, username, password, UserType.Student)
        {
            ActiveSubject = activeSubject;
        }
        public void PrintAllGrades()
        {
            Console.WriteLine($"Subject{15} | Grade");
            foreach (KeyValuePair<Subject, Grade> entry in Grades)
            {
                Console.WriteLine($"{entry.Key,15} | {entry.Value}");
            }
        }
        public void PrintCurrentSubject()
        {
            Console.WriteLine($"Currently Listening: {ActiveSubject}");
        }
    }
}