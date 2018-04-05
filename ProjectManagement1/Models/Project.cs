using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement1.Models
{
    public class Project
    {
        public int ID { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Display(Name = "Project Name")]
        [Required]
        public string ProjectName { get; set; }

        [StringLength(200, MinimumLength = 3)]
        [Required]
        public string Description { get; set; }

        [Display(Name = "Project Manager")]
        [Required]
        public string ProjectManager { get; set; }

        [Display(Name = "Tech. Lead")]
        [Required]
        public string TechLead { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Status { get; set; }

        [Display(Name = "Start Date")]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [Display(Name = "Due Date")]
        [DataType(DataType.Date)]
        public DateTime DueDate { get; set; }
    }
}
