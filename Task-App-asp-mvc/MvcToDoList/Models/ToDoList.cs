using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcToDoList.Models
{
    public class ToDoList
    {
        public int Id { get; set; }

        [StringLength(50)]
        [Required]
        public string Task { get; set; }

        [StringLength(150)]
        public string? Description { get; set; }
        public string Status { get; set; } = "In progress";

        [NotMapped]
        public List<SelectListItem> StatusList { get; } = new List<SelectListItem>
        {
            
            new SelectListItem { Value = "In progress", Text = "In progress" },
            new SelectListItem { Value = "Done", Text = "Done" },
            
        };

        public string Priority { get; set; } = "Medium";

        [NotMapped]
        public List<SelectListItem> PriorityList { get; } = new List<SelectListItem>
        {
            new SelectListItem { Value = "Highest", Text = "Highest" },
            new SelectListItem { Value = "High", Text = "High" },
            new SelectListItem { Value = "Medium", Text = "Medium" },
            new SelectListItem { Value = "Low", Text = "Low" },
            new SelectListItem { Value = "Lowest", Text = "Lowest" },

        };

        [Display(Name = "Assignee")]
        public string Assgignee { get; set; } = "user";

        [StringLength(250)]
        public string? Comments { get; set; }

        [DataType(DataType.Date)]
        public DateTime Created { get; set; } = DateTime.Now;

        [Display(Name = "Due Date")]
        [DataType(DataType.Date)]
        public DateTime CompleteBy { get; set; } = DateTime.Now.AddDays(1);
    }
}