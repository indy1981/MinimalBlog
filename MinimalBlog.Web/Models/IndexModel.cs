using MinimalBlog.Models;
using System.Collections.Generic;

namespace MinimalBlog.Web.Models
{
    public class IndexModel
    {
        public IEnumerable<Entry> Entries { get; set; }        
    }
}
