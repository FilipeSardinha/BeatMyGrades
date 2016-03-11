using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LoginDemo.Models
{
    public class Lesson
    {
        public int LessonID { get; set; }
        public string Student { get; set; }
        public string Professor { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
    }

}