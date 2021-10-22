
namespace AcademyManagementApp.Interfaces
{
    interface IStudent : IUser
    {
        void PrintCurrentSubject();
        void PrintAllGrades();
    }
}