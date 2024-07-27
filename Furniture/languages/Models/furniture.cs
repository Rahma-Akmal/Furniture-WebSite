using System.ComponentModel.DataAnnotations;

namespace languages.Models
{
	public class furniture
	{
		[Required]
		public int Id { get; set; }
		[Required]
		[MaxLength(100)]
	
		public string Name { get; set; }
		[Required]
		[RegularExpression (".*\\.(jpg$|png$)",ErrorMessage ="must end with .jpg or .png")]
		public string image { get; set; }
		[Required]

		public string Description { get; set; }

	}
}
