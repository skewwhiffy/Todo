namespace Todo

open System.Web.Mvc
open System.Web.Http

type HomeController() =
    inherit Controller()

    member this.Index() =
        base.View()

type Todo = { Title:string }

type TodoController() =
    inherit ApiController()

    member this.Get() =
        [{Title="todo"}; {Title="todo2"}]