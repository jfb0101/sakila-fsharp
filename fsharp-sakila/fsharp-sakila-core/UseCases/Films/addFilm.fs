namespace Sakila.UseCases.Films

open Sakila.DataContext
open Sakila.Models

module AddFilm = 
    let ``$`` (ctx:SakilaContext) (film:Film) =
        ctx.Films.Add(film) |> ignore
        ctx.SaveChanges true |> ignore  