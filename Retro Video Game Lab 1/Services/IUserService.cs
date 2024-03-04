using VideoGameExchangeFinal.Entities;

namespace VideoGameExchangeFinal.Services
{
    public interface IUserService
    {
        Task<User> Authenticate(string username, string password);
    }
}
