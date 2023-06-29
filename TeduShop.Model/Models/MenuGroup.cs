using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TeduShop.Model.Abstract;

namespace TeduShop.Model.Models
{
    [Table("MenuGroups")]
    public class MenuGroup : Auditable
    {
        [Key]
        public string ID { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        public virtual IEnumerable<Menu> Menus { get; set; }
    }
}
