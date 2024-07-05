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
    // ArgumentNullException.ThrowIfNull(game);
        GetGenreById(game.GenreId);
        var newGame = new GameSummary
        {
            Id = games.Count + 1,
            Name = game.Name,
            Genre = game.GenreId ?? "",
            Price = game.Price,
            ReleaseDate = game.ReleaseDate,
        };
        games.Add(newGame);

    }


    public void DeleteGame(int id)
    {
        GameSummary game = GetGameSummaryById(id);
        games.Remove(game);
    }

    public GameDetails GetGame(int id)
    {
        GameSummary game = GetGameSummaryById(id);
        var genre = genres.Single(genre=> string.Equals(
            genre.Name, 
            game.Genre,
            StringComparison.OrdinalIgnoreCase));
        return new GameDetails
        {
            Id = game.Id,
            Name = game.Name,
            Price = game.Price,
            ReleaseDate = game.ReleaseDate,
            GenreId = genre.Id.ToString(),

        };
    }




public void UpdateGame(GameDetails updatedGame){
    GameSummary existingGame = GetGameSummaryById(updatedGame.Id);
    var genre = GetGenreById(updatedGame.GenreId);

    existingGame.Name = updatedGame.Name;
    existingGame.Price = updatedGame.Price;
    existingGame.Genre = genre.Name;
    existingGame.ReleaseDate = updatedGame.ReleaseDate;
}


    // Helper functions
        private Genre GetGenreById(string? id)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(id);
        return genres.Single(genre => genre.Id == int.Parse(id));
    }

    private GameSummary GetGameSummaryById(int id)
    {
        GameSummary? game = games.Find(game=> game.Id == id);
        ArgumentNullException.ThrowIfNull(game);
        return game;
    }
}