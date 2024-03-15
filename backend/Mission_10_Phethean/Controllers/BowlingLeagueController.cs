using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mission_10_Phethean.Data;

namespace Mission_10_Phethean.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BowlingLeagueController : ControllerBase
    {
        private IBowlersRepository _bowlersRepository;

        public BowlingLeagueController(IBowlersRepository temp)
        {
            _bowlersRepository = temp;
        }

        [HttpGet]
        public IEnumerable<Object> GetBowlers()
        {
            var data = (from bowler in _bowlersRepository.Bowlers
                       join team in _bowlersRepository.Teams
                       on bowler.TeamId equals team.TeamId
                       where team.TeamName == "Marlins" | team.TeamName == "Sharks"
                       select new
                       {
                           BowlerId = bowler.BowlerId,
                           BowlerFirstName = bowler.BowlerFirstName,
                           BowlerMiddleInit = bowler.BowlerMiddleInit,
                           BowlerLastName = bowler.BowlerLastName,
                           TeamName = team.TeamName,
                           BowlerAddress = bowler.BowlerAddress,
                           BowlerCity = bowler.BowlerCity,
                           BowlerState = bowler.BowlerState,
                           BowlerZip = bowler.BowlerZip,
                           BowlerPhoneNumber = bowler.BowlerPhoneNumber
                       }).ToArray();


            return data;

        }

    }
}
