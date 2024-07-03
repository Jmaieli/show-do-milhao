using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinhaPrimeiraAPI.Domain
{
    public class Game
    {
        public int GameId { get; set; }

        public string Theme { get; set; }

        public IList<Question> Questions { get; set; }

        public IList<Player> Players { get; set; }

        public IList<PlayerAnswer> PlayerAnswers { get; set; }

    }
}