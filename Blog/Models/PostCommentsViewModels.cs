using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blog.Models
{
    public class PostCommentsViewModels
    {
        public Posts Posts { get; set; }

        public Comments Comments { get; set; }

        public RegisterViewModel User { get; set; }
    }
}