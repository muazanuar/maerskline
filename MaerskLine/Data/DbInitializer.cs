using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MaerskLine.Models;

namespace MaerskLine.Data
{
    public class DbInitializer
    {
        public static void Initialize(ShippingContext context)
        {
            context.Database.EnsureCreated();

            // Look for any customer.
            if (context.Customer.Any())
            {
                return;   // DB has been seeded
            }

            var customer = new Customer[]
            {
            //new Customer{CustomerID=001,Name="Carson",Company="Stoned.co"},
            //new Customer{CustomerID=002,Name="Meredith",Company="Pakhg"}
            };
            foreach (Customer s in customer)
            {
                context.Customer.Add(s);
            }
            context.SaveChanges();

            var booking = new Booking[]
            {
            //new Booking{BookingID=1050,CustomerID=001,Schedule=3,NoContainer=1}
            };
            foreach (Booking c in booking)
            {
                context.Booking.Add(c);
            }
            context.SaveChanges();

            var schedule = new Schedule[]
            {
            //new Schedule{Time=1,Location="KL", BookingID=1,CustomerID=001},

            };
            foreach (Schedule e in schedule)
            {
                context.Schedule.Add(e);
            }
            context.SaveChanges();
        }
    }
}
