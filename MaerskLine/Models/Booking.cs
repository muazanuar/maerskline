using System.ComponentModel.DataAnnotations.Schema;

namespace MaerskLine.Models

{
    public class Booking
    {
        public int BookingID { get; set; }
        public int CustomerID { get; set;}
        public int Schedule { get; set; }
        public int NoContainer { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
