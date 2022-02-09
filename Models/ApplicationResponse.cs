using System;
using System.ComponentModel.DataAnnotations;

namespace project1.Models
{
    public class ApplicationResponse
    {
        //task(string), due date(date), quadrant(string), category(string), completed(bool)

        public int TaskID { get; set; }

        public string Task { get; set; }

        [Required]
        public string Quadrant { get; set; }

        public string Category { get; set; }

        public bool completed { get; set; }

    }
}
