﻿using Blog.Models;
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

        public virtual Posts PostId { get; set; }

        public string UserName { get; set; }

        [DataType(DataType.Date)]
        // If I don't use below I should have time too
        //[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime PostTime { get; set; }

        [StringLength(100, ErrorMessage = "The subject can only be 100 characters.")]
        public string CommentSubject { get; set; }

        [Required]
        public string CommentContent { get; set; }
    }
}