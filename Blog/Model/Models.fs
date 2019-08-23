namespace Blog.Models

open System
open Blog.Models.DataBase

type Post = 
    { Id : int;
      Name : string;
      Content : string;
      Prephrase : string;
      PostDateTime : DateTime }

type IndexModel = { Resent : Post seq }

module Post =
    let fromEntity (entity : DB.dataContext.``dbo.PostsEntity``) = 
        { Id = entity.Id;
          Name = entity.Name;
          Content = entity.Content;
          Prephrase = entity.Prephrase;
          PostDateTime = entity.PostDateTime }
