using System.Linq;

namespace PPPDDDChap18.DomainServices.OnlineGaming.WithDomainServices.Model
{
    // domain service implementation; part of the UL
    public class Free12MonthSubscriptionForHighScoresReward : IGamingRewardPolicy
    {
        private IScoreFinder repository;

        public Free12MonthSubscriptionForHighScoresReward(IScoreFinder repository)
        {
            this.repository = repository;
        }

        public void Apply(IGame game)
        {
            var top100Threshold = repository.FindTopScore(game, 100);

            if (game.Winners.Single().Score > top100Threshold)
            {
                // trigger reward process
            }
        }
    }
}