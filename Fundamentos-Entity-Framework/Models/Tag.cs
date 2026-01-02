using Dapper.Contrib.Extensions;
using System.Collections.Generic;

namespace Blog.Models
{
    [Table("[Tag]")]
    public class Tag
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Slug { get; set; }

    }
}