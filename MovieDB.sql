﻿
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

DROP TABLE [dbo].[Movie];


GO
CREATE TABLE [dbo].[Movie] (
    [Id]                INT        NOT NULL PRIMARY KEY,
    [Title]             NCHAR (50) NOT NULL,
    [Year]              INT        NOT NULL,
    [RunningTimeInMins] INT        NOT NULL,
    [StudioId]          INT        NOT NULL
);

DROP TABLE [dbo].[Studio];


GO
CREATE TABLE [dbo].[Studio] (
    [Id]            INT        NOT NULL PRIMARY KEY,
    [Name]          NCHAR (50) NOT NULL,
    [HQCity]        NCHAR (30) NOT NULL,
    [NoOfEmployees] INT        NOT NULL
);

INSERT INTO [dbo].[Movie] ([Id], [Title], [Year], [RunningTimeInMins], [StudioId]) VALUES (1, N'Se7en                                             ', 1995, 127, 1)
INSERT INTO [dbo].[Movie] ([Id], [Title], [Year], [RunningTimeInMins], [StudioId]) VALUES (2, N'Alien                                             ', 1979, 117, 2)
INSERT INTO [dbo].[Movie] ([Id], [Title], [Year], [RunningTimeInMins], [StudioId]) VALUES (3, N'Forrest Gump                                      ', 1994, 142, 3)
INSERT INTO [dbo].[Movie] ([Id], [Title], [Year], [RunningTimeInMins], [StudioId]) VALUES (4, N'True Grit                                         ', 2010, 110, 3)
INSERT INTO [dbo].[Movie] ([Id], [Title], [Year], [RunningTimeInMins], [StudioId]) VALUES (5, N'Dark City                                         ', 1998, 111, 1)
INSERT INTO [dbo].[Movie] ([Id], [Title], [Year], [RunningTimeInMins], [StudioId]) VALUES (6, N'Terminator                                        ', 1984, 102, 3)
INSERT INTO [dbo].[Movie] ([Id], [Title], [Year], [RunningTimeInMins], [StudioId]) VALUES (7, N'Home Alone                                        ', 1990, 105, 3)

INSERT INTO [dbo].[Studio] ([Id], [Name], [HQCity], [NoOfEmployees]) VALUES (1, N'New Line Cinema                                   ', N'Boston                        ', 4000)
INSERT INTO [dbo].[Studio] ([Id], [Name], [HQCity], [NoOfEmployees]) VALUES (2, N'20th Century Fox                                  ', N'New York                      ', 2500)
INSERT INTO [dbo].[Studio] ([Id], [Name], [HQCity], [NoOfEmployees]) VALUES (3, N'Paramount Pictures                                ', N'New York                      ', 8000)
