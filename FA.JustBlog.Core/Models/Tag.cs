﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FA.JustBlog.Core.Models
{
    public class Tag
    {
        public int TagId { get; set; }
        [Required(ErrorMessage = "Tag name is required.")]
        [StringLength(255)]
        public string TagName { get; set; }

        public int Count { get; set; }

        [StringLength(255)]
        public string UrlSlug { get; set; }

        [StringLength(1024)]
        public string Description { get; set; }

        public virtual IList<Post> Posts { get; set; }

    }
}
