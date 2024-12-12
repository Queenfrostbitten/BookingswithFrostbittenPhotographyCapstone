using System;
using System.Collections.Generic;
using System;
using Microsoft.EntityFrameworkCore;
using Bookingcalendar.Capstone;
using Microsoft.Extensions.DependencyInjection;





var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<BookingCalendar>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("CalendarContext")));
