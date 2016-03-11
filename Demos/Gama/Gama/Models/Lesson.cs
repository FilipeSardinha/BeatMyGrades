using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gama.Models
{
    public class Lesson
    {
        public int LessonID { get; set; }
        public int Date { get; set; }
        public Theme Topic { get; set; }

    }
    
    public class LessonDbContext : DbContext
    {
        public DbSet<Lesson> Lessons { get; set; }


    }
}