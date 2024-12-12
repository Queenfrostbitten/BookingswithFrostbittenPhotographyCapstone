using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace Bookingcalendar.Capstone
{
    public class BookingCalendar : DbContext
    {
        public DbSet<Event> Events { get; set; }
        public BookingCalendar(DbContextOptions<BookingCalendar> options) : base(options) { }
    }

    public class Event
    {
        public int Id { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public string? Text { get; set; }
        public string? Color { get; set; }
    }

}

