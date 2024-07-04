namespace GameStore.Models;

public class GameDetails
{
    public int Id { get; set;}
    public required string Name { get; set;}
    public decimal Price { get; set;}
    public string? GenreId { get; set;}
    public DateOnly ReleaseDate { get; set; }    

}