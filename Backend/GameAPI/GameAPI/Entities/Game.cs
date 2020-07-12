using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GameAPI.Entities
{
    public class Game
    {
        [Key]
        public int GameId { get; set; }
        [Required]
        [Column(TypeName = " varchar(100) ")]
        public string Name { get; set; }
        [Required]
        [Column(TypeName = " varchar(10) ")]
        public string ReleaseDate { get; set; }
        [Column(TypeName = "varchar(MAX)")]
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public IEnumerable<PlatformGame> PlatformsGame { get; set; }

    }
}
