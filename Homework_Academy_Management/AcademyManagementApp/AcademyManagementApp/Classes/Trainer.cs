using System;
using System.Collections.Generic;
using AcademyManagementApp.Interfaces;
using AcademyManagementApp.Enums;

namespace AcademyManagementApp
{
    public class Trainer : User, ITrainer
    {
        public Trainer(string firstName, string lastName, string username, string password, UserType userType) :
            base(firstName, lastName, username, password, UserType.Trainer)
        {

        }
        public void PrintAllStudents(List<User> users)
        {
            Console.WriteLine("List of all students:");
            foreach (User student in users)
            {
                if (student.UserType != UserType.Student) continue;

                Console.WriteLine($"{student.FirstName}");
            }
        }
        public void PrintAllSubjectsOfStudent(List<User> users, string name)
        {
            foreach (User student in users)
            {
                if (student.UserType != UserType.Student) continue;

                Student studentUser = (Student)student;

                if (student.FirstName == name)
                {
                    Console.WriteLine($"{student.FullName}");
                    studentUser.PrintAllGrades();
                    return;
                }
            }
            throw new Exception("No user with that name found!");
        }
        public void PrintAllSubjects(List<User> users)
        {
            int geoCount = 0;
            int histCount = 0;
            int mathCount = 0;

            foreach (User student in users)
            {
                if (student.UserType != UserType.Student) continue;

                Student studentUser = (Student)student;

                if (studentUser.ActiveSubject == Subject.Geography) geoCount++;
                else if (studentUser.ActiveSubject == Subject.History) histCount++;
                else if (studentUser.ActiveSubject == Subject.Math) mathCount++;
            }

            Console.WriteLine($"Subject{15} | Attendees" +
                $"\n{Subject.Geography,15} | {geoCount}" +
                $"\n{Subject.History,15} | {histCount}" +
                $"\n{Subject.Math,15} | {mathCount}");
        }
    }
}