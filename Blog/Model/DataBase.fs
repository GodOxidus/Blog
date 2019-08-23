module Blog.Models.DataBase
open FSharp.Data.Sql

type DB = SqlDataProvider<Common.DatabaseProviderTypes.MSSQLSERVER, Blog.Config.connectionString>
let db = DB.GetDataContext()

let posts = db.Dbo.Posts
