module Foo

open Sakila.UseCases
open Xunit
open Microsoft.EntityFrameworkCore
open System
open Sakila.DataContext

[<Fact>]
let testListFilms () =
    let optionsBuilder = new DbContextOptionsBuilder<SakilaContext>()
    let ctxOptions = optionsBuilder.UseInMemoryDatabase("Sakila").Options
    let ctx = new SakilaContext(ctxOptions)
    let list = ListFilms.execute ctx 0
    Assert.True(list.Count = 1 )
        
        


