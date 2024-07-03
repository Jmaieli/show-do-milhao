using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MinhaPrimeiraAPI.Domain

{
    public class Question
    {
        public int QuestionId { get; set; }

        public string QuestionText { get; set; }

        public IList<Option> Options { get; set; }

        public Game Game { get; set; }

    }
}