CREATE TABLE [dbo].[Table]
(
	[username]   NCHAR (100) NOT NULL,
    [password]   NCHAR (100) NULL,
    [name]       NCHAR (100) NULL,
    [familyName] NCHAR (100) NULL,
    [year]       NCHAR (100) NULL,
    [city]       NCHAR (100) NULL,
    [phone]      NCHAR (100) NULL,
    [email]      NCHAR (100) NULL,
    [gender]     NCHAR (100) NULL,
    [admin]      BIT         NULL,
    PRIMARY KEY CLUSTERED ([username] ASC)
)
