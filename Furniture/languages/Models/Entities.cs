using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace languages.Models
{
	public class Entities:IdentityDbContext<ApplicationUser>
	{
		public Entities() : base()
		{

		}
		public Entities(DbContextOptions options) : base(options)
		{

		}

		public DbSet<furniture> furnitures { get; set; }


		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=db5079.public.databaseasp.net; Database=db5079; User Id=db5079; Password=C-i4m5?J3Dh#; Encrypt=False; MultipleActiveResultSets=True;");
			base.OnConfiguring(optionsBuilder);
		}
	}
}
