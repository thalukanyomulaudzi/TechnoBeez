
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 10/07/2018 00:35:10
-- Generated from EDMX file: C:\Users\Press Play\Source\Repos\TechnoBeez3\WindowsFormsApplication11\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Mmaswe];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_User_Role_Access_level]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[User_Role] DROP CONSTRAINT [FK_User_Role_Access_level];
GO
IF OBJECT_ID(N'[dbo].[FK_Address_Suburb]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Addresses] DROP CONSTRAINT [FK_Address_Suburb];
GO
IF OBJECT_ID(N'[dbo].[FK_Address_Supplier]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Addresses] DROP CONSTRAINT [FK_Address_Supplier];
GO
IF OBJECT_ID(N'[dbo].[FK_Adress_Adress_Type]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Addresses] DROP CONSTRAINT [FK_Adress_Adress_Type];
GO
IF OBJECT_ID(N'[dbo].[FK_User_Audit]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Users] DROP CONSTRAINT [FK_User_Audit];
GO
IF OBJECT_ID(N'[dbo].[FK_Banking_Details_Supplier]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Banking_Details] DROP CONSTRAINT [FK_Banking_Details_Supplier];
GO
IF OBJECT_ID(N'[dbo].[FK_Check_In_Line_Check_In]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Check_In_Line] DROP CONSTRAINT [FK_Check_In_Line_Check_In];
GO
IF OBJECT_ID(N'[dbo].[FK_Check_In_Line_Stock_Item]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Check_In_Line] DROP CONSTRAINT [FK_Check_In_Line_Stock_Item];
GO
IF OBJECT_ID(N'[dbo].[FK_Check_Out_Line_Check_Out]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Check_Out_Line] DROP CONSTRAINT [FK_Check_Out_Line_Check_Out];
GO
IF OBJECT_ID(N'[dbo].[FK_Check_Out_Line_Stock_Item]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Check_Out_Line] DROP CONSTRAINT [FK_Check_Out_Line_Stock_Item];
GO
IF OBJECT_ID(N'[dbo].[FK_Combo_Combo_Price]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Comboes] DROP CONSTRAINT [FK_Combo_Combo_Price];
GO
IF OBJECT_ID(N'[dbo].[FK_Combo_Combo_Type]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Comboes] DROP CONSTRAINT [FK_Combo_Combo_Type];
GO
IF OBJECT_ID(N'[dbo].[FK_Customer_Order_Line_Combo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Customer_Order_Line] DROP CONSTRAINT [FK_Customer_Order_Line_Combo];
GO
IF OBJECT_ID(N'[dbo].[FK_ItemsPicture_Combo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ItemsPictures] DROP CONSTRAINT [FK_ItemsPicture_Combo];
GO
IF OBJECT_ID(N'[dbo].[FK_Stock_Combo_Line_Combo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Stock_Combo_Line] DROP CONSTRAINT [FK_Stock_Combo_Line_Combo];
GO
IF OBJECT_ID(N'[dbo].[FK_Customer_Order_Customer]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Customer_Order] DROP CONSTRAINT [FK_Customer_Order_Customer];
GO
IF OBJECT_ID(N'[dbo].[FK_Customer_Order_Delivery_Status]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Customer_Order] DROP CONSTRAINT [FK_Customer_Order_Delivery_Status];
GO
IF OBJECT_ID(N'[dbo].[FK_Customer_Order_Employee]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Customer_Order] DROP CONSTRAINT [FK_Customer_Order_Employee];
GO
IF OBJECT_ID(N'[dbo].[FK_Customer_Order_Line_Customer_Order]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Customer_Order_Line] DROP CONSTRAINT [FK_Customer_Order_Line_Customer_Order];
GO
IF OBJECT_ID(N'[dbo].[FK_Customer_Order_Payment]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Customer_Order] DROP CONSTRAINT [FK_Customer_Order_Payment];
GO
IF OBJECT_ID(N'[dbo].[FK_Customer_Order_Line_Menu_Item]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Customer_Order_Line] DROP CONSTRAINT [FK_Customer_Order_Line_Menu_Item];
GO
IF OBJECT_ID(N'[dbo].[FK_Customer_Order_Line_Stock_Item]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Customer_Order_Line] DROP CONSTRAINT [FK_Customer_Order_Line_Stock_Item];
GO
IF OBJECT_ID(N'[dbo].[FK_DeliveryLine_DeliveryTable]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DeliveryLines] DROP CONSTRAINT [FK_DeliveryLine_DeliveryTable];
GO
IF OBJECT_ID(N'[dbo].[FK_Employee_Booking_Shift_Employee]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Employee_Booking_Shift] DROP CONSTRAINT [FK_Employee_Booking_Shift_Employee];
GO
IF OBJECT_ID(N'[dbo].[FK_Employee_Employee_Gender_]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Employees] DROP CONSTRAINT [FK_Employee_Employee_Gender_];
GO
IF OBJECT_ID(N'[dbo].[FK_Employee_User]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Employees] DROP CONSTRAINT [FK_Employee_User];
GO
IF OBJECT_ID(N'[dbo].[FK_Stock_Order_Employee]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Stock_Order] DROP CONSTRAINT [FK_Stock_Order_Employee];
GO
IF OBJECT_ID(N'[dbo].[FK_Employee_Attendence_Status_Employee_Booking_Shift]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Employee_Attendence_Status] DROP CONSTRAINT [FK_Employee_Attendence_Status_Employee_Booking_Shift];
GO
IF OBJECT_ID(N'[dbo].[FK_Employee_Booking_Shift_Employee_Shifts]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Employee_Booking_Shift] DROP CONSTRAINT [FK_Employee_Booking_Shift_Employee_Shifts];
GO
IF OBJECT_ID(N'[dbo].[FK_ItemsPicture_Menu_Item]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ItemsPictures] DROP CONSTRAINT [FK_ItemsPicture_Menu_Item];
GO
IF OBJECT_ID(N'[dbo].[FK_Menu_Item_Menu_Item_Price]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Menu_Item] DROP CONSTRAINT [FK_Menu_Item_Menu_Item_Price];
GO
IF OBJECT_ID(N'[dbo].[FK_Menu_Item_Menu_Item_Type]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Menu_Item] DROP CONSTRAINT [FK_Menu_Item_Menu_Item_Type];
GO
IF OBJECT_ID(N'[dbo].[FK_Payment_Payment_Type]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Payments] DROP CONSTRAINT [FK_Payment_Payment_Type];
GO
IF OBJECT_ID(N'[dbo].[FK_Stock_Combo_Line_Stock_Item]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Stock_Combo_Line] DROP CONSTRAINT [FK_Stock_Combo_Line_Stock_Item];
GO
IF OBJECT_ID(N'[dbo].[FK_Stock_Item_Stock_Price]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Stock_Item] DROP CONSTRAINT [FK_Stock_Item_Stock_Price];
GO
IF OBJECT_ID(N'[dbo].[FK_Stock_Item_Stock_Type]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Stock_Item] DROP CONSTRAINT [FK_Stock_Item_Stock_Type];
GO
IF OBJECT_ID(N'[dbo].[FK_Stock_Order_Line_Stock_Item]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Stock_Order_Line] DROP CONSTRAINT [FK_Stock_Order_Line_Stock_Item];
GO
IF OBJECT_ID(N'[dbo].[FK_Stock_WriteOff_Line_Stock_Item]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Stock_WriteOff_Line] DROP CONSTRAINT [FK_Stock_WriteOff_Line_Stock_Item];
GO
IF OBJECT_ID(N'[dbo].[FK_Stock_Order_Line_Stock_Order]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Stock_Order_Line] DROP CONSTRAINT [FK_Stock_Order_Line_Stock_Order];
GO
IF OBJECT_ID(N'[dbo].[FK_Stock_Order_Stock_Order_Status]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Stock_Order] DROP CONSTRAINT [FK_Stock_Order_Stock_Order_Status];
GO
IF OBJECT_ID(N'[dbo].[FK_Stock_Order_Supplier]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Stock_Order] DROP CONSTRAINT [FK_Stock_Order_Supplier];
GO
IF OBJECT_ID(N'[dbo].[FK_Stock_WriteOff_Line_Stock_Write_Off]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Stock_WriteOff_Line] DROP CONSTRAINT [FK_Stock_WriteOff_Line_Stock_Write_Off];
GO
IF OBJECT_ID(N'[dbo].[FK_Supplier_Contact_Details_Supplier]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Supplier_Contact_Details] DROP CONSTRAINT [FK_Supplier_Contact_Details_Supplier];
GO
IF OBJECT_ID(N'[dbo].[FK_User_Us]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Users] DROP CONSTRAINT [FK_User_Us];
GO
IF OBJECT_ID(N'[dbo].[FK_User_User_Log]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Users] DROP CONSTRAINT [FK_User_User_Log];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Access_level]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Access_level];
GO
IF OBJECT_ID(N'[dbo].[Addresses]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Addresses];
GO
IF OBJECT_ID(N'[dbo].[Adress_Type]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Adress_Type];
GO
IF OBJECT_ID(N'[dbo].[Audits]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Audits];
GO
IF OBJECT_ID(N'[dbo].[Banking_Details]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Banking_Details];
GO
IF OBJECT_ID(N'[dbo].[Check_In]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Check_In];
GO
IF OBJECT_ID(N'[dbo].[Check_In_Line]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Check_In_Line];
GO
IF OBJECT_ID(N'[dbo].[Check_Out]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Check_Out];
GO
IF OBJECT_ID(N'[dbo].[Check_Out_Line]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Check_Out_Line];
GO
IF OBJECT_ID(N'[dbo].[Cities]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Cities];
GO
IF OBJECT_ID(N'[dbo].[Comboes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Comboes];
GO
IF OBJECT_ID(N'[dbo].[Combo_Price]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Combo_Price];
GO
IF OBJECT_ID(N'[dbo].[Combo_Type]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Combo_Type];
GO
IF OBJECT_ID(N'[dbo].[Company_Information]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Company_Information];
GO
IF OBJECT_ID(N'[dbo].[Customers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Customers];
GO
IF OBJECT_ID(N'[dbo].[Customer_Order]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Customer_Order];
GO
IF OBJECT_ID(N'[dbo].[Customer_Order_Line]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Customer_Order_Line];
GO
IF OBJECT_ID(N'[dbo].[Delivery_Status]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Delivery_Status];
GO
IF OBJECT_ID(N'[dbo].[DeliveryLines]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DeliveryLines];
GO
IF OBJECT_ID(N'[dbo].[DeliveryTables]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DeliveryTables];
GO
IF OBJECT_ID(N'[dbo].[Employees]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Employees];
GO
IF OBJECT_ID(N'[dbo].[Employee_Attendence_Status]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Employee_Attendence_Status];
GO
IF OBJECT_ID(N'[dbo].[Employee_Booking_Shift]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Employee_Booking_Shift];
GO
IF OBJECT_ID(N'[dbo].[Employee_Gender_]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Employee_Gender_];
GO
IF OBJECT_ID(N'[dbo].[Employee_Shifts]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Employee_Shifts];
GO
IF OBJECT_ID(N'[dbo].[ItemsPictures]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ItemsPictures];
GO
IF OBJECT_ID(N'[dbo].[Menu_Item]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Menu_Item];
GO
IF OBJECT_ID(N'[dbo].[Menu_Item_Price]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Menu_Item_Price];
GO
IF OBJECT_ID(N'[dbo].[Menu_Item_Type]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Menu_Item_Type];
GO
IF OBJECT_ID(N'[dbo].[Payments]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Payments];
GO
IF OBJECT_ID(N'[dbo].[Payment_Type]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Payment_Type];
GO
IF OBJECT_ID(N'[dbo].[Quantities]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Quantities];
GO
IF OBJECT_ID(N'[dbo].[Specials]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Specials];
GO
IF OBJECT_ID(N'[dbo].[Stock_Combo_Line]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Stock_Combo_Line];
GO
IF OBJECT_ID(N'[dbo].[Stock_Item]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Stock_Item];
GO
IF OBJECT_ID(N'[dbo].[Stock_Order]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Stock_Order];
GO
IF OBJECT_ID(N'[dbo].[Stock_Order_Line]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Stock_Order_Line];
GO
IF OBJECT_ID(N'[dbo].[Stock_Order_Status]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Stock_Order_Status];
GO
IF OBJECT_ID(N'[dbo].[Stock_Price]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Stock_Price];
GO
IF OBJECT_ID(N'[dbo].[Stock_Type]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Stock_Type];
GO
IF OBJECT_ID(N'[dbo].[Stock_Write_Off]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Stock_Write_Off];
GO
IF OBJECT_ID(N'[dbo].[Stock_WriteOff_Line]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Stock_WriteOff_Line];
GO
IF OBJECT_ID(N'[dbo].[Suburbs]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Suburbs];
GO
IF OBJECT_ID(N'[dbo].[Suppliers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Suppliers];
GO
IF OBJECT_ID(N'[dbo].[Supplier_Contact_Details]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Supplier_Contact_Details];
GO
IF OBJECT_ID(N'[dbo].[Supplier_Type]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Supplier_Type];
GO
IF OBJECT_ID(N'[dbo].[Users]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Users];
GO
IF OBJECT_ID(N'[dbo].[User_Log]', 'U') IS NOT NULL
    DROP TABLE [dbo].[User_Log];
GO
IF OBJECT_ID(N'[dbo].[User_Role]', 'U') IS NOT NULL
    DROP TABLE [dbo].[User_Role];
GO
IF OBJECT_ID(N'[dbo].[DeliveryOrders]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DeliveryOrders];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Access_level'
CREATE TABLE [dbo].[Access_level] (
    [Access_Level_ID] int IDENTITY(1,1) NOT NULL,
    [Access_Level_Name] nvarchar(50)  NOT NULL,
    [Acess_Level_Description] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Addresses'
CREATE TABLE [dbo].[Addresses] (
    [Address_ID] int IDENTITY(1,1) NOT NULL,
    [Street_Name] varchar(50)  NOT NULL,
    [Address_Type_ID] int  NULL,
    [House_No] int  NULL,
    [Province] varchar(50)  NULL,
    [City_Name] varchar(50)  NULL,
    [Supplier_ID] int  NULL,
    [Suburb_ID] int  NULL
);
GO

-- Creating table 'Adress_Type'
CREATE TABLE [dbo].[Adress_Type] (
    [Adress_Type_ID] int IDENTITY(1,1) NOT NULL,
    [Adress_Description] varchar(50)  NOT NULL
);
GO

-- Creating table 'Audits'
CREATE TABLE [dbo].[Audits] (
    [Audit_ID] int IDENTITY(1,1) NOT NULL,
    [Audit_Name] varchar(50)  NOT NULL,
    [Audit_Table] varchar(50)  NOT NULL,
    [Audit_Description] varchar(50)  NOT NULL,
    [User_ID] int  NOT NULL,
    [transactionNumber] int  NULL,
    [auditDate] datetime  NULL
);
GO

-- Creating table 'Banking_Details'
CREATE TABLE [dbo].[Banking_Details] (
    [Banking_Details_ID] int IDENTITY(1,1) NOT NULL,
    [Bank_Name] varchar(50)  NOT NULL,
    [Bank_Acc_No] int  NOT NULL,
    [Branch_Code] int  NOT NULL,
    [Supplier_ID] int  NULL
);
GO

-- Creating table 'Check_In'
CREATE TABLE [dbo].[Check_In] (
    [Check_In_ID] int IDENTITY(1,1) NOT NULL,
    [Stock_Item_Name] nchar(10)  NULL,
    [Check_In_Date] datetime  NOT NULL
);
GO

-- Creating table 'Check_In_Line'
CREATE TABLE [dbo].[Check_In_Line] (
    [Check_In_Line_ID] int IDENTITY(1,1) NOT NULL,
    [Quantity] float  NOT NULL,
    [Stock_ID] int  NULL,
    [Check_In_ID] int  NULL,
    [Stock_Item_Name] varchar(50)  NULL
);
GO

-- Creating table 'Check_Out'
CREATE TABLE [dbo].[Check_Out] (
    [Check_Out_ID] int IDENTITY(1,1) NOT NULL,
    [Check_Out_Date] datetime  NOT NULL,
    [Stock_Item_Name] nchar(10)  NULL
);
GO

-- Creating table 'Check_Out_Line'
CREATE TABLE [dbo].[Check_Out_Line] (
    [Check_Out_Line_ID] int IDENTITY(1,1) NOT NULL,
    [Stock_ID] int  NULL,
    [Check_Out_ID] int  NULL,
    [Quaantity] float  NOT NULL,
    [Stock_Item_Name] varchar(50)  NOT NULL
);
GO

-- Creating table 'Cities'
CREATE TABLE [dbo].[Cities] (
    [City_ID] int IDENTITY(1,1) NOT NULL,
    [City_Name] varchar(50)  NOT NULL
);
GO

-- Creating table 'Comboes'
CREATE TABLE [dbo].[Comboes] (
    [Combo_ID] int IDENTITY(1,1) NOT NULL,
    [Combo_Description] varchar(500)  NOT NULL,
    [Combo_Price] float  NOT NULL,
    [Combo_Type_ID] int  NULL,
    [Combo_Price_ID] int  NULL,
    [Combo_Name] varchar(50)  NOT NULL
);
GO

-- Creating table 'Combo_Price'
CREATE TABLE [dbo].[Combo_Price] (
    [Combo_Price_ID] int IDENTITY(1,1) NOT NULL,
    [Combo_Price1] float  NOT NULL,
    [Combo_Price_Date] datetime  NULL
);
GO

-- Creating table 'Combo_Type'
CREATE TABLE [dbo].[Combo_Type] (
    [Combo_Type_ID] int IDENTITY(1,1) NOT NULL,
    [Combo_Description] varchar(50)  NOT NULL
);
GO

-- Creating table 'Company_Information'
CREATE TABLE [dbo].[Company_Information] (
    [Company_Info_ID] int IDENTITY(1,1) NOT NULL,
    [VAT_Percentage] float  NOT NULL,
    [Mark_Up_Percentage] float  NOT NULL,
    [Adress] varchar(50)  NOT NULL
);
GO

-- Creating table 'Customers'
CREATE TABLE [dbo].[Customers] (
    [Customer_ID] int IDENTITY(1,1) NOT NULL,
    [Customer_Name] varchar(50)  NOT NULL,
    [Customer_Surname] varchar(50)  NOT NULL,
    [Customer_Email] varchar(50)  NULL,
    [Customer_Contact_Number] int  NOT NULL,
    [Suburb_ID] int  NOT NULL,
    [Customer_Address] varchar(50)  NOT NULL
);
GO

-- Creating table 'Customer_Order'
CREATE TABLE [dbo].[Customer_Order] (
    [Order_ID] int IDENTITY(1,1) NOT NULL,
    [Order_Status] varchar(900)  NOT NULL,
    [Order_Date] datetime  NOT NULL,
    [Sale_Vat_Amount] float  NOT NULL,
    [Customer_ID] int  NULL,
    [Employee_ID] int  NULL,
    [Delivery_Status_ID] int  NULL,
    [OrderNotes] varchar(900)  NULL,
    [OrderTotal] float  NULL,
    [TotalItems] int  NULL,
    [Cash] float  NULL,
    [Change] float  NULL,
    [Payment_ID] int  NULL
);
GO

-- Creating table 'Customer_Order_Line'
CREATE TABLE [dbo].[Customer_Order_Line] (
    [Combo_ID] int  NULL,
    [Stock_ID] int  NULL,
    [Menu_Item_ID] int  NULL,
    [Combo_Quantity] int  NULL,
    [Menu_Item_Quantity] int  NULL,
    [Stock_Item_Quantity] int  NULL,
    [Customer_Order_Line_ID] int IDENTITY(1,1) NOT NULL,
    [Customer_Order_ID] int  NULL
);
GO

-- Creating table 'Delivery_Status'
CREATE TABLE [dbo].[Delivery_Status] (
    [Delivery_Status_ID] int IDENTITY(1,1) NOT NULL,
    [Delivery_Description] varchar(50)  NOT NULL
);
GO

-- Creating table 'DeliveryLines'
CREATE TABLE [dbo].[DeliveryLines] (
    [LineId] int IDENTITY(1,1) NOT NULL,
    [comboItemId] int  NULL,
    [stockItemId] int  NULL,
    [menuItemId] int  NULL,
    [comboItemQuantity] int  NULL,
    [stockItemQuantity] int  NULL,
    [menuItemQuantity] int  NULL,
    [orderId] int  NULL
);
GO

-- Creating table 'DeliveryTables'
CREATE TABLE [dbo].[DeliveryTables] (
    [OrderId] int IDENTITY(1,1) NOT NULL,
    [ItemName] varchar(50)  NULL,
    [orderTotal] float  NOT NULL,
    [customerName] varchar(50)  NULL,
    [customerContact] int  NULL,
    [orderDatef] datetime  NULL,
    [vatAmountf] float  NULL,
    [orderNotesf] varchar(50)  NULL,
    [totalItemsf] int  NULL,
    [vatTot] float  NULL
);
GO

-- Creating table 'Employees'
CREATE TABLE [dbo].[Employees] (
    [Employee_ID] int IDENTITY(1,1) NOT NULL,
    [Employee_Name] varchar(50)  NOT NULL,
    [Employee_Surname] nvarchar(50)  NOT NULL,
    [Employee_Identity_Number] nvarchar(13)  NOT NULL,
    [Email_Adress] varchar(50)  NOT NULL,
    [Contact_Number] nvarchar(10)  NOT NULL,
    [Next_Of_Kin_Name] varchar(50)  NOT NULL,
    [Next_Of_Kin_Contact_Number] nvarchar(10)  NOT NULL,
    [Adress] varchar(50)  NOT NULL,
    [Gender_ID] int  NULL,
    [User_ID] int  NULL
);
GO

-- Creating table 'Employee_Attendence_Status'
CREATE TABLE [dbo].[Employee_Attendence_Status] (
    [Booking_ID] int  NULL,
    [Attendence_Description] varchar(50)  NOT NULL,
    [Empployee_Attendence_ID] int  NOT NULL
);
GO

-- Creating table 'Employee_Booking_Shift'
CREATE TABLE [dbo].[Employee_Booking_Shift] (
    [Employee_ID] int  NULL,
    [Employee_Shift_ID] int  NULL,
    [Booking_ID] int  NOT NULL
);
GO

-- Creating table 'Employee_Gender_'
CREATE TABLE [dbo].[Employee_Gender_] (
    [Gender_ID] int IDENTITY(1,1) NOT NULL,
    [Gender_Description] varchar(50)  NOT NULL
);
GO

-- Creating table 'Employee_Shifts'
CREATE TABLE [dbo].[Employee_Shifts] (
    [Employee_Shift_ID] int IDENTITY(1,1) NOT NULL,
    [Employee_Shift_Start_Time] varchar(50)  NOT NULL,
    [Employee_Shift_End_Time] varchar(50)  NOT NULL,
    [MaximumCooks] int  NOT NULL,
    [MaximumCashiers] int  NULL,
    [CooksAllocated] int  NULL,
    [CashiersAllocated] int  NULL
);
GO

-- Creating table 'ItemsPictures'
CREATE TABLE [dbo].[ItemsPictures] (
    [ImageID] int IDENTITY(1,1) NOT NULL,
    [imageVar] varbinary(max)  NULL,
    [ItemName] varchar(50)  NOT NULL,
    [Combo_Item_ID] int  NULL,
    [Menu_Item_ID] int  NULL,
    [EmployeeID] int  NULL
);
GO

-- Creating table 'Menu_Item'
CREATE TABLE [dbo].[Menu_Item] (
    [Menu_Item_ID] int IDENTITY(1,1) NOT NULL,
    [Menu_Item_Name] varchar(50)  NOT NULL,
    [Menu_Item_Description] varchar(50)  NOT NULL,
    [Menu_Item_Price] float  NOT NULL,
    [Menu_Item_Type_ID] int  NULL,
    [Menu_Price_ID] int  NULL
);
GO

-- Creating table 'Menu_Item_Price'
CREATE TABLE [dbo].[Menu_Item_Price] (
    [Menu_Price_ID] int IDENTITY(1,1) NOT NULL,
    [Menu_Price] float  NOT NULL,
    [Date] datetime  NULL
);
GO

-- Creating table 'Menu_Item_Type'
CREATE TABLE [dbo].[Menu_Item_Type] (
    [Menu_Item_Type_ID] int IDENTITY(1,1) NOT NULL,
    [Menu_Item_Description] varchar(50)  NOT NULL
);
GO

-- Creating table 'Payments'
CREATE TABLE [dbo].[Payments] (
    [Payment_ID] int IDENTITY(1,1) NOT NULL,
    [Payment_Date] datetime  NULL,
    [Payment_Amount] float  NULL,
    [Payment_Type_ID] int  NULL
);
GO

-- Creating table 'Payment_Type'
CREATE TABLE [dbo].[Payment_Type] (
    [Payment_Type_ID] int IDENTITY(1,1) NOT NULL,
    [Payment_Description] varchar(50)  NOT NULL
);
GO

-- Creating table 'Quantities'
CREATE TABLE [dbo].[Quantities] (
    [Check_In_Line_ID] int IDENTITY(1,1) NOT NULL,
    [Stock_ID] int  NULL,
    [Check_In_ID] int  NULL
);
GO

-- Creating table 'Specials'
CREATE TABLE [dbo].[Specials] (
    [Special_ID] int IDENTITY(1,1) NOT NULL,
    [Special_Description] varchar(50)  NOT NULL,
    [Special_Start_Date] datetime  NOT NULL,
    [Special_End_Date] datetime  NOT NULL,
    [Special_Discount] float  NOT NULL
);
GO

-- Creating table 'Stock_Combo_Line'
CREATE TABLE [dbo].[Stock_Combo_Line] (
    [Stock_ID] int  NULL,
    [Combo_ID] int  NULL,
    [Stock_Item_Name] varchar(50)  NOT NULL,
    [Stock_Item_Quantity] int  NOT NULL,
    [Stock_Combo_Line_ID] int IDENTITY(1,1) NOT NULL
);
GO

-- Creating table 'Stock_Item'
CREATE TABLE [dbo].[Stock_Item] (
    [Stock_ID] int IDENTITY(1,1) NOT NULL,
    [Stock_Item_Name] varchar(50)  NOT NULL,
    [Stock_Item_Quantity] int  NOT NULL,
    [Stock_Item_Description] varchar(50)  NOT NULL,
    [Stock_Type_ID] int  NULL,
    [Stock_Price_ID] int  NULL
);
GO

-- Creating table 'Stock_Order'
CREATE TABLE [dbo].[Stock_Order] (
    [Stock_Order_ID] int IDENTITY(1,1) NOT NULL,
    [Stock_Order_Description] varchar(50)  NOT NULL,
    [Stock_Order_Issue_Date] datetime  NOT NULL,
    [Employee_ID] int  NULL,
    [Stock_Order_Status_ID] int  NULL,
    [Supplier_ID] int  NULL
);
GO

-- Creating table 'Stock_Order_Line'
CREATE TABLE [dbo].[Stock_Order_Line] (
    [Stock_ID] int  NULL,
    [Stock_Order_ID] int  NULL,
    [Stock_Order_Quantity] int  NOT NULL,
    [Quantity_Received] int  NOT NULL,
    [Stock_Order_Line_ID] int IDENTITY(1,1) NOT NULL
);
GO

-- Creating table 'Stock_Order_Status'
CREATE TABLE [dbo].[Stock_Order_Status] (
    [Stock_Order_Status_ID] int IDENTITY(1,1) NOT NULL,
    [Stock_Order_Status_Description] varchar(50)  NOT NULL
);
GO

-- Creating table 'Stock_Price'
CREATE TABLE [dbo].[Stock_Price] (
    [Stock_Price_ID] int IDENTITY(1,1) NOT NULL,
    [Stock_Price1] float  NOT NULL,
    [Stock_Price_Date] datetime  NULL
);
GO

-- Creating table 'Stock_Type'
CREATE TABLE [dbo].[Stock_Type] (
    [Stock_Type_ID] int IDENTITY(1,1) NOT NULL,
    [Stock_Type_Description] varchar(25)  NOT NULL
);
GO

-- Creating table 'Stock_Write_Off'
CREATE TABLE [dbo].[Stock_Write_Off] (
    [Write_Off_ID] int IDENTITY(1,1) NOT NULL,
    [WriteOff_Stock_Name] varchar(50)  NOT NULL,
    [Stock_WriteOff_Quantity] int  NOT NULL,
    [Employee_ID] nchar(10)  NULL,
    [WriteOff_Reason] varchar(50)  NOT NULL,
    [WriteOffDate] datetime  NOT NULL
);
GO

-- Creating table 'Stock_WriteOff_Line'
CREATE TABLE [dbo].[Stock_WriteOff_Line] (
    [Stock_WriteOff_LineID] int IDENTITY(1,1) NOT NULL,
    [Quantity] float  NOT NULL,
    [Stock_ID] int  NULL,
    [Write_Off_ID] int  NULL,
    [Stock_Item_Name] varchar(50)  NOT NULL
);
GO

-- Creating table 'Suburbs'
CREATE TABLE [dbo].[Suburbs] (
    [Suburb_ID] int IDENTITY(1,1) NOT NULL,
    [Suburb_Name] varchar(50)  NOT NULL,
    [Zip_Code] varchar(50)  NOT NULL
);
GO

-- Creating table 'Suppliers'
CREATE TABLE [dbo].[Suppliers] (
    [Supplier_ID] int IDENTITY(1,1) NOT NULL,
    [Supplier_Name] varchar(50)  NOT NULL,
    [Supplier_Type_ID] int  NULL
);
GO

-- Creating table 'Supplier_Contact_Details'
CREATE TABLE [dbo].[Supplier_Contact_Details] (
    [Supplier_Contact_ID] int IDENTITY(1,1) NOT NULL,
    [Supplier_Contact_Name] varchar(50)  NOT NULL,
    [Supplier_Contact_Number] int  NOT NULL,
    [Supplier_Email_Adress] varchar(50)  NOT NULL,
    [Supplier_ID] int  NULL
);
GO

-- Creating table 'Supplier_Type'
CREATE TABLE [dbo].[Supplier_Type] (
    [Supplier_Type_ID] int IDENTITY(1,1) NOT NULL,
    [Supplier_Type_Description] varchar(50)  NOT NULL
);
GO

-- Creating table 'Users'
CREATE TABLE [dbo].[Users] (
    [User_ID] int IDENTITY(1,1) NOT NULL,
    [UserName] varchar(50)  NOT NULL,
    [User_Password] varchar(50)  NOT NULL,
    [User_Role_ID] int  NULL,
    [Audit_ID] int  NULL,
    [User_Log_ID] int  NULL
);
GO

-- Creating table 'User_Log'
CREATE TABLE [dbo].[User_Log] (
    [User_Log_ID] int IDENTITY(1,1) NOT NULL,
    [Login_Time] datetime  NOT NULL,
    [Logout_Time] datetime  NOT NULL,
    [User_ID] int  NOT NULL
);
GO

-- Creating table 'User_Role'
CREATE TABLE [dbo].[User_Role] (
    [User_Role_ID] int IDENTITY(1,1) NOT NULL,
    [User_Role_Description] varchar(50)  NOT NULL,
    [Access_Level_ID] int  NULL
);
GO

-- Creating table 'DeliveryOrders'
CREATE TABLE [dbo].[DeliveryOrders] (
    [OrderId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Access_Level_ID] in table 'Access_level'
ALTER TABLE [dbo].[Access_level]
ADD CONSTRAINT [PK_Access_level]
    PRIMARY KEY CLUSTERED ([Access_Level_ID] ASC);
GO

-- Creating primary key on [Address_ID] in table 'Addresses'
ALTER TABLE [dbo].[Addresses]
ADD CONSTRAINT [PK_Addresses]
    PRIMARY KEY CLUSTERED ([Address_ID] ASC);
GO

-- Creating primary key on [Adress_Type_ID] in table 'Adress_Type'
ALTER TABLE [dbo].[Adress_Type]
ADD CONSTRAINT [PK_Adress_Type]
    PRIMARY KEY CLUSTERED ([Adress_Type_ID] ASC);
GO

-- Creating primary key on [Audit_ID] in table 'Audits'
ALTER TABLE [dbo].[Audits]
ADD CONSTRAINT [PK_Audits]
    PRIMARY KEY CLUSTERED ([Audit_ID] ASC);
GO

-- Creating primary key on [Banking_Details_ID] in table 'Banking_Details'
ALTER TABLE [dbo].[Banking_Details]
ADD CONSTRAINT [PK_Banking_Details]
    PRIMARY KEY CLUSTERED ([Banking_Details_ID] ASC);
GO

-- Creating primary key on [Check_In_ID] in table 'Check_In'
ALTER TABLE [dbo].[Check_In]
ADD CONSTRAINT [PK_Check_In]
    PRIMARY KEY CLUSTERED ([Check_In_ID] ASC);
GO

-- Creating primary key on [Check_In_Line_ID] in table 'Check_In_Line'
ALTER TABLE [dbo].[Check_In_Line]
ADD CONSTRAINT [PK_Check_In_Line]
    PRIMARY KEY CLUSTERED ([Check_In_Line_ID] ASC);
GO

-- Creating primary key on [Check_Out_ID] in table 'Check_Out'
ALTER TABLE [dbo].[Check_Out]
ADD CONSTRAINT [PK_Check_Out]
    PRIMARY KEY CLUSTERED ([Check_Out_ID] ASC);
GO

-- Creating primary key on [Check_Out_Line_ID] in table 'Check_Out_Line'
ALTER TABLE [dbo].[Check_Out_Line]
ADD CONSTRAINT [PK_Check_Out_Line]
    PRIMARY KEY CLUSTERED ([Check_Out_Line_ID] ASC);
GO

-- Creating primary key on [City_ID] in table 'Cities'
ALTER TABLE [dbo].[Cities]
ADD CONSTRAINT [PK_Cities]
    PRIMARY KEY CLUSTERED ([City_ID] ASC);
GO

-- Creating primary key on [Combo_ID] in table 'Comboes'
ALTER TABLE [dbo].[Comboes]
ADD CONSTRAINT [PK_Comboes]
    PRIMARY KEY CLUSTERED ([Combo_ID] ASC);
GO

-- Creating primary key on [Combo_Price_ID] in table 'Combo_Price'
ALTER TABLE [dbo].[Combo_Price]
ADD CONSTRAINT [PK_Combo_Price]
    PRIMARY KEY CLUSTERED ([Combo_Price_ID] ASC);
GO

-- Creating primary key on [Combo_Type_ID] in table 'Combo_Type'
ALTER TABLE [dbo].[Combo_Type]
ADD CONSTRAINT [PK_Combo_Type]
    PRIMARY KEY CLUSTERED ([Combo_Type_ID] ASC);
GO

-- Creating primary key on [Company_Info_ID] in table 'Company_Information'
ALTER TABLE [dbo].[Company_Information]
ADD CONSTRAINT [PK_Company_Information]
    PRIMARY KEY CLUSTERED ([Company_Info_ID] ASC);
GO

-- Creating primary key on [Customer_ID] in table 'Customers'
ALTER TABLE [dbo].[Customers]
ADD CONSTRAINT [PK_Customers]
    PRIMARY KEY CLUSTERED ([Customer_ID] ASC);
GO

-- Creating primary key on [Order_ID] in table 'Customer_Order'
ALTER TABLE [dbo].[Customer_Order]
ADD CONSTRAINT [PK_Customer_Order]
    PRIMARY KEY CLUSTERED ([Order_ID] ASC);
GO

-- Creating primary key on [Customer_Order_Line_ID] in table 'Customer_Order_Line'
ALTER TABLE [dbo].[Customer_Order_Line]
ADD CONSTRAINT [PK_Customer_Order_Line]
    PRIMARY KEY CLUSTERED ([Customer_Order_Line_ID] ASC);
GO

-- Creating primary key on [Delivery_Status_ID] in table 'Delivery_Status'
ALTER TABLE [dbo].[Delivery_Status]
ADD CONSTRAINT [PK_Delivery_Status]
    PRIMARY KEY CLUSTERED ([Delivery_Status_ID] ASC);
GO

-- Creating primary key on [LineId] in table 'DeliveryLines'
ALTER TABLE [dbo].[DeliveryLines]
ADD CONSTRAINT [PK_DeliveryLines]
    PRIMARY KEY CLUSTERED ([LineId] ASC);
GO

-- Creating primary key on [OrderId] in table 'DeliveryTables'
ALTER TABLE [dbo].[DeliveryTables]
ADD CONSTRAINT [PK_DeliveryTables]
    PRIMARY KEY CLUSTERED ([OrderId] ASC);
GO

-- Creating primary key on [Employee_ID] in table 'Employees'
ALTER TABLE [dbo].[Employees]
ADD CONSTRAINT [PK_Employees]
    PRIMARY KEY CLUSTERED ([Employee_ID] ASC);
GO

-- Creating primary key on [Empployee_Attendence_ID] in table 'Employee_Attendence_Status'
ALTER TABLE [dbo].[Employee_Attendence_Status]
ADD CONSTRAINT [PK_Employee_Attendence_Status]
    PRIMARY KEY CLUSTERED ([Empployee_Attendence_ID] ASC);
GO

-- Creating primary key on [Booking_ID] in table 'Employee_Booking_Shift'
ALTER TABLE [dbo].[Employee_Booking_Shift]
ADD CONSTRAINT [PK_Employee_Booking_Shift]
    PRIMARY KEY CLUSTERED ([Booking_ID] ASC);
GO

-- Creating primary key on [Gender_ID] in table 'Employee_Gender_'
ALTER TABLE [dbo].[Employee_Gender_]
ADD CONSTRAINT [PK_Employee_Gender_]
    PRIMARY KEY CLUSTERED ([Gender_ID] ASC);
GO

-- Creating primary key on [Employee_Shift_ID] in table 'Employee_Shifts'
ALTER TABLE [dbo].[Employee_Shifts]
ADD CONSTRAINT [PK_Employee_Shifts]
    PRIMARY KEY CLUSTERED ([Employee_Shift_ID] ASC);
GO

-- Creating primary key on [ImageID] in table 'ItemsPictures'
ALTER TABLE [dbo].[ItemsPictures]
ADD CONSTRAINT [PK_ItemsPictures]
    PRIMARY KEY CLUSTERED ([ImageID] ASC);
GO

-- Creating primary key on [Menu_Item_ID] in table 'Menu_Item'
ALTER TABLE [dbo].[Menu_Item]
ADD CONSTRAINT [PK_Menu_Item]
    PRIMARY KEY CLUSTERED ([Menu_Item_ID] ASC);
GO

-- Creating primary key on [Menu_Price_ID] in table 'Menu_Item_Price'
ALTER TABLE [dbo].[Menu_Item_Price]
ADD CONSTRAINT [PK_Menu_Item_Price]
    PRIMARY KEY CLUSTERED ([Menu_Price_ID] ASC);
GO

-- Creating primary key on [Menu_Item_Type_ID] in table 'Menu_Item_Type'
ALTER TABLE [dbo].[Menu_Item_Type]
ADD CONSTRAINT [PK_Menu_Item_Type]
    PRIMARY KEY CLUSTERED ([Menu_Item_Type_ID] ASC);
GO

-- Creating primary key on [Payment_ID] in table 'Payments'
ALTER TABLE [dbo].[Payments]
ADD CONSTRAINT [PK_Payments]
    PRIMARY KEY CLUSTERED ([Payment_ID] ASC);
GO

-- Creating primary key on [Payment_Type_ID] in table 'Payment_Type'
ALTER TABLE [dbo].[Payment_Type]
ADD CONSTRAINT [PK_Payment_Type]
    PRIMARY KEY CLUSTERED ([Payment_Type_ID] ASC);
GO

-- Creating primary key on [Check_In_Line_ID] in table 'Quantities'
ALTER TABLE [dbo].[Quantities]
ADD CONSTRAINT [PK_Quantities]
    PRIMARY KEY CLUSTERED ([Check_In_Line_ID] ASC);
GO

-- Creating primary key on [Special_ID] in table 'Specials'
ALTER TABLE [dbo].[Specials]
ADD CONSTRAINT [PK_Specials]
    PRIMARY KEY CLUSTERED ([Special_ID] ASC);
GO

-- Creating primary key on [Stock_Combo_Line_ID] in table 'Stock_Combo_Line'
ALTER TABLE [dbo].[Stock_Combo_Line]
ADD CONSTRAINT [PK_Stock_Combo_Line]
    PRIMARY KEY CLUSTERED ([Stock_Combo_Line_ID] ASC);
GO

-- Creating primary key on [Stock_ID] in table 'Stock_Item'
ALTER TABLE [dbo].[Stock_Item]
ADD CONSTRAINT [PK_Stock_Item]
    PRIMARY KEY CLUSTERED ([Stock_ID] ASC);
GO

-- Creating primary key on [Stock_Order_ID] in table 'Stock_Order'
ALTER TABLE [dbo].[Stock_Order]
ADD CONSTRAINT [PK_Stock_Order]
    PRIMARY KEY CLUSTERED ([Stock_Order_ID] ASC);
GO

-- Creating primary key on [Stock_Order_Line_ID] in table 'Stock_Order_Line'
ALTER TABLE [dbo].[Stock_Order_Line]
ADD CONSTRAINT [PK_Stock_Order_Line]
    PRIMARY KEY CLUSTERED ([Stock_Order_Line_ID] ASC);
GO

-- Creating primary key on [Stock_Order_Status_ID] in table 'Stock_Order_Status'
ALTER TABLE [dbo].[Stock_Order_Status]
ADD CONSTRAINT [PK_Stock_Order_Status]
    PRIMARY KEY CLUSTERED ([Stock_Order_Status_ID] ASC);
GO

-- Creating primary key on [Stock_Price_ID] in table 'Stock_Price'
ALTER TABLE [dbo].[Stock_Price]
ADD CONSTRAINT [PK_Stock_Price]
    PRIMARY KEY CLUSTERED ([Stock_Price_ID] ASC);
GO

-- Creating primary key on [Stock_Type_ID] in table 'Stock_Type'
ALTER TABLE [dbo].[Stock_Type]
ADD CONSTRAINT [PK_Stock_Type]
    PRIMARY KEY CLUSTERED ([Stock_Type_ID] ASC);
GO

-- Creating primary key on [Write_Off_ID] in table 'Stock_Write_Off'
ALTER TABLE [dbo].[Stock_Write_Off]
ADD CONSTRAINT [PK_Stock_Write_Off]
    PRIMARY KEY CLUSTERED ([Write_Off_ID] ASC);
GO

-- Creating primary key on [Stock_WriteOff_LineID] in table 'Stock_WriteOff_Line'
ALTER TABLE [dbo].[Stock_WriteOff_Line]
ADD CONSTRAINT [PK_Stock_WriteOff_Line]
    PRIMARY KEY CLUSTERED ([Stock_WriteOff_LineID] ASC);
GO

-- Creating primary key on [Suburb_ID] in table 'Suburbs'
ALTER TABLE [dbo].[Suburbs]
ADD CONSTRAINT [PK_Suburbs]
    PRIMARY KEY CLUSTERED ([Suburb_ID] ASC);
GO

-- Creating primary key on [Supplier_ID] in table 'Suppliers'
ALTER TABLE [dbo].[Suppliers]
ADD CONSTRAINT [PK_Suppliers]
    PRIMARY KEY CLUSTERED ([Supplier_ID] ASC);
GO

-- Creating primary key on [Supplier_Contact_ID] in table 'Supplier_Contact_Details'
ALTER TABLE [dbo].[Supplier_Contact_Details]
ADD CONSTRAINT [PK_Supplier_Contact_Details]
    PRIMARY KEY CLUSTERED ([Supplier_Contact_ID] ASC);
GO

-- Creating primary key on [Supplier_Type_ID] in table 'Supplier_Type'
ALTER TABLE [dbo].[Supplier_Type]
ADD CONSTRAINT [PK_Supplier_Type]
    PRIMARY KEY CLUSTERED ([Supplier_Type_ID] ASC);
GO

-- Creating primary key on [User_ID] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [PK_Users]
    PRIMARY KEY CLUSTERED ([User_ID] ASC);
GO

-- Creating primary key on [User_Log_ID] in table 'User_Log'
ALTER TABLE [dbo].[User_Log]
ADD CONSTRAINT [PK_User_Log]
    PRIMARY KEY CLUSTERED ([User_Log_ID] ASC);
GO

-- Creating primary key on [User_Role_ID] in table 'User_Role'
ALTER TABLE [dbo].[User_Role]
ADD CONSTRAINT [PK_User_Role]
    PRIMARY KEY CLUSTERED ([User_Role_ID] ASC);
GO

-- Creating primary key on [OrderId] in table 'DeliveryOrders'
ALTER TABLE [dbo].[DeliveryOrders]
ADD CONSTRAINT [PK_DeliveryOrders]
    PRIMARY KEY CLUSTERED ([OrderId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Access_Level_ID] in table 'User_Role'
ALTER TABLE [dbo].[User_Role]
ADD CONSTRAINT [FK_User_Role_Access_level]
    FOREIGN KEY ([Access_Level_ID])
    REFERENCES [dbo].[Access_level]
        ([Access_Level_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_User_Role_Access_level'
CREATE INDEX [IX_FK_User_Role_Access_level]
ON [dbo].[User_Role]
    ([Access_Level_ID]);
GO

-- Creating foreign key on [Suburb_ID] in table 'Addresses'
ALTER TABLE [dbo].[Addresses]
ADD CONSTRAINT [FK_Address_Suburb]
    FOREIGN KEY ([Suburb_ID])
    REFERENCES [dbo].[Suburbs]
        ([Suburb_ID])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Address_Suburb'
CREATE INDEX [IX_FK_Address_Suburb]
ON [dbo].[Addresses]
    ([Suburb_ID]);
GO

-- Creating foreign key on [Supplier_ID] in table 'Addresses'
ALTER TABLE [dbo].[Addresses]
ADD CONSTRAINT [FK_Address_Supplier]
    FOREIGN KEY ([Supplier_ID])
    REFERENCES [dbo].[Suppliers]
        ([Supplier_ID])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Address_Supplier'
CREATE INDEX [IX_FK_Address_Supplier]
ON [dbo].[Addresses]
    ([Supplier_ID]);
GO

-- Creating foreign key on [Address_Type_ID] in table 'Addresses'
ALTER TABLE [dbo].[Addresses]
ADD CONSTRAINT [FK_Adress_Adress_Type]
    FOREIGN KEY ([Address_Type_ID])
    REFERENCES [dbo].[Adress_Type]
        ([Adress_Type_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Adress_Adress_Type'
CREATE INDEX [IX_FK_Adress_Adress_Type]
ON [dbo].[Addresses]
    ([Address_Type_ID]);
GO

-- Creating foreign key on [Audit_ID] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [FK_User_Audit]
    FOREIGN KEY ([Audit_ID])
    REFERENCES [dbo].[Audits]
        ([Audit_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_User_Audit'
CREATE INDEX [IX_FK_User_Audit]
ON [dbo].[Users]
    ([Audit_ID]);
GO

-- Creating foreign key on [Supplier_ID] in table 'Banking_Details'
ALTER TABLE [dbo].[Banking_Details]
ADD CONSTRAINT [FK_Banking_Details_Supplier]
    FOREIGN KEY ([Supplier_ID])
    REFERENCES [dbo].[Suppliers]
        ([Supplier_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Banking_Details_Supplier'
CREATE INDEX [IX_FK_Banking_Details_Supplier]
ON [dbo].[Banking_Details]
    ([Supplier_ID]);
GO

-- Creating foreign key on [Check_In_ID] in table 'Check_In_Line'
ALTER TABLE [dbo].[Check_In_Line]
ADD CONSTRAINT [FK_Check_In_Line_Check_In]
    FOREIGN KEY ([Check_In_ID])
    REFERENCES [dbo].[Check_In]
        ([Check_In_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Check_In_Line_Check_In'
CREATE INDEX [IX_FK_Check_In_Line_Check_In]
ON [dbo].[Check_In_Line]
    ([Check_In_ID]);
GO

-- Creating foreign key on [Stock_ID] in table 'Check_In_Line'
ALTER TABLE [dbo].[Check_In_Line]
ADD CONSTRAINT [FK_Check_In_Line_Stock_Item]
    FOREIGN KEY ([Stock_ID])
    REFERENCES [dbo].[Stock_Item]
        ([Stock_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Check_In_Line_Stock_Item'
CREATE INDEX [IX_FK_Check_In_Line_Stock_Item]
ON [dbo].[Check_In_Line]
    ([Stock_ID]);
GO

-- Creating foreign key on [Check_Out_ID] in table 'Check_Out_Line'
ALTER TABLE [dbo].[Check_Out_Line]
ADD CONSTRAINT [FK_Check_Out_Line_Check_Out]
    FOREIGN KEY ([Check_Out_ID])
    REFERENCES [dbo].[Check_Out]
        ([Check_Out_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Check_Out_Line_Check_Out'
CREATE INDEX [IX_FK_Check_Out_Line_Check_Out]
ON [dbo].[Check_Out_Line]
    ([Check_Out_ID]);
GO

-- Creating foreign key on [Stock_ID] in table 'Check_Out_Line'
ALTER TABLE [dbo].[Check_Out_Line]
ADD CONSTRAINT [FK_Check_Out_Line_Stock_Item]
    FOREIGN KEY ([Stock_ID])
    REFERENCES [dbo].[Stock_Item]
        ([Stock_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Check_Out_Line_Stock_Item'
CREATE INDEX [IX_FK_Check_Out_Line_Stock_Item]
ON [dbo].[Check_Out_Line]
    ([Stock_ID]);
GO

-- Creating foreign key on [Combo_Price_ID] in table 'Comboes'
ALTER TABLE [dbo].[Comboes]
ADD CONSTRAINT [FK_Combo_Combo_Price]
    FOREIGN KEY ([Combo_Price_ID])
    REFERENCES [dbo].[Combo_Price]
        ([Combo_Price_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Combo_Combo_Price'
CREATE INDEX [IX_FK_Combo_Combo_Price]
ON [dbo].[Comboes]
    ([Combo_Price_ID]);
GO

-- Creating foreign key on [Combo_Type_ID] in table 'Comboes'
ALTER TABLE [dbo].[Comboes]
ADD CONSTRAINT [FK_Combo_Combo_Type]
    FOREIGN KEY ([Combo_Type_ID])
    REFERENCES [dbo].[Combo_Type]
        ([Combo_Type_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Combo_Combo_Type'
CREATE INDEX [IX_FK_Combo_Combo_Type]
ON [dbo].[Comboes]
    ([Combo_Type_ID]);
GO

-- Creating foreign key on [Combo_ID] in table 'Customer_Order_Line'
ALTER TABLE [dbo].[Customer_Order_Line]
ADD CONSTRAINT [FK_Customer_Order_Line_Combo]
    FOREIGN KEY ([Combo_ID])
    REFERENCES [dbo].[Comboes]
        ([Combo_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Customer_Order_Line_Combo'
CREATE INDEX [IX_FK_Customer_Order_Line_Combo]
ON [dbo].[Customer_Order_Line]
    ([Combo_ID]);
GO

-- Creating foreign key on [Combo_Item_ID] in table 'ItemsPictures'
ALTER TABLE [dbo].[ItemsPictures]
ADD CONSTRAINT [FK_ItemsPicture_Combo]
    FOREIGN KEY ([Combo_Item_ID])
    REFERENCES [dbo].[Comboes]
        ([Combo_ID])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ItemsPicture_Combo'
CREATE INDEX [IX_FK_ItemsPicture_Combo]
ON [dbo].[ItemsPictures]
    ([Combo_Item_ID]);
GO

-- Creating foreign key on [Combo_ID] in table 'Stock_Combo_Line'
ALTER TABLE [dbo].[Stock_Combo_Line]
ADD CONSTRAINT [FK_Stock_Combo_Line_Combo]
    FOREIGN KEY ([Combo_ID])
    REFERENCES [dbo].[Comboes]
        ([Combo_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Stock_Combo_Line_Combo'
CREATE INDEX [IX_FK_Stock_Combo_Line_Combo]
ON [dbo].[Stock_Combo_Line]
    ([Combo_ID]);
GO

-- Creating foreign key on [Customer_ID] in table 'Customer_Order'
ALTER TABLE [dbo].[Customer_Order]
ADD CONSTRAINT [FK_Customer_Order_Customer]
    FOREIGN KEY ([Customer_ID])
    REFERENCES [dbo].[Customers]
        ([Customer_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Customer_Order_Customer'
CREATE INDEX [IX_FK_Customer_Order_Customer]
ON [dbo].[Customer_Order]
    ([Customer_ID]);
GO

-- Creating foreign key on [Delivery_Status_ID] in table 'Customer_Order'
ALTER TABLE [dbo].[Customer_Order]
ADD CONSTRAINT [FK_Customer_Order_Delivery_Status]
    FOREIGN KEY ([Delivery_Status_ID])
    REFERENCES [dbo].[Delivery_Status]
        ([Delivery_Status_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Customer_Order_Delivery_Status'
CREATE INDEX [IX_FK_Customer_Order_Delivery_Status]
ON [dbo].[Customer_Order]
    ([Delivery_Status_ID]);
GO

-- Creating foreign key on [Employee_ID] in table 'Customer_Order'
ALTER TABLE [dbo].[Customer_Order]
ADD CONSTRAINT [FK_Customer_Order_Employee]
    FOREIGN KEY ([Employee_ID])
    REFERENCES [dbo].[Employees]
        ([Employee_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Customer_Order_Employee'
CREATE INDEX [IX_FK_Customer_Order_Employee]
ON [dbo].[Customer_Order]
    ([Employee_ID]);
GO

-- Creating foreign key on [Customer_Order_ID] in table 'Customer_Order_Line'
ALTER TABLE [dbo].[Customer_Order_Line]
ADD CONSTRAINT [FK_Customer_Order_Line_Customer_Order]
    FOREIGN KEY ([Customer_Order_ID])
    REFERENCES [dbo].[Customer_Order]
        ([Order_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Customer_Order_Line_Customer_Order'
CREATE INDEX [IX_FK_Customer_Order_Line_Customer_Order]
ON [dbo].[Customer_Order_Line]
    ([Customer_Order_ID]);
GO

-- Creating foreign key on [Payment_ID] in table 'Customer_Order'
ALTER TABLE [dbo].[Customer_Order]
ADD CONSTRAINT [FK_Customer_Order_Payment]
    FOREIGN KEY ([Payment_ID])
    REFERENCES [dbo].[Payments]
        ([Payment_ID])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Customer_Order_Payment'
CREATE INDEX [IX_FK_Customer_Order_Payment]
ON [dbo].[Customer_Order]
    ([Payment_ID]);
GO

-- Creating foreign key on [Menu_Item_ID] in table 'Customer_Order_Line'
ALTER TABLE [dbo].[Customer_Order_Line]
ADD CONSTRAINT [FK_Customer_Order_Line_Menu_Item]
    FOREIGN KEY ([Menu_Item_ID])
    REFERENCES [dbo].[Menu_Item]
        ([Menu_Item_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Customer_Order_Line_Menu_Item'
CREATE INDEX [IX_FK_Customer_Order_Line_Menu_Item]
ON [dbo].[Customer_Order_Line]
    ([Menu_Item_ID]);
GO

-- Creating foreign key on [Stock_ID] in table 'Customer_Order_Line'
ALTER TABLE [dbo].[Customer_Order_Line]
ADD CONSTRAINT [FK_Customer_Order_Line_Stock_Item]
    FOREIGN KEY ([Stock_ID])
    REFERENCES [dbo].[Stock_Item]
        ([Stock_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Customer_Order_Line_Stock_Item'
CREATE INDEX [IX_FK_Customer_Order_Line_Stock_Item]
ON [dbo].[Customer_Order_Line]
    ([Stock_ID]);
GO

-- Creating foreign key on [orderId] in table 'DeliveryLines'
ALTER TABLE [dbo].[DeliveryLines]
ADD CONSTRAINT [FK_DeliveryLine_DeliveryTable]
    FOREIGN KEY ([orderId])
    REFERENCES [dbo].[DeliveryTables]
        ([OrderId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DeliveryLine_DeliveryTable'
CREATE INDEX [IX_FK_DeliveryLine_DeliveryTable]
ON [dbo].[DeliveryLines]
    ([orderId]);
GO

-- Creating foreign key on [Employee_ID] in table 'Employee_Booking_Shift'
ALTER TABLE [dbo].[Employee_Booking_Shift]
ADD CONSTRAINT [FK_Employee_Booking_Shift_Employee]
    FOREIGN KEY ([Employee_ID])
    REFERENCES [dbo].[Employees]
        ([Employee_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Employee_Booking_Shift_Employee'
CREATE INDEX [IX_FK_Employee_Booking_Shift_Employee]
ON [dbo].[Employee_Booking_Shift]
    ([Employee_ID]);
GO

-- Creating foreign key on [Gender_ID] in table 'Employees'
ALTER TABLE [dbo].[Employees]
ADD CONSTRAINT [FK_Employee_Employee_Gender_]
    FOREIGN KEY ([Gender_ID])
    REFERENCES [dbo].[Employee_Gender_]
        ([Gender_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Employee_Employee_Gender_'
CREATE INDEX [IX_FK_Employee_Employee_Gender_]
ON [dbo].[Employees]
    ([Gender_ID]);
GO

-- Creating foreign key on [User_ID] in table 'Employees'
ALTER TABLE [dbo].[Employees]
ADD CONSTRAINT [FK_Employee_User]
    FOREIGN KEY ([User_ID])
    REFERENCES [dbo].[Users]
        ([User_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Employee_User'
CREATE INDEX [IX_FK_Employee_User]
ON [dbo].[Employees]
    ([User_ID]);
GO

-- Creating foreign key on [Employee_ID] in table 'Stock_Order'
ALTER TABLE [dbo].[Stock_Order]
ADD CONSTRAINT [FK_Stock_Order_Employee]
    FOREIGN KEY ([Employee_ID])
    REFERENCES [dbo].[Employees]
        ([Employee_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Stock_Order_Employee'
CREATE INDEX [IX_FK_Stock_Order_Employee]
ON [dbo].[Stock_Order]
    ([Employee_ID]);
GO

-- Creating foreign key on [Booking_ID] in table 'Employee_Attendence_Status'
ALTER TABLE [dbo].[Employee_Attendence_Status]
ADD CONSTRAINT [FK_Employee_Attendence_Status_Employee_Booking_Shift]
    FOREIGN KEY ([Booking_ID])
    REFERENCES [dbo].[Employee_Booking_Shift]
        ([Booking_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Employee_Attendence_Status_Employee_Booking_Shift'
CREATE INDEX [IX_FK_Employee_Attendence_Status_Employee_Booking_Shift]
ON [dbo].[Employee_Attendence_Status]
    ([Booking_ID]);
GO

-- Creating foreign key on [Employee_Shift_ID] in table 'Employee_Booking_Shift'
ALTER TABLE [dbo].[Employee_Booking_Shift]
ADD CONSTRAINT [FK_Employee_Booking_Shift_Employee_Shifts]
    FOREIGN KEY ([Employee_Shift_ID])
    REFERENCES [dbo].[Employee_Shifts]
        ([Employee_Shift_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Employee_Booking_Shift_Employee_Shifts'
CREATE INDEX [IX_FK_Employee_Booking_Shift_Employee_Shifts]
ON [dbo].[Employee_Booking_Shift]
    ([Employee_Shift_ID]);
GO

-- Creating foreign key on [Menu_Item_ID] in table 'ItemsPictures'
ALTER TABLE [dbo].[ItemsPictures]
ADD CONSTRAINT [FK_ItemsPicture_Menu_Item]
    FOREIGN KEY ([Menu_Item_ID])
    REFERENCES [dbo].[Menu_Item]
        ([Menu_Item_ID])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ItemsPicture_Menu_Item'
CREATE INDEX [IX_FK_ItemsPicture_Menu_Item]
ON [dbo].[ItemsPictures]
    ([Menu_Item_ID]);
GO

-- Creating foreign key on [Menu_Price_ID] in table 'Menu_Item'
ALTER TABLE [dbo].[Menu_Item]
ADD CONSTRAINT [FK_Menu_Item_Menu_Item_Price]
    FOREIGN KEY ([Menu_Price_ID])
    REFERENCES [dbo].[Menu_Item_Price]
        ([Menu_Price_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Menu_Item_Menu_Item_Price'
CREATE INDEX [IX_FK_Menu_Item_Menu_Item_Price]
ON [dbo].[Menu_Item]
    ([Menu_Price_ID]);
GO

-- Creating foreign key on [Menu_Item_Type_ID] in table 'Menu_Item'
ALTER TABLE [dbo].[Menu_Item]
ADD CONSTRAINT [FK_Menu_Item_Menu_Item_Type]
    FOREIGN KEY ([Menu_Item_Type_ID])
    REFERENCES [dbo].[Menu_Item_Type]
        ([Menu_Item_Type_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Menu_Item_Menu_Item_Type'
CREATE INDEX [IX_FK_Menu_Item_Menu_Item_Type]
ON [dbo].[Menu_Item]
    ([Menu_Item_Type_ID]);
GO

-- Creating foreign key on [Payment_Type_ID] in table 'Payments'
ALTER TABLE [dbo].[Payments]
ADD CONSTRAINT [FK_Payment_Payment_Type]
    FOREIGN KEY ([Payment_Type_ID])
    REFERENCES [dbo].[Payment_Type]
        ([Payment_Type_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Payment_Payment_Type'
CREATE INDEX [IX_FK_Payment_Payment_Type]
ON [dbo].[Payments]
    ([Payment_Type_ID]);
GO

-- Creating foreign key on [Stock_ID] in table 'Stock_Combo_Line'
ALTER TABLE [dbo].[Stock_Combo_Line]
ADD CONSTRAINT [FK_Stock_Combo_Line_Stock_Item]
    FOREIGN KEY ([Stock_ID])
    REFERENCES [dbo].[Stock_Item]
        ([Stock_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Stock_Combo_Line_Stock_Item'
CREATE INDEX [IX_FK_Stock_Combo_Line_Stock_Item]
ON [dbo].[Stock_Combo_Line]
    ([Stock_ID]);
GO

-- Creating foreign key on [Stock_Price_ID] in table 'Stock_Item'
ALTER TABLE [dbo].[Stock_Item]
ADD CONSTRAINT [FK_Stock_Item_Stock_Price]
    FOREIGN KEY ([Stock_Price_ID])
    REFERENCES [dbo].[Stock_Price]
        ([Stock_Price_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Stock_Item_Stock_Price'
CREATE INDEX [IX_FK_Stock_Item_Stock_Price]
ON [dbo].[Stock_Item]
    ([Stock_Price_ID]);
GO

-- Creating foreign key on [Stock_Type_ID] in table 'Stock_Item'
ALTER TABLE [dbo].[Stock_Item]
ADD CONSTRAINT [FK_Stock_Item_Stock_Type]
    FOREIGN KEY ([Stock_Type_ID])
    REFERENCES [dbo].[Stock_Type]
        ([Stock_Type_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Stock_Item_Stock_Type'
CREATE INDEX [IX_FK_Stock_Item_Stock_Type]
ON [dbo].[Stock_Item]
    ([Stock_Type_ID]);
GO

-- Creating foreign key on [Stock_ID] in table 'Stock_Order_Line'
ALTER TABLE [dbo].[Stock_Order_Line]
ADD CONSTRAINT [FK_Stock_Order_Line_Stock_Item]
    FOREIGN KEY ([Stock_ID])
    REFERENCES [dbo].[Stock_Item]
        ([Stock_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Stock_Order_Line_Stock_Item'
CREATE INDEX [IX_FK_Stock_Order_Line_Stock_Item]
ON [dbo].[Stock_Order_Line]
    ([Stock_ID]);
GO

-- Creating foreign key on [Stock_ID] in table 'Stock_WriteOff_Line'
ALTER TABLE [dbo].[Stock_WriteOff_Line]
ADD CONSTRAINT [FK_Stock_WriteOff_Line_Stock_Item]
    FOREIGN KEY ([Stock_ID])
    REFERENCES [dbo].[Stock_Item]
        ([Stock_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Stock_WriteOff_Line_Stock_Item'
CREATE INDEX [IX_FK_Stock_WriteOff_Line_Stock_Item]
ON [dbo].[Stock_WriteOff_Line]
    ([Stock_ID]);
GO

-- Creating foreign key on [Stock_Order_ID] in table 'Stock_Order_Line'
ALTER TABLE [dbo].[Stock_Order_Line]
ADD CONSTRAINT [FK_Stock_Order_Line_Stock_Order]
    FOREIGN KEY ([Stock_Order_ID])
    REFERENCES [dbo].[Stock_Order]
        ([Stock_Order_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Stock_Order_Line_Stock_Order'
CREATE INDEX [IX_FK_Stock_Order_Line_Stock_Order]
ON [dbo].[Stock_Order_Line]
    ([Stock_Order_ID]);
GO

-- Creating foreign key on [Stock_Order_Status_ID] in table 'Stock_Order'
ALTER TABLE [dbo].[Stock_Order]
ADD CONSTRAINT [FK_Stock_Order_Stock_Order_Status]
    FOREIGN KEY ([Stock_Order_Status_ID])
    REFERENCES [dbo].[Stock_Order_Status]
        ([Stock_Order_Status_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Stock_Order_Stock_Order_Status'
CREATE INDEX [IX_FK_Stock_Order_Stock_Order_Status]
ON [dbo].[Stock_Order]
    ([Stock_Order_Status_ID]);
GO

-- Creating foreign key on [Supplier_ID] in table 'Stock_Order'
ALTER TABLE [dbo].[Stock_Order]
ADD CONSTRAINT [FK_Stock_Order_Supplier]
    FOREIGN KEY ([Supplier_ID])
    REFERENCES [dbo].[Suppliers]
        ([Supplier_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Stock_Order_Supplier'
CREATE INDEX [IX_FK_Stock_Order_Supplier]
ON [dbo].[Stock_Order]
    ([Supplier_ID]);
GO

-- Creating foreign key on [Write_Off_ID] in table 'Stock_WriteOff_Line'
ALTER TABLE [dbo].[Stock_WriteOff_Line]
ADD CONSTRAINT [FK_Stock_WriteOff_Line_Stock_Write_Off]
    FOREIGN KEY ([Write_Off_ID])
    REFERENCES [dbo].[Stock_Write_Off]
        ([Write_Off_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Stock_WriteOff_Line_Stock_Write_Off'
CREATE INDEX [IX_FK_Stock_WriteOff_Line_Stock_Write_Off]
ON [dbo].[Stock_WriteOff_Line]
    ([Write_Off_ID]);
GO

-- Creating foreign key on [Supplier_ID] in table 'Supplier_Contact_Details'
ALTER TABLE [dbo].[Supplier_Contact_Details]
ADD CONSTRAINT [FK_Supplier_Contact_Details_Supplier]
    FOREIGN KEY ([Supplier_ID])
    REFERENCES [dbo].[Suppliers]
        ([Supplier_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Supplier_Contact_Details_Supplier'
CREATE INDEX [IX_FK_Supplier_Contact_Details_Supplier]
ON [dbo].[Supplier_Contact_Details]
    ([Supplier_ID]);
GO

-- Creating foreign key on [User_Role_ID] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [FK_User_Us]
    FOREIGN KEY ([User_Role_ID])
    REFERENCES [dbo].[User_Role]
        ([User_Role_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_User_Us'
CREATE INDEX [IX_FK_User_Us]
ON [dbo].[Users]
    ([User_Role_ID]);
GO

-- Creating foreign key on [User_Log_ID] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [FK_User_User_Log]
    FOREIGN KEY ([User_Log_ID])
    REFERENCES [dbo].[User_Log]
        ([User_Log_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_User_User_Log'
CREATE INDEX [IX_FK_User_User_Log]
ON [dbo].[Users]
    ([User_Log_ID]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------