IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20190810070529_user', N'2.1.11-servicing-32099');

GO

CREATE TABLE [User] (
    [Id] int NOT NULL IDENTITY,
    [UserGuid] uniqueidentifier NOT NULL,
    [UserName] nvarchar(1000) NULL,
    [Email] nvarchar(1000) NULL,
    [Description] nvarchar(1000) NULL,
    [Age] int NOT NULL,
    CONSTRAINT [PK_User] PRIMARY KEY ([Id])
);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20190810072509_updateUser', N'2.1.11-servicing-32099');

GO

