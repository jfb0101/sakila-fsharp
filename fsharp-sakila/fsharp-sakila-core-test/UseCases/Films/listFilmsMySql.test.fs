namespace Sakila.UseCases.Films.MySql.Test

open Microsoft.EntityFrameworkCore
open Pomelo.EntityFrameworkCore.MySql.Infrastructure
open Sakila.DataContext
open System
open Xunit
open Sakila.UseCases.Films
open System.Linq
open System.IO

module Common =
    let getCtx () =
        let connectionString = "server=localhost;user=root;password=1q2w3e4r;database=sakila"
        let optionsBuilder = new DbContextOptionsBuilder<SakilaContext>()
        let options = optionsBuilder.UseMySql(connectionString,MySqlServerVersion(Version(5,7))).EnableDetailedErrors().Options
        new SakilaContext(options)
       
    let logToFile (content:string) =
        File.WriteAllText("/tmp/sakila.log", content)

module ListFilmsTest =
    [<Fact>]
    let test () =
        let ctx = Common.getCtx()
        
        // Assert.NotNull(ctx)
        // Assert.Equal(1,ctx)
        let films = ListFilms.``$`` ctx 0
        Assert.Equal(1000,films.Count)

        let titles = films.Select(fun f -> f.Title).Aggregate(fun acc cur -> acc + "," + cur)

        Common.logToFile titles

        printfn "%A" titles

        