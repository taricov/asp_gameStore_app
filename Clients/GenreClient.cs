using GameStore.Models;

namespace GameStore.Clients;

public class GenreClient
{
    private readonly Genre[] genres =
    [
        new(){
            Id=1,
            Name="Genre1"
        },
        new(){
            Id=2,
            Name="Genre2"
        },
        new(){
            Id=3,
            Name="Genre3"
        },
        new(){
            Id=4,
            Name="Genre4"
        },
        new(){
            Id=5,
            Name="Genre5"
        },
        new(){
            Id=6,
            Name="Genre6"
        },
        new(){
            Id=7,
            Name="Genre7"
        },
    ];

    public Genre[] GetGenres() => genres;
}