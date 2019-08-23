module Blog.Admin

open Giraffe

let router : HttpHandler = 
    GET >=> choose [
        route "/" >=> text "Hello"
    ]
