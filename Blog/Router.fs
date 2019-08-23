module Blog.Router

open Giraffe
open Giraffe.Razor
open Blog.Models


// ---------------------------------
// Web app
// ---------------------------------

let indexRouter = choose [route "/"; route "/index"] 

let webApp : HttpHandler =
    choose [
        GET >=>
            choose [
                indexRouter         >=> razorHtmlView "Index" (Queues.last 5 |> Some) None
                route "/blog"       >=> razorHtmlView "Blog"  (Queues.page 0 |> Some) None
                routef "/blog/%i"   (fun id -> razorHtmlView "Blog" (Queues.page id |> Some) None)
                routef "/page/%i"   (fun id -> razorHtmlView "Page" (Queues.get id) None)

                subRoute "/admin"   (text "Hello")
            ]
        setStatusCode 404 >=> text "Not Found" ]
