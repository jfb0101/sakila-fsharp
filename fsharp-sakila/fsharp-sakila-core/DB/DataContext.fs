namespace Sakila

open Microsoft.EntityFrameworkCore
open Sakila.Models

module DataContext = 
    type SakilaContext(options: DbContextOptions<SakilaContext>) =
        inherit DbContext(options)

        [<DefaultValue>]
        val mutable _Films: DbSet<Film>
        member public this.Films   with get() = this._Films
                                    and set value = this._Films <- value

                                        