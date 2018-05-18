CREATE TABLE [dbo].[Book]
(
	[ISBN] NCHAR(17) NOT NULL PRIMARY KEY, 
    [Title] TEXT NOT NULL,
    [Year] DATE NOT NULL, 
    [AuthorID] INT NOT NULL, 
    CONSTRAINT [FK_Book_Author] FOREIGN KEY ([AuthorID]) REFERENCES [Author]([ID])
)
