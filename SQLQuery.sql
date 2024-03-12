CREATE DATABASE Dami ;

CREATE TABLE [dbo].[SL_tblCustomerList] 
( 
 [CustomerID] [varchar](20) NOT NULL, --Mã khách hàng 
 [CustomerName] [nvarchar](250) NOT NULL, --Tên khách hàng 
 [TaxCode] [varchar](20) NULL, -- Mã số thuế 
 [IsCustomer] [bit] NOT NULL, -- Là khách hàng 
 [IsVendor] [bit] NOT NULL, -- Là nhà cung cấp 
 [IsPersonal] [bit] NOT NULL, -- Là cá nhân 
 [Mobile] [varchar](40) NULL, -- Điện thoại 
 [Email] [varchar](80) NULL, -- Email 
 [Address] [nvarchar](250) NULL, -- Địa chỉ 
 [ContactPerson] [nvarchar](60) NULL, -- Người liên hệ 
 [DebtLimit] [money] NOT NULL, -- Giới hạn số tiền nợ cho phép 
 [NumberDayLimit] [int] NOT NULL, -- Giới hạn số ngày nợ cho phép 
 Primary Key ([CustomerID]) 
) ;