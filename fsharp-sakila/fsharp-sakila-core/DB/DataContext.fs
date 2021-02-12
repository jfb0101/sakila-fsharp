namespace Sakila

open Microsoft.EntityFrameworkCore
open Sakila.Models

module DataContext = 
    type SakilaContext(options: DbContextOptions<SakilaContext>) =
        inherit DbContext(options)

        [<DefaultValue>]
        val mutable Films: DbSet<Film>
        member public this._Films   with get() = this.Films
                                    and set value = this.Films <- value

                                        