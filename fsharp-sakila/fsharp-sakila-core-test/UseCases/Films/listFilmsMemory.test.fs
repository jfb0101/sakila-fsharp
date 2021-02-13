namespace Sakila.UseCases.Films.Memory.Test

open Sakila.UseCases.Films
open Xunit
open Microsoft.EntityFrameworkCore
open Sakila.DataContext

module Common =
    let ctx = new SakilaContext((new DbContextOptionsBuilder<SakilaContext>()).UseInMemoryDatabase("Sakila").Options)

module ListFilmsTest =
    // [<Fact>]
    let test () =
        let ctx = Common.ctx
        Assert.True((ListFilms.``$`` ctx 0).Count = 0 )
        
module AddAndListFilmsTest =
    // [<Fact>]
    let test () =
        let ctx = Common.ctx

        AddFilm.``$`` ctx {Id = 1; Title = "Film 1"} |> ignore
        
        let films = ListFilms.``$`` ctx 0

        Assert.Equal(1,films.Count)

    