using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Net;
using VideoGameExchangeFinal.Authentication;
using VideoGameExchangeFinal.Entities;
using VideoGameExchangeFinal.Services;
using VideoGameExchangeFinal.DTO.User;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using VideoGameExchangeFinal.DTO.TradeOffer;
using VideoGameExchangeFinal.Data;
using Org.BouncyCastle.Crypto.Modes.Gcm;

namespace VideoGameExchangeFinal.Controllers
{
    [Authorize]
    [ApiController]
    [Route("/videogameexchange/offers")]
    public class TradeOfferController : ControllerBase
    {
        private readonly ApplicationDBContext _dbContext;

        public TradeOfferController(ApplicationDBContext context)
        {
            this._dbContext = context;
        }

        [HttpPost]
        public async Task<IActionResult> CreateTradeOffer([FromBody] CreateTradeOfferRequest dto)
        {
            return NoContent();
        }

        [HttpPost("confirm/{TradeOfferId}")]
        public async Task<IActionResult> ConfirmOffer([FromRoute(Name = "TradeOfferId")] int TradeOfferId, [FromBody] CreateTradeOfferActionRequest dto)
        {
            return NoContent();
        }

        [HttpGet("created")]
        public async Task<ActionResult<List<TradeOfferGetResponse>>> GetAllOffersCreated(GetTradeOfferByStatusRequest? dto)
        {
            return NoContent();
        }

        [HttpGet("received")]
        public async Task<ActionResult<List<TradeOffer>>> GetAllOffersReceived(GetTradeOfferByStatusRequest? dto)
        {
            return NoContent();
        }

        [HttpGet("{TradeOfferId}")]
        public async Task<ActionResult<TradeOfferGetResponse>> GetOfferById([FromRoute(Name = "TradeOfferId")] int TradeOfferId)
        {
            return NoContent();
        }


        [HttpDelete("{TradeOfferId}")]
        public async Task<IActionResult> DeleteOffer([FromRoute(Name = "TradeOfferId")] int TradeOfferId)
        {
            return NoContent();
        }
    }
}
