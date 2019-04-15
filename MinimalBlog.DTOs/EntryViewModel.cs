using System.ComponentModel.DataAnnotations;

namespace MinimalBlog.DTOs
{
    public class EntryViewModel
    {
        [Required]
        public string Title { get; set; }

        public string Content { get; set; }

        public string Summary { get; set; }

        public string Image { get; set; } 
        
        public bool IsPrivate { get; set; }
    }
}
