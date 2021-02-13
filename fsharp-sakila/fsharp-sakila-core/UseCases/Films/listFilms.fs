namespace Sakila.UseCases.Films

open Sakila.Models
open Sakila.DataContext
open System.Linq

module ListFilms =
    let ``$`` (ctx:SakilaContext) limit = 
        ctx.Films.ToList()