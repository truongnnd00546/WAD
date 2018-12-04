using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplicationDevelopment.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Exam Subject")]
        public string Subject { get; set; }

        [Display(Name = "Start Time")]
        [Required(ErrorMessage = "Không được bỏ trống ô này")]
        [DataType(DataType.Time)]
        public DateTime StartTime { get; set; }

        [Display(Name = "Exam Date")]
        [Required(ErrorMessage = "Không được bỏ trống ô này")]
        [DataType(DataType.Date)]
        public DateTime ExamDate { get; set; }

        [Display(Name = "Exam Duration")]
        [Required(ErrorMessage = "Không được bỏ trống ô này")]
        public int Duration { get; set; }

        [Display(Name = "Class Room")]
        public string ClassRoom { get; set; }

        [Display(Name = "Faculty")]
        public string Faculty { get; set; }

    }
}