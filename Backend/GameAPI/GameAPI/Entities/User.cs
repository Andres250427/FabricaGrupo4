using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GameAPI.Entities
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        [Column(TypeName = " varchar(100) ")]
        public string Name { get; set; }
        [Required]
        [Column(TypeName = " varchar(100) ")]
        public string Email { get; set; }
        [Required]
        [Column(TypeName = " varchar(100) ")]
        public string Password { get; set; }


    }
}
