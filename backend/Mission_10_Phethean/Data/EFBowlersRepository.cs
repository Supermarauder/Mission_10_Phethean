namespace Mission_10_Phethean.Data
{
    public class EFBowlersRepository : IBowlersRepository
    {
        private BowlingLeagueContext _context;

        public EFBowlersRepository(BowlingLeagueContext temp) 
        {
            _context = temp;
        }

        public IEnumerable<Bowler> Bowlers => _context.Bowlers;
        public IEnumerable<Team> Teams => _context.Teams;
    }
}
