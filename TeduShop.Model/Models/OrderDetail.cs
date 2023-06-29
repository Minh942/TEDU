using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TeduShop.Model.Abstract;

namespace TeduShop.Model.Models
{
    [Table("OrderDetails")]
    public class OrderDetail :Auditable
    {
        [Key]
        public int OrderID { get; set; }
        [Key]
        public int ProducID { get; set; }
        public int Quantity { get; set; }
        [ForeignKey("OrderID")]
        public virtual Order Order { get; set; }
        [ForeignKey("ProductID")]
        public virtual Product Product { get; set; }

    }
}
