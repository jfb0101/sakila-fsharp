namespace Sakila.UseCases.Test

open Xunit
open System
open Sakila.UseCases
open Sakila.Models

module Films =

    [<Fact>]
    let ``test`` () =
        Assert.True(Films.listFilms.Length = 2)