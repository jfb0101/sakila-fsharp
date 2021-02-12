namespace Sakila.UseCases

open Sakila.Models
open Sakila.DataContext
open System.Linq

module ListFilms =
    let execute (ctx:SakilaContext) limit = 
        ctx._Films.ToList()