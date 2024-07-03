using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinhaPrimeiraAPI.Domain
{
    public class PlayerAnswer
    {
        public int PlayerAnswerId { get; set; }

        public int PlayerId { get; set; }

        public int QuestionId { get; set; }

        public int OptionId { get; set; }

        public int Pontos { get; set; }

        public Question Question { get; set; }

        public Player Player { get; set; }

        public Option Option { get; set; }

    }
}