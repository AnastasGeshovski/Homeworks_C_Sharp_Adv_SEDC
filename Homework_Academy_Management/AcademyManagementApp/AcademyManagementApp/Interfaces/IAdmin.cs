
using System.Collections.Generic;

namespace AcademyManagementApp.Interfaces

{
    interface IAdmin
    {
        void RemoveUsers(List<User> users, string name);
        void AddUsers(List<User> users);
    }
}