using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GameAPI.Entities
{
    public class PlatformGame
    {
        public int PlatformId { get; set; }
        public int GameId { get; set; }
        public Game Game { get; set; }
        public Platform Platform { get; set; }

    }
}