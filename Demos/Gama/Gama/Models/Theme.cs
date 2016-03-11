using System;
using System.Web.Security;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gama.Models
{
    public class Theme
    {
        public int ThemeID { get; set; }
        public string Topic { get; set; }
        public string SubTopic { get; set; }
    }

    public class ThemeDbContext : DbContext
    {
        public DbSet<Theme> Themes { get; set; }
    }
}