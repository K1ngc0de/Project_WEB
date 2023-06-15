using eUseControl.Domain.Entities;

namespace eUseControl.Web.Models
{
    public class CategoryView
    {
        public string Name { get; set; }
        public Post[] Posts { get; set; }
    }
}