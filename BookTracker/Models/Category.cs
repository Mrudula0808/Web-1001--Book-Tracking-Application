using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookTracker.Models
{
    public class Category
    {
     
        [Key]
        public string NameToken { get; set; }
        [Required]
        public string Description { get; set; }
        [ForeignKey("TypeId")]
        public string TypeId { get; set; }
        public CategoryType Type { get; set; }   



    }
}
