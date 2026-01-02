using Dapper.Contrib.Extensions;
using System.Collections.Generic;

namespace Blog.Models
{
    [Table("[Post]")]
    public class Post
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public int CategoryId { get; set; }

    }
}