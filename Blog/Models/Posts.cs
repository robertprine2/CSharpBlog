using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Blog.Models
{
    public class Posts
    {
        
        public string PostId { get; set; }

        
        public string UserId { get; set; }

        [Required]
        public string PostSubject { get; set; }

        [Required]
        public string BlogId { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        public string PostName { get; internal set; }
    }
}