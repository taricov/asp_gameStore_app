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

}