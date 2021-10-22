using AcademyManagementApp;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademyManagementApp.Db
{
    public static class Storage
    {
        public static List<User> users { get; set; }

        static Storage()
        {
            users = new List<User>
            {
                new Student("John", "Doe", "john", "john123", Enums.UserType.Student, Enums.Subject.Geography),
                new Student("Jill", "Jillsky", "jill", "jill123", Enums.UserType.Student, Enums.Subject.History),
                new Student("Bob", "Bobsky", "bob", "bob123", Enums.UserType.Student, Enums.Subject.Geography),
                new Student("Peter", "Pepsky", "peter", "peter123", Enums.UserType.Student, Enums.Subject.Math),
                new Student("Ico", "Icsky", "ico", "ico123", Enums.UserType.Student, Enums.Subject.History),
                new Student("Nick", "Nicksky", "nick", "nick123", Enums.UserType.Student, Enums.Subject.Geography),
                new Trainer("Lill", "Wayne", "lill", "lill123", Enums.UserType.Trainer),
                new Admin("Ano", "Ansky", "ano", "ano123", Enums.UserType.Admin)
            };
        }
    }
}