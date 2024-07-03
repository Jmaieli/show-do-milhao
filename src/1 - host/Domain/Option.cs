using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinhaPrimeiraAPI.Domain
{
    public class Option
    {
        public int OptionId { get; set; }

        public int QuestionId { get; set; }

        public string Description { get; set; }

        public bool IsCorrect { get; set; }

        public Question Question { get; set; }

    }
}