using System;
using System.Linq;
using System.Collections.Generic;
using AcademyManagementApp.Interfaces;
using AcademyManagementApp.Enums;

namespace AcademyManagementApp
{
    public class Admin : User, IAdmin
    {
        public Admin(string firstName, string lastName, string username, string password, UserType userType) :
            base(firstName, lastName, username, password, UserType.Admin)
        {

        }
        public void RemoveUsers(List<User> users, string name)
        {
            User userToRemove = null;
            userToRemove = users.FirstOrDefault(x => x.FirstName == name);

            if (userToRemove != this) users.Remove(userToRemove);
            else throw new Exception("You can't remove yourself, that would open up a blackhole and turn existence inside out!");
        }
        public void AddUsers(List<User> users)
        {
            Console.WriteLine("Insert First Name:");
            string newUserFirstName = Console.ReadLine();

            Console.WriteLine("Insert Last Name:");
            string newUserLastName = Console.ReadLine();

            Console.WriteLine("Insert Username:");
            string newUserUsername = Console.ReadLine();

            Console.WriteLine("Insert Password:");
            string newUserPassword = Console.ReadLine();

            Console.WriteLine("Choose UserType (1/2/3):" +
                "\n1) Student" +
                "\n2) Trainer" +
                "\n3) Admin");
            string newUserUserTypeInput = Console.ReadLine();

            UserType newUserUserType = 0;

            switch (newUserUserTypeInput)
            {
                case "1":
                    Console.WriteLine("Choose Active Subject (1/2/3):" +
                "\n1) Geography" +
                "\n2) History" +
                "\n3) Math");
                    string newUserActiveSubjectInput = Console.ReadLine();

                    Subject newUserActiveSubject = 0;

                    switch (newUserActiveSubjectInput)
                    {
                        case "1":
                            newUserActiveSubject = Subject.Geography;
                            break;
                        case "2":
                            newUserActiveSubject = Subject.History;
                            break;
                        case "3":
                            newUserActiveSubject = Subject.Math;
                            break;
                        default:
                            Console.WriteLine("Wrong input of Active Subject!");
                            return;
                    }

                    newUserUserType = UserType.Student;
                    users.Add(new Student(newUserFirstName, newUserLastName, newUserUsername, newUserPassword, newUserUserType, newUserActiveSubject));
                    break;

                case "2":
                    newUserUserType = UserType.Trainer;
                    users.Add(new Trainer(newUserFirstName, newUserLastName, newUserUsername, newUserPassword, newUserUserType));
                    break;

                case "3":
                    newUserUserType = UserType.Admin;
                    users.Add(new Admin(newUserFirstName, newUserLastName, newUserUsername, newUserPassword, newUserUserType));
                    break;

                default:
                    Console.WriteLine("Wrong input of UserType!");
                    return;
            }
        }
    }
}