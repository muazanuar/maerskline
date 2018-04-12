using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MaerskLine.Models
{
    public class Schedule
    {
        public int ScheduleID { get; set; }
        public DateTime Time { get; set; }
        public String Location { get; set; }
        public int BookingID { get; set; }
        public int CustomerID { get; set; }
        public virtual Booking Booking { get; set; }
    }
}
