using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookTracker.Models
{
    public class CategoryType
    {
        [Key]
        [Required]
        public string Type { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
