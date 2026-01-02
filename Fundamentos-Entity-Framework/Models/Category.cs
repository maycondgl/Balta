using Dapper.Contrib.Extensions;
using System.Collections.Generic;

namespace Blog.Models
{
    [Table("[Category]")]
    public class Category
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Slug { get; set; }
    }
}