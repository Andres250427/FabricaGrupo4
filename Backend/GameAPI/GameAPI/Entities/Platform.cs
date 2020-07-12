using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GameAPI.Entities
{
    public class Platform
    {
        [Key]
        public int PlatformId { get; set; }
        [Required]
        [Column(TypeName = " varchar(100) ")]
        public string Name { get; set; }
        public IEnumerable<PlatformGame> PlatformGames { get; set; }
    }
}
