using GameStore.Models;

namespace GameStore.Clients;

public class GenreClient
{
    private readonly Genre[] genres =
    [
        new(){
            Id=1,
            Name="kids"
        },
        new(){
            Id=2,
            Name="Horror"
        },
        new(){
            Id=3,
            Name="Adventure"
        }
           ];

    public Genre[] GetGenres() => genres;
}