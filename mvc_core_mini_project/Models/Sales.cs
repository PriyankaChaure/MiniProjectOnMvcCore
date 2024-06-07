using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mvc_core_mini_project.Models
{
    [Table("Sales")]
    public class Sales
    {
        [Key]
        public Int64 SalesId { get; set; }
        public Int64 CustomerId { get; set; }
        public DateTime? SalesDate { get; set; }
        public Int64 BookId { get; set; }
        public decimal Price { get; set; }
        public decimal Qty { get; set; }
        public virtual Book Book { get; set; }
        //  public virtual List<Customer> Customer { get; set; }
        public virtual Customer Customer { get; set; }
        public Sales()
        {
            //    Customer = new List<Customer>();

            Customer = new Customer();

        }
      
       
    }
}
