using Books_Day3.Models;
namespace Books_Day3.Data.Repositories.IRepository
{
    public interface IUserRepository
    {
        List<User> GetAllUsersInMemory();
        List<User> GetAllUsersFromDatabase();
        User GetUserById(int id);
        void AddUser(User user);
        List<User> GetUsersOrderedByUsername();
        List<IGrouping<string, User>> GetUsersGroupedByRole();
        List<dynamic> GetUsersWithRoles();
    }
}
