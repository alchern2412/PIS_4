using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace lab3_1_new.Models
{
    public class RecordContext : DbContext
    {
        public DbSet<Record> Records { get; set; }
    }
}