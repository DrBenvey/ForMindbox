/****** Script for Create product table  ******/
CREATE TABLE [dbo].[product](
[id] [int] PRIMARY KEY IDENTITY(1,1) NOT NULL,
[product_name] [nvarchar](max) not NULL);
/****** Script for Fill product table  ******/
INSERT INTO [dbo].[product] (product_name)
VALUES ('notebook'),('pen'),('washcloth'),('product without category 1'),('product without category 2');
/****** Script for Create category table  ******/
CREATE TABLE [dbo].[category](
[id] [int] PRIMARY KEY IDENTITY(1,1) NOT NULL,
[category_name] [nvarchar](max) not NULL);
/****** Script for Fill category table  ******/
INSERT INTO [dbo].[category] (category_name)
VALUES ('hygiene'),('studies'),('office'),('category without product 1');
/****** Script for Create index_product_category table  ******/
CREATE TABLE [dbo].[index_product_category](
[id] [int] PRIMARY KEY IDENTITY(1,1) NOT NULL,
[product_id] [int] NULL,
[category_id] [int] NULL,
FOREIGN KEY (product_id)  REFERENCES product (id),
FOREIGN KEY (category_id)  REFERENCES category (id));
/****** Script for Filling index_product_category table  ******/
INSERT INTO [dbo].[index_product_category] (product_id,category_id)
VALUES (1,2),(2,2),(1,3),(2,3),(3,1),(4,NULL),(5,NULL),(NULL,4);
/****** Script for Get product_name - category_name pairs ******/
SELECT p.product_name,c.category_name from [dbo].[product] p
INNER JOIN [dbo].[index_product_category] ipc ON p.id=ipc.product_id
LEFT JOIN [dbo].[category] c ON c.id=ipc.category_id;
