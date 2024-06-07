namespace mvc_core_mini_project.Models
{
    public class custsalVM
    {
        public Int64 SalesId { get; set; }
        public Int64 CustomerId { get; set; }
        public Int64 BookId { get; set; }

        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerPhone { get; set; }
        public DateTime? SalesDate { get; set; }
        public string BookName { get; set; }

        public decimal Price { get; set; }
        public decimal Qty { get; set; }
       
        
        public string BookDesc { get; set; }
        public Int64 AuthorId { get; set; }
        public Int64 SubjectId { get; set; }
    }
}
