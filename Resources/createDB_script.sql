CREATE TABLE [dbo].[Artists] (
    [Id]        INT             IDENTITY (1, 1) NOT NULL,
    [Name]      NVARCHAR (1000) NOT NULL,
    [About]     NVARCHAR (4000) NULL,
    [ProfileId] NVARCHAR (MAX)  NULL,
    CONSTRAINT [PK_Artists] PRIMARY KEY CLUSTERED ([Id] ASC)
);


CREATE TABLE [dbo].[Artworks] (
    [Id]          INT             IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (1000) DEFAULT (N'') NOT NULL,
    [Description] NVARCHAR (4000) NULL,
    [Hyperlink]   NVARCHAR (1000) DEFAULT (N'') NOT NULL,
    CONSTRAINT [PK_Artworks] PRIMARY KEY CLUSTERED ([Id] ASC)
);



CREATE TABLE [dbo].[Collections] (
    [Id]          INT             IDENTITY (1, 1) NOT NULL,
    [Description] NVARCHAR (MAX)  NULL,
    [Name]        NVARCHAR (1000) DEFAULT (N'') NOT NULL,
    [ArtistId]    INT             NULL,
    CONSTRAINT [PK_Collections] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Collections_Artists_ArtistId] FOREIGN KEY ([ArtistId]) REFERENCES [dbo].[Artists] ([Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_Collections_ArtistId]
    ON [dbo].[Collections]([ArtistId] ASC);






CREATE TABLE [dbo].[ArtworkCollection] (
    [ArtworksId]    INT NOT NULL,
    [CollectionsId] INT NOT NULL,
    CONSTRAINT [PK_ArtworkCollection] PRIMARY KEY CLUSTERED ([ArtworksId] ASC, [CollectionsId] ASC),
    CONSTRAINT [FK_ArtworkCollection_Artworks_ArtworksId] FOREIGN KEY ([ArtworksId]) REFERENCES [dbo].[Artworks] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_ArtworkCollection_Collections_CollectionsId] FOREIGN KEY ([CollectionsId]) REFERENCES [dbo].[Collections] ([Id]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_ArtworkCollection_CollectionsId]
    ON [dbo].[ArtworkCollection]([CollectionsId] ASC);



CREATE TABLE [dbo].[Tags] (
    [Id]    INT           IDENTITY (1, 1) NOT NULL,
    [Title] NVARCHAR (50) DEFAULT (N'') NOT NULL,
    CONSTRAINT [PK_Tags] PRIMARY KEY CLUSTERED ([Id] ASC)
);



CREATE TABLE [dbo].[CollectionTag] (
    [CollectionsId] INT NOT NULL,
    [TagsId]        INT NOT NULL,
    CONSTRAINT [PK_CollectionTag] PRIMARY KEY CLUSTERED ([CollectionsId] ASC, [TagsId] ASC),
    CONSTRAINT [FK_CollectionTag_Collections_CollectionsId] FOREIGN KEY ([CollectionsId]) REFERENCES [dbo].[Collections] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_CollectionTag_Tags_TagsId] FOREIGN KEY ([TagsId]) REFERENCES [dbo].[Tags] ([Id]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_CollectionTag_TagsId]
    ON [dbo].[CollectionTag]([TagsId] ASC);




