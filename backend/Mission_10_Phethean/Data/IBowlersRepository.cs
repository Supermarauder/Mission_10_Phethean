namespace Mission_10_Phethean.Data
{
    public interface IBowlersRepository
    {
        IEnumerable<Bowler> Bowlers { get; }
        IEnumerable<Team> Teams { get; }
    }
}
