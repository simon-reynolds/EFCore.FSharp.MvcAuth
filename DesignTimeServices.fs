namespace EFCore.FSharp.AuthMvc

open Microsoft.Extensions.DependencyInjection
open Microsoft.EntityFrameworkCore.Design
open EntityFrameworkCore.FSharp

type DesignTimeServices() =
    interface IDesignTimeServices with 
        member __.ConfigureDesignTimeServices(serviceCollection: IServiceCollection) = 
            let fSharpServices= EFCoreFSharpServices.Default
            fSharpServices.ConfigureDesignTimeServices serviceCollection
            ()
