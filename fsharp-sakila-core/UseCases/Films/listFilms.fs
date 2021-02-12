namespace Sakila.UseCases

open Sakila.Models

module Films =

    let listFilms =
        let film1 : Film = {Id = 1 ; Title = "Film 1"}
        let film2 : Film = {Id = 2; Title = "Film 2"}    

        let films = [film1; film2]

        films

