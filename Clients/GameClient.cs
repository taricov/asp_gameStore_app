using System.Security.Cryptography.X509Certificates;
using GameStore.Models;

namespace GameStore.Clients;

public class GameClient
{
    private readonly List<GameSummary> games =
    [
    new(){
        Id=1,
        Name="This is game1",
        Genre="Horror",
        Price= 122,
        ReleaseDate= new DateOnly(1999, 4, 1)
        
    },
    new(){
        Id=2,
        Name="This is game2",
        Genre="kids",
        Price=11,
        ReleaseDate= new DateOnly(2000, 11, 30)
    },
    new(){
        Id=3,
        Name="This is game3",
        Price=40,
        Genre="Adventure",
        ReleaseDate= new DateOnly(2021, 10, 6)
    }
    ];
    
    public GameSummary[] GetGames() => [..games];
    private readonly Genre[] genres = new GenreClient().GetGenres();
    public void AddGame(GameDetails game)
{
    ArgumentException.ThrowIfNullOrWhiteSpace(game.GenreId);
    var genre = genres.Single(genre => genre.Id == int.Parse(game.GenreId));
    var newGame = new GameSummary
    {
        Id = games.Count +1,
        Name = game.Name,
        Genre = game.GenreId,
        Price = game.Price,
        ReleaseDate = game.ReleaseDate,
    };
    games.Add(newGame);

    }
    public GameDetails GetGame(int id)
    {
        GameSummary? game = games.Find(game=> game.Id == id);
        ArgumentNullException.ThrowIfNull(game);
        var genre = genres.Single(genre=> string.Equals(genre.Name, game.Genre));
        return new GameDetails
        {
            Id = game.Id,
            Name = game.Name,
            Price = game.Price,
            ReleaseDate = game.ReleaseDate,
            GenreId = genre.Id.ToString(),

        };
    }
}