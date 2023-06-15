using eUseControl.BusinessLogic.Service;
using eUseControl.Domain.Entities;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace eUseControl.BusinessLogic.Database
{
	public class BlogDbContext : DbContext
	{
		public BlogDbContext()
			: base("name=eUseControl") { }
        
        public DbSet<User> Users { get; set; }
        [Key]
        public DbSet<Post> Post { get; set; }
		public DbSet<Comment> Comments { get; set; }
        public DbSet<Session> Sessions { get; set; }
    }
}