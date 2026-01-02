using Dapper.Contrib.Extensions;
using System.Collections.Generic;

namespace Blog.Models
{
    [Table("[Role]")]
    public class Role
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Slug { get; set; }

    }
}