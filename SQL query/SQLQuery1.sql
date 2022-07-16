use Module4

select * from dbo.Songs as s
inner join dbo.Artists as a on s.ArtistId = a.Id
inner join dbo.Genres as g on s.GenreId = g.Id

select * from dbo.Songs as s where s.ReleasedDate < (select top 1 a.DateOfBirth from dbo.Artists as a ORDER  by a.DateOfBirth desc)