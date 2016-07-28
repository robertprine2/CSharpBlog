using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Blog.Models
{
    public class Comments
    {
        public int CommentId { get; set; }

        public int PostId { get; set; }

        public string CommentSubject { get; set; }

        [Required]
        public string CommentContent { get; set; }
    }
}