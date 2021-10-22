using System.Collections.Generic;

namespace AcademyManagementApp.Interfaces
{
    interface ITrainer : IUser
    {
        void PrintAllStudents(List<User> users);
        void PrintAllSubjectsOfStudent(List<User> users, string name);
        void PrintAllSubjects(List<User> users);
    }
}