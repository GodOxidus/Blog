module Blog.Models.Queues

open Blog.Models

let last n = 
    query {
        for post in DataBase.posts do
        sortByDescending post.PostDateTime
        take n
    } |> Seq.map Post.fromEntity

let get id = 
    query {
        for post in DataBase.posts do
        where (post.Id = id)
        take 1
    } |> Seq.tryHead |> (Option.map Post.fromEntity)

let page n =
    let pageSize = 12
    query {
        for post in DataBase.posts do
        sortBy post.PostDateTime
        skip (n * pageSize)
        take pageSize
    } |> Seq.map Post.fromEntity
