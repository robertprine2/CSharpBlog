using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Blog.Models
{
    public class Comments
    {
        [Key]
        public string CommentId { get; set; }

        public virtual string PostId { get; set; }

        public string UserName { get; set; }

        public DateTime PostTime { get; set; }

        public string CommentSubject { get; set; }

        [Required]
        public string CommentContent { get; set; }
    }
}