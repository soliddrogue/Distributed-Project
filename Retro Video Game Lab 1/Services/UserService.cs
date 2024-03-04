using System.Security.Policy;
using VideoGameExchangeFinal.Entities;
using Microsoft.AspNetCore.Http.HttpResults;
using System.Net.Http.Headers;
using System.Text;
using VideoGameExchangeFinal.Data;

namespace VideoGameExchangeFinal.Services
{

    public class UserService : IUserService
    {

        private readonly ApplicationDBContext _context;

        public UserService(ApplicationDBContext context)
        {
            this._context = context;
        }

        /* Code block partially provided by:
         * Whetmore, J (2020). dotnet-6-basic-authentication-api source code.
         * Retrieved from https://github.com/cornflourblue/dotnet-6-basic-authentication-api/blob/master/Services/UserService.cs
         * */
        public async Task<User> Authenticate(string username, string password)
        {
            // wrapped in "await Task.Run" to mimic fetching user from a db
            var user = await Task.Run(() => _context.Users.SingleOrDefault(x => x.Username == username && x.Password == password));

            // on auth fail: null is returned because user is not found
            // on auth success: user object is returned
            return user;
        }
    }
}
