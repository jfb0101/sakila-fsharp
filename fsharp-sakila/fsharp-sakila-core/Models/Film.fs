namespace Sakila.Models

open System.ComponentModel.DataAnnotations

[<CLIMutable>]
type Film = {
    Id: int;
    Title: string
}