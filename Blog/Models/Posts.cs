using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Blog.Models
{
    public class Posts
    {
        //Ethan showed me this as a way to hack around getting the postId for the comments
        public Posts()
        {
            PostComments = new List<Comments>();
            NewComment = new Comments()
            {
                //PostId = this.PostId
            };
        }

        [Key]
        public string PostId { get; set; }

        [Required]
        public string UserId { get; set; }

        [Required]
        public string PostSubject { get; set; }

        public string PostImage { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        public string PostName { get; set; }

        [Required]
        public string PostContent { get; set; }
        
        public virtual List<Comments> PostComments { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.NotMapped]
        public Comments NewComment { get; set; }

    }
}