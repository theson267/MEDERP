SET NOCOUNT ON
GO
USE [KPI_TMP]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[KPI_NS_KPI_U_ITEM_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[KPI_NS_KPI_U_ITEM_Insert]
GO
CREATE PROCEDURE [dbo].[KPI_NS_KPI_U_ITEM_Insert]
	@ItemID int output,
	@Name nvarchar(200) = null ,
	@Alias nvarchar(200) = null ,
	@Item_Title nvarchar(200) = null ,
	@Form_Namespace nvarchar(200) = null ,
	@IsFunction bit = null ,
	@IsDialog bit = null ,
	@Activate bit = null ,
	@ParrentId int = null ,
	@Type nvarchar(50) = null ,
	@XML_File nvarchar(100) = null ,
	@Note nvarchar(200) = null ,
	@Order int = null 

AS

INSERT [dbo].[NS_KPI_U_ITEM]
(
	[Name],
	[Alias],
	[Item_Title],
	[Form_Namespace],
	[IsFunction],
	[IsDialog],
	[Activate],
	[ParrentId],
	[Type],
	[XML_File],
	[Note],
	[Order]

)
VALUES
(
	@Name,
	@Alias,
	@Item_Title,
	@Form_Namespace,
	@IsFunction,
	@IsDialog,
	@Activate,
	@ParrentId,
	@Type,
	@XML_File,
	@Note,
	@Order

)
	SELECT @ItemID=SCOPE_IDENTITY();


GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[KPI_NS_KPI_U_ITEM_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[KPI_NS_KPI_U_ITEM_Update]
GO
CREATE PROCEDURE [dbo].[KPI_NS_KPI_U_ITEM_Update]
	@ItemID int,
	@Name nvarchar(200) = null,
	@Alias nvarchar(200) = null,
	@Item_Title nvarchar(200) = null,
	@Form_Namespace nvarchar(200) = null,
	@IsFunction bit = null,
	@IsDialog bit = null,
	@Activate bit = null,
	@ParrentId int = null,
	@Type nvarchar(50) = null,
	@XML_File nvarchar(100) = null,
	@Note nvarchar(200) = null,
	@Order int = null

AS

UPDATE [dbo].[NS_KPI_U_ITEM]
SET
	[Name] = @Name,
	[Alias] = @Alias,
	[Item_Title] = @Item_Title,
	[Form_Namespace] = @Form_Namespace,
	[IsFunction] = @IsFunction,
	[IsDialog] = @IsDialog,
	[Activate] = @Activate,
	[ParrentId] = @ParrentId,
	[Type] = @Type,
	[XML_File] = @XML_File,
	[Note] = @Note,
	[Order] = @Order
 WHERE 
	[ItemID] = @ItemID

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[KPI_NS_KPI_U_ITEM_SelectByPrimaryKey]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[KPI_NS_KPI_U_ITEM_SelectByPrimaryKey]
GO
CREATE PROCEDURE [dbo].[KPI_NS_KPI_U_ITEM_SelectByPrimaryKey]
	@ItemID int
AS

	SELECT 
		[ItemID], [Name], [Alias], [Item_Title], [Form_Namespace], [IsFunction], [IsDialog], [Activate], [ParrentId], [Type], [XML_File], [Note], [Order]
	FROM [dbo].[NS_KPI_U_ITEM]
	WHERE 
			[ItemID] = @ItemID

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[KPI_NS_KPI_U_ITEM_SelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[KPI_NS_KPI_U_ITEM_SelectAll]
GO
CREATE PROCEDURE [dbo].[KPI_NS_KPI_U_ITEM_SelectAll]
AS

	SELECT 
		[ItemID], [Name], [Alias], [Item_Title], [Form_Namespace], [IsFunction], [IsDialog], [Activate], [ParrentId], [Type], [XML_File], [Note], [Order]
	FROM [dbo].[NS_KPI_U_ITEM]

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[KPI_NS_KPI_U_ITEM_SelectByField]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[KPI_NS_KPI_U_ITEM_SelectByField]
GO
CREATE PROCEDURE [dbo].[KPI_NS_KPI_U_ITEM_SelectByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'SELECT [ItemID], [Name], [Alias], [Item_Title], [Form_Namespace], [IsFunction], [IsDialog], [Activate], [ParrentId], [Type], [XML_File], [Note], [Order] FROM [dbo].[NS_KPI_U_ITEM] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[KPI_NS_KPI_U_ITEM_DeleteByPrimaryKey]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[KPI_NS_KPI_U_ITEM_DeleteByPrimaryKey]
GO
CREATE PROCEDURE [dbo].[KPI_NS_KPI_U_ITEM_DeleteByPrimaryKey]
	@ItemID int
AS

DELETE FROM [dbo].[NS_KPI_U_ITEM]
 WHERE 
	[ItemID] = @ItemID

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[KPI_NS_KPI_U_ITEM_DeleteByField]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[KPI_NS_KPI_U_ITEM_DeleteByField]
GO
CREATE PROCEDURE [dbo].[KPI_NS_KPI_U_ITEM_DeleteByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[NS_KPI_U_ITEM] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[KPI_NS_KPI_U_ROLE_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[KPI_NS_KPI_U_ROLE_Insert]
GO
CREATE PROCEDURE [dbo].[KPI_NS_KPI_U_ROLE_Insert]
	@RoleID int output,
	@Name nvarchar(200) = null ,
	@Note nvarchar(255) = null 

AS

INSERT [dbo].[NS_KPI_U_ROLE]
(
	[Name],
	[Note]

)
VALUES
(
	@Name,
	@Note

)
	SELECT @RoleID=SCOPE_IDENTITY();


GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[KPI_NS_KPI_U_ROLE_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[KPI_NS_KPI_U_ROLE_Update]
GO
CREATE PROCEDURE [dbo].[KPI_NS_KPI_U_ROLE_Update]
	@RoleID int,
	@Name nvarchar(200) = null,
	@Note nvarchar(255) = null

AS

UPDATE [dbo].[NS_KPI_U_ROLE]
SET
	[Name] = @Name,
	[Note] = @Note
 WHERE 
	[RoleID] = @RoleID

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[KPI_NS_KPI_U_ROLE_SelectByPrimaryKey]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[KPI_NS_KPI_U_ROLE_SelectByPrimaryKey]
GO
CREATE PROCEDURE [dbo].[KPI_NS_KPI_U_ROLE_SelectByPrimaryKey]
	@RoleID int
AS

	SELECT 
		[RoleID], [Name], [Note]
	FROM [dbo].[NS_KPI_U_ROLE]
	WHERE 
			[RoleID] = @RoleID

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[KPI_NS_KPI_U_ROLE_SelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[KPI_NS_KPI_U_ROLE_SelectAll]
GO
CREATE PROCEDURE [dbo].[KPI_NS_KPI_U_ROLE_SelectAll]
AS

	SELECT 
		[RoleID], [Name], [Note]
	FROM [dbo].[NS_KPI_U_ROLE]

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[KPI_NS_KPI_U_ROLE_SelectByField]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[KPI_NS_KPI_U_ROLE_SelectByField]
GO
CREATE PROCEDURE [dbo].[KPI_NS_KPI_U_ROLE_SelectByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'SELECT [RoleID], [Name], [Note] FROM [dbo].[NS_KPI_U_ROLE] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[KPI_NS_KPI_U_ROLE_DeleteByPrimaryKey]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[KPI_NS_KPI_U_ROLE_DeleteByPrimaryKey]
GO
CREATE PROCEDURE [dbo].[KPI_NS_KPI_U_ROLE_DeleteByPrimaryKey]
	@RoleID int
AS

DELETE FROM [dbo].[NS_KPI_U_ROLE]
 WHERE 
	[RoleID] = @RoleID

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[KPI_NS_KPI_U_ROLE_DeleteByField]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[KPI_NS_KPI_U_ROLE_DeleteByField]
GO
CREATE PROCEDURE [dbo].[KPI_NS_KPI_U_ROLE_DeleteByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[NS_KPI_U_ROLE] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[KPI_NS_KPI_U_ROLEITEM_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[KPI_NS_KPI_U_ROLEITEM_Insert]
GO
CREATE PROCEDURE [dbo].[KPI_NS_KPI_U_ROLEITEM_Insert]
	@ItemID int ,
	@RoleID int ,
	@IsReadonly bit = null ,
	@IsFullControl bit = null 

AS

INSERT [dbo].[NS_KPI_U_ROLEITEM]
(
	[ItemID],
	[RoleID],
	[IsReadonly],
	[IsFullControl]

)
VALUES
(
	@ItemID,
	@RoleID,
	@IsReadonly,
	@IsFullControl

)


GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[KPI_NS_KPI_U_ROLEITEM_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[KPI_NS_KPI_U_ROLEITEM_Update]
GO
CREATE PROCEDURE [dbo].[KPI_NS_KPI_U_ROLEITEM_Update]
	@ItemID int,
	@RoleID int,
	@IsReadonly bit = null,
	@IsFullControl bit = null

AS

UPDATE [dbo].[NS_KPI_U_ROLEITEM]
SET
	[ItemID] = @ItemID,
	[RoleID] = @RoleID,
	[IsReadonly] = @IsReadonly,
	[IsFullControl] = @IsFullControl
 WHERE 
	[ItemID] = @ItemID AND 
	[RoleID] = @RoleID

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[KPI_NS_KPI_U_ROLEITEM_SelectByPrimaryKey]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[KPI_NS_KPI_U_ROLEITEM_SelectByPrimaryKey]
GO
CREATE PROCEDURE [dbo].[KPI_NS_KPI_U_ROLEITEM_SelectByPrimaryKey]
	@ItemID int,
	@RoleID int
AS

	SELECT 
		[ItemID], [RoleID], [IsReadonly], [IsFullControl]
	FROM [dbo].[NS_KPI_U_ROLEITEM]
	WHERE 
			[ItemID] = @ItemID AND 
	[RoleID] = @RoleID

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[KPI_NS_KPI_U_ROLEITEM_SelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[KPI_NS_KPI_U_ROLEITEM_SelectAll]
GO
CREATE PROCEDURE [dbo].[KPI_NS_KPI_U_ROLEITEM_SelectAll]
AS

	SELECT 
		[ItemID], [RoleID], [IsReadonly], [IsFullControl]
	FROM [dbo].[NS_KPI_U_ROLEITEM]

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[KPI_NS_KPI_U_ROLEITEM_SelectByField]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[KPI_NS_KPI_U_ROLEITEM_SelectByField]
GO
CREATE PROCEDURE [dbo].[KPI_NS_KPI_U_ROLEITEM_SelectByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'SELECT [ItemID], [RoleID], [IsReadonly], [IsFullControl] FROM [dbo].[NS_KPI_U_ROLEITEM] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[KPI_NS_KPI_U_ROLEITEM_DeleteByPrimaryKey]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[KPI_NS_KPI_U_ROLEITEM_DeleteByPrimaryKey]
GO
CREATE PROCEDURE [dbo].[KPI_NS_KPI_U_ROLEITEM_DeleteByPrimaryKey]
	@ItemID int,
	@RoleID int
AS

DELETE FROM [dbo].[NS_KPI_U_ROLEITEM]
 WHERE 
	[ItemID] = @ItemID AND 
	[RoleID] = @RoleID

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[KPI_NS_KPI_U_ROLEITEM_DeleteByField]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[KPI_NS_KPI_U_ROLEITEM_DeleteByField]
GO
CREATE PROCEDURE [dbo].[KPI_NS_KPI_U_ROLEITEM_DeleteByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[NS_KPI_U_ROLEITEM] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[KPI_NS_KPI_U_USER_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[KPI_NS_KPI_U_USER_Insert]
GO
CREATE PROCEDURE [dbo].[KPI_NS_KPI_U_USER_Insert]
	@UserID int output,
	@UserName varchar(50) ,
	@Password nvarchar(30) = null ,
	@FullName nvarchar(150) = null ,
	@Act bit = null ,
	@Note nvarchar(255) = null 

AS

INSERT [dbo].[NS_KPI_U_USER]
(
	[UserName],
	[Password],
	[FullName],
	[Act],
	[Note]

)
VALUES
(
	@UserName,
	@Password,
	@FullName,
	@Act,
	@Note

)
	SELECT @UserID=SCOPE_IDENTITY();


GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[KPI_NS_KPI_U_USER_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[KPI_NS_KPI_U_USER_Update]
GO
CREATE PROCEDURE [dbo].[KPI_NS_KPI_U_USER_Update]
	@UserID int,
	@UserName varchar(50),
	@Password nvarchar(30) = null,
	@FullName nvarchar(150) = null,
	@Act bit = null,
	@Note nvarchar(255) = null

AS

UPDATE [dbo].[NS_KPI_U_USER]
SET
	[UserName] = @UserName,
	[Password] = @Password,
	[FullName] = @FullName,
	[Act] = @Act,
	[Note] = @Note
 WHERE 
	[UserID] = @UserID

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[KPI_NS_KPI_U_USER_SelectByPrimaryKey]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[KPI_NS_KPI_U_USER_SelectByPrimaryKey]
GO
CREATE PROCEDURE [dbo].[KPI_NS_KPI_U_USER_SelectByPrimaryKey]
	@UserID int
AS

	SELECT 
		[UserID], [UserName], [Password], [FullName], [Act], [Note]
	FROM [dbo].[NS_KPI_U_USER]
	WHERE 
			[UserID] = @UserID

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[KPI_NS_KPI_U_USER_SelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[KPI_NS_KPI_U_USER_SelectAll]
GO
CREATE PROCEDURE [dbo].[KPI_NS_KPI_U_USER_SelectAll]
AS

	SELECT 
		[UserID], [UserName], [Password], [FullName], [Act], [Note]
	FROM [dbo].[NS_KPI_U_USER]

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[KPI_NS_KPI_U_USER_SelectByField]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[KPI_NS_KPI_U_USER_SelectByField]
GO
CREATE PROCEDURE [dbo].[KPI_NS_KPI_U_USER_SelectByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'SELECT [UserID], [UserName], [Password], [FullName], [Act], [Note] FROM [dbo].[NS_KPI_U_USER] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[KPI_NS_KPI_U_USER_DeleteByPrimaryKey]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[KPI_NS_KPI_U_USER_DeleteByPrimaryKey]
GO
CREATE PROCEDURE [dbo].[KPI_NS_KPI_U_USER_DeleteByPrimaryKey]
	@UserID int
AS

DELETE FROM [dbo].[NS_KPI_U_USER]
 WHERE 
	[UserID] = @UserID

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[KPI_NS_KPI_U_USER_DeleteByField]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[KPI_NS_KPI_U_USER_DeleteByField]
GO
CREATE PROCEDURE [dbo].[KPI_NS_KPI_U_USER_DeleteByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[NS_KPI_U_USER] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[KPI_NS_KPI_U_USERROLE_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[KPI_NS_KPI_U_USERROLE_Insert]
GO
CREATE PROCEDURE [dbo].[KPI_NS_KPI_U_USERROLE_Insert]
	@RoleID int ,
	@UserID int 

AS

INSERT [dbo].[NS_KPI_U_USERROLE]
(
	[RoleID],
	[UserID]

)
VALUES
(
	@RoleID,
	@UserID

)


GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[KPI_NS_KPI_U_USERROLE_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[KPI_NS_KPI_U_USERROLE_Update]
GO
CREATE PROCEDURE [dbo].[KPI_NS_KPI_U_USERROLE_Update]
	@RoleID int,
	@UserID int

AS

UPDATE [dbo].[NS_KPI_U_USERROLE]
SET
	[RoleID] = @RoleID,
	[UserID] = @UserID
 WHERE 
	[RoleID] = @RoleID AND 
	[UserID] = @UserID

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[KPI_NS_KPI_U_USERROLE_SelectByPrimaryKey]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[KPI_NS_KPI_U_USERROLE_SelectByPrimaryKey]
GO
CREATE PROCEDURE [dbo].[KPI_NS_KPI_U_USERROLE_SelectByPrimaryKey]
	@RoleID int,
	@UserID int
AS

	SELECT 
		[RoleID], [UserID]
	FROM [dbo].[NS_KPI_U_USERROLE]
	WHERE 
			[RoleID] = @RoleID AND 
	[UserID] = @UserID

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[KPI_NS_KPI_U_USERROLE_SelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[KPI_NS_KPI_U_USERROLE_SelectAll]
GO
CREATE PROCEDURE [dbo].[KPI_NS_KPI_U_USERROLE_SelectAll]
AS

	SELECT 
		[RoleID], [UserID]
	FROM [dbo].[NS_KPI_U_USERROLE]

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[KPI_NS_KPI_U_USERROLE_SelectByField]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[KPI_NS_KPI_U_USERROLE_SelectByField]
GO
CREATE PROCEDURE [dbo].[KPI_NS_KPI_U_USERROLE_SelectByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'SELECT [RoleID], [UserID] FROM [dbo].[NS_KPI_U_USERROLE] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[KPI_NS_KPI_U_USERROLE_DeleteByPrimaryKey]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[KPI_NS_KPI_U_USERROLE_DeleteByPrimaryKey]
GO
CREATE PROCEDURE [dbo].[KPI_NS_KPI_U_USERROLE_DeleteByPrimaryKey]
	@RoleID int,
	@UserID int
AS

DELETE FROM [dbo].[NS_KPI_U_USERROLE]
 WHERE 
	[RoleID] = @RoleID AND 
	[UserID] = @UserID

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[KPI_NS_KPI_U_USERROLE_DeleteByField]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[KPI_NS_KPI_U_USERROLE_DeleteByField]
GO
CREATE PROCEDURE [dbo].[KPI_NS_KPI_U_USERROLE_DeleteByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[NS_KPI_U_USERROLE] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[KPI_NS_KPI_USERITEM_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[KPI_NS_KPI_USERITEM_Insert]
GO
CREATE PROCEDURE [dbo].[KPI_NS_KPI_USERITEM_Insert]
	@UserID int ,
	@ItemID int ,
	@IsReadOnly bit = null ,
	@IsFullControl bit = null 

AS

INSERT [dbo].[NS_KPI_USERITEM]
(
	[UserID],
	[ItemID],
	[IsReadOnly],
	[IsFullControl]

)
VALUES
(
	@UserID,
	@ItemID,
	@IsReadOnly,
	@IsFullControl

)


GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[KPI_NS_KPI_USERITEM_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[KPI_NS_KPI_USERITEM_Update]
GO
CREATE PROCEDURE [dbo].[KPI_NS_KPI_USERITEM_Update]
	@UserID int,
	@ItemID int,
	@IsReadOnly bit = null,
	@IsFullControl bit = null

AS

UPDATE [dbo].[NS_KPI_USERITEM]
SET
	[UserID] = @UserID,
	[ItemID] = @ItemID,
	[IsReadOnly] = @IsReadOnly,
	[IsFullControl] = @IsFullControl
 WHERE 
	[UserID] = @UserID AND 
	[ItemID] = @ItemID

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[KPI_NS_KPI_USERITEM_SelectByPrimaryKey]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[KPI_NS_KPI_USERITEM_SelectByPrimaryKey]
GO
CREATE PROCEDURE [dbo].[KPI_NS_KPI_USERITEM_SelectByPrimaryKey]
	@UserID int,
	@ItemID int
AS

	SELECT 
		[UserID], [ItemID], [IsReadOnly], [IsFullControl]
	FROM [dbo].[NS_KPI_USERITEM]
	WHERE 
			[UserID] = @UserID AND 
	[ItemID] = @ItemID

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[KPI_NS_KPI_USERITEM_SelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[KPI_NS_KPI_USERITEM_SelectAll]
GO
CREATE PROCEDURE [dbo].[KPI_NS_KPI_USERITEM_SelectAll]
AS

	SELECT 
		[UserID], [ItemID], [IsReadOnly], [IsFullControl]
	FROM [dbo].[NS_KPI_USERITEM]

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[KPI_NS_KPI_USERITEM_SelectByField]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[KPI_NS_KPI_USERITEM_SelectByField]
GO
CREATE PROCEDURE [dbo].[KPI_NS_KPI_USERITEM_SelectByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'SELECT [UserID], [ItemID], [IsReadOnly], [IsFullControl] FROM [dbo].[NS_KPI_USERITEM] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[KPI_NS_KPI_USERITEM_DeleteByPrimaryKey]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[KPI_NS_KPI_USERITEM_DeleteByPrimaryKey]
GO
CREATE PROCEDURE [dbo].[KPI_NS_KPI_USERITEM_DeleteByPrimaryKey]
	@UserID int,
	@ItemID int
AS

DELETE FROM [dbo].[NS_KPI_USERITEM]
 WHERE 
	[UserID] = @UserID AND 
	[ItemID] = @ItemID

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[KPI_NS_KPI_USERITEM_DeleteByField]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[KPI_NS_KPI_USERITEM_DeleteByField]
GO
CREATE PROCEDURE [dbo].[KPI_NS_KPI_USERITEM_DeleteByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[NS_KPI_USERITEM] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)

GO
