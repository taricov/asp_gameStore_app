using System.ComponentModel.DataAnnotations;

namespace GameStore.Models;

public class GameDetails
{
    public int Id { get; set;}
    [Required]
    [StringLength(10)]
    public required string Name { get; set;}
    [Range(10, 100)]
    public decimal Price { get; set;}
    [Required]
    public string? GenreId { get; set;} 
    public DateOnly ReleaseDate { get; set; }    

}