﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore_EventApp.Models
{
    public class EventContext:DbContext
    {
        public EventContext(DbContextOptions<EventContext> options): base(options)
        {

        }
        public DbSet<Event> Events { get; set; }

    }
}
