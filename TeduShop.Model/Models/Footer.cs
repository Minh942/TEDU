﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("Footers")]
    class Footer
    {
        [Key]
        public string ID { get; set; }
        [Required]
        public string Content { get; set; }
    }
}
