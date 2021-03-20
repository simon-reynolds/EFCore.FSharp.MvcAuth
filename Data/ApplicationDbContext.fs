namespace EFCore.FSharp.AuthMvc.Data

open Microsoft.AspNetCore.Identity.EntityFrameworkCore
open Microsoft.EntityFrameworkCore

type ApplicationDbContext(options) =
    inherit IdentityDbContext(options)
    