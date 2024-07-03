using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MinhaPrimeiraAPI.Domain
{
    public class Player
    {
        public int PlayerId { get; set; }

        public string Name { get; set; }

        public IList<Game> Games { get; set; }
    }
}
