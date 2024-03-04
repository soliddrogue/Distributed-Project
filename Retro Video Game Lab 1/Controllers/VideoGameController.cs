using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Net;
using VideoGameExchangeFinal.Authentication;
using VideoGameExchangeFinal.DTO.VideoGame;
using VideoGameExchangeFinal.Entities;
using VideoGameExchangeFinal.Services;
using Microsoft.AspNetCore.Http.HttpResults;
using Org.BouncyCastle.Crypto;
using VideoGameExchangeFinal.DTO.User;
using VideoGameExchangeFinal.Data;

namespace VideoGameExchangeFinal.Controllers
{
    [Authorize]
    [ApiController]
    [Route("/videogameexchange/videogames")]
    public class VideoGameController : ControllerBase
    {
        private readonly ApplicationDBContext _dbContext;

        //TODO: Implement service

        public VideoGameController(ApplicationDBContext context)
        {
            this._dbContext = context;
        }

        [HttpPost]
        public async Task<IActionResult> InsertVideoGame([FromBody] CreateVideoGameRequest dto)
        {
             return NoContent();
        }

        [HttpGet]
        public async Task<ActionResult<List<GetVideoGameResponse>>> GetAllVideoGames()
        {
            return NoContent();
        }

        [HttpGet("{VideoGameId}")]
        public async Task<ActionResult<List<UserGetResponse>>> GetVideoGameById([FromRoute(Name = "VideoGameId")]int videoGameId)
        {
            return NoContent();
        }

        [HttpPut("{VideoGameId}")]
        public async Task<IActionResult> modifyVideoGame([FromRoute(Name = "VideoGameId")]int VideoGameId, [FromBody] PutVideoGameRequest dto)
        {
            return NoContent();
        }

        [HttpDelete("{VideoGameId}")]
        public async Task<IActionResult> DeleteVideoGame([FromRoute(Name = "VideoGameId")] int VideoGameId)
        {
            return NoContent();
        }
    }
}

