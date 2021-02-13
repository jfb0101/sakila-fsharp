namespace Sakila.Models

open System.ComponentModel.DataAnnotations
open System.ComponentModel.DataAnnotations.Schema

[<CLIMutable>]
[<Table("film")>]
type Film = {
    [<Key>]
    [<Column("film_id")>]
    Id: int;

    [<Column("title")>]
    Title: string
}