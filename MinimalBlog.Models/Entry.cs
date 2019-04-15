using MinimalBlog.Models.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace MinimalBlog.Models
{
    public class Entry 
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public DateTime Created { get; set; }
                
        public string Summary { get; set; }

        [Required]
        public string Title { get; set; }

        public string Content { get; set; }

        public string Image { get; set; }

        [Required]        
        public int UserId { get; set;}
        
        public virtual User Author { get; set;}

        [Required]
        public EntryStateEnum State { get; set; }       
    }
}
