using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using VideoGameExchangeFinal.Authentication;
using VideoGameExchangeFinal.Data;
using VideoGameExchangeFinal.DTO.User;
using VideoGameExchangeFinal.Entities;
using VideoGameExchangeFinal.Services;

namespace VideoGameExchangeFinal.Controllers
{
    [Authorize]
    [ApiController]
    [Route("/videogameexchange/users")]
    public class UserController : ControllerBase
    {
        private readonly ApplicationDBContext _dbContext;

        private IUserService _userService;

        public UserController(ApplicationDBContext context, IUserService userService)
        {
            this._dbContext = context;
            this._userService = userService;
        }

        [AllowAnonymous]
        [HttpPost("authenticate")]
        public async Task<IActionResult> Authenticate([FromBody] AuthUserRequest model)
        {
            return NoContent();
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> CreateUser([FromBody] UserGetResponse dto)
        {
            return NoContent();
        }

        [HttpGet]
        public async Task<ActionResult<List<UserGetResponse>>> GetAllUsers()
        {
            return NoContent();
        }


        [HttpGet("{UserId}")]
        public async Task<ActionResult<List<UserGetResponse>>> GetUserById([FromRoute(Name = "UserId")][Required] int userId)
        {
            return NoContent();
        }

        [HttpPatch("{UserId}/updatePassword")]
        public async Task<IActionResult> UpdateUserPassword([FromRoute(Name = "UserId")][Required] int userId, [FromBody] UpdateUserPasswordRequest dto)
        {
            return NoContent();
        }

        [HttpPatch("{UserId}/updateStreetAddress")]
        public async Task<IActionResult> UpdateStreetAddress([FromRoute(Name = "UserId")][Required] int userId, [FromBody] UpdateUserAddressRequest dto)
        {
            return NoContent();
        }

        [HttpPatch("{UserId}/updateUsername")] 
        public async Task<IActionResult> UpdateUserUsername([FromRoute(Name = "UserId")][Required] int userId, [FromBody] UpdateUserUsernameRequest dto)
        {
            return NoContent();
        }

        [HttpDelete("{UserId}")]
        public async Task<IActionResult> DeleteUser([FromRoute(Name = "UserId")][Required] int userId)
        {
            return NoContent();
        }
    }
}
