using Books_Day3.Models;

namespace Books_Day3.Service.IService
{
    public interface IUserService
    {
        UserNew Authenticate (string username, string password);
        IEnumerable<UserNew> GetAll();
    }
}
