﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("SupportOnlines")]
    public class SupportOnline
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string ID { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(50)]
        public string Department { get; set; }
        [MaxLength(50)]
        public string Skype { get; set; }
        [MaxLength(50)]
        public string Mobile { get; set; }
        [MaxLength(50)]
        public string Email { get; set; }
        [MaxLength(50)]
        public string Yahoo { get; set; }
        [MaxLength(50)]
        public string Facebook { get; set; }
        public string Status { get; set; }
        public int? DisplayOrder { get; set; }
    }
}
