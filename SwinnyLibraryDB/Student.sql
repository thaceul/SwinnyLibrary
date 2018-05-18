CREATE TABLE [dbo].[Student]
(
	[ID] NCHAR(9) NOT NULL PRIMARY KEY, 
    [FirstName] TEXT NOT NULL, 
    [LastName] TEXT NOT NULL, 
    [Email] TEXT NULL, 
    [Mobile] NCHAR(12) NULL
)
