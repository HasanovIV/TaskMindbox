SELECT Product.Name AS [Name product], MatchingCategory.Name AS [Name category]
FROM Production.Product AS Product
LEFT JOIN 
	
	(SELECT ProductCategory.Name as Name, MatchingCategory.ProductID as ProductID
	FROM Production.MatchingCategory AS MatchingCategory
	INNER JOIN Production.ProductCategory AS ProductCategory
	ON MatchingCategory.ProductSubcategoryID = ProductCategory.ProductCategoryID) AS MatchingCategory

ON Product.ID = MatchingCategory.ProductID