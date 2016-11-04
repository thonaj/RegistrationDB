﻿/*
 Pre-Deployment Script Template                     
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be executed before the build script.   
 Use SQLCMD syntax to include a file in the pre-deployment script.         
 Example:      :r .\myfile.sql                        
 Use SQLCMD syntax to reference a variable in the pre-deployment script.      
 Example:      :setvar TableName MyTable                     
               SELECT * FROM [$(TableName)]               
--------------------------------------------------------------------------------------
*/
USE [master]
GO

if (DB_ID(N'ToDoAppDB') is not null)
begin
   drop database ToDoAppDB;
end

CREATE DATABASE [ToDoAppDB]
GO

USE [ToDoAppDB]
GO

if (schema_id(N'ToDoApp') is not null)
begin
   drop schema ToDoApp
end