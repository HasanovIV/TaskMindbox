Use AdventureWorks2012

SELECT Product.Name AS [Name product], ProductCategory.Name AS [Name category]
FROM Production.Product AS Product
LEFT JOIN Production.ProductCategory AS ProductCategory
ON Product.ProductSubcategoryID = ProductCategory.ProductCategoryID

