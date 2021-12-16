using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BookTracker.Models
{
    public class Book
    {
        [Key]
        [Required]
        [Display(Name = "Books Unique ISBN Number.")]
        public string ISBNNumber { get; set; }
        [Required]
        public string Title { get; set; }
        [ForeignKey("CategoryId")]
        [Display(Name = "Category")]
        public string CategoryId { get; set; }
        public Category Categories { get; set; }
        [Required]
        [Display(Name = "Books's author.")]
        public string Author { get; set; }
    }
}
