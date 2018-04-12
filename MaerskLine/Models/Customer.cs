using System.ComponentModel.DataAnnotations.Schema;


namespace MaerskLine.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }

    }
}