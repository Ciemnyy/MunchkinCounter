using System.Collections.Generic;
using System.Linq;
using MunchkinCounter;

namespace Helpers
{
    public static class PlayerHelper
    {
        public static int CalculeteCultistPower(List<Player> players)
        {
            int numberOfCultist = players.Count(z => z.isCultist);
            return numberOfCultist > 1 ? (numberOfCultist - 1) * 2 : 0;
        }
        public static void AddUnique(this List<Player> players, Player playerToAdd)
        {
            if (players.Count(z => playerToAdd == z) == 0)
                players.Add(playerToAdd);
            //TODO alert            
        }
    }

    public static class GeneralHelper
    {
        public static string ToSymbol(this Genders gender)
        {
            switch (gender)
            {
                case Genders.Male:
                    return "\u2642";
                case Genders.Female:
                    return "\u2640";
                default:
                    return "";
            }
        }
    }
}
