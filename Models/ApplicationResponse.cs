using System;
using System.ComponentModel.DataAnnotations;

namespace project1.Models
{
    public class ApplicationResponse
    {
        //task(string), due date(date), quadrant(string), category(string), completed(bool)

        [Key]
        [Required]
        public int TaskId { get; set; }

        [Required]
        public string Task { get; set; }

        public string DueDate { get; set; }

        [Required]
        public int Quadrant { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public bool Completed { get; set; }

    }
}
