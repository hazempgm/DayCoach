using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class Article
    {
        [Key]
        public long Id { get; set; } 
    }
}