CREATE TABLE Categories (
    Id INT PRIMARY KEY,
    Name VARCHAR(50)
);

CREATE TABLE Products (
    Id INT PRIMARY KEY,
    Name VARCHAR(50)
);

CREATE TABLE ProductsCategories (
    ProductId INT NOT NULL,
    CategoryId INT NOT NULL,
    PRIMARY KEY (ProductId, CategoryId),
    FOREIGN KEY (ProductId) REFERENCES Products(Id),
    FOREIGN KEY (CategoryId) REFERENCES Categories(Id)
);

INSERT INTO Categories (Id, Name) VALUES
    (1, 'Category 1'),
    (2, 'Category 2'),
    (3, 'Category 3');

INSERT INTO Products (Id, Name) VALUES
    (1, 'Product 1'),
    (2, 'Product 2'),
    (3, 'Product 3'),
    (4, 'Product 4');

INSERT INTO ProductsCategories (ProductId, CategoryId) VALUES
    (1, 1),
    (1, 2),
    (2, 2),
    (3, 3);

SELECT P.name as ProductName, C.name as CategoryName
FROM Products P
LEFT JOIN ProductsCategories PC ON P.Id = PC.ProductId
LEFT JOIN Categories C ON PC.CategoryId = C.Id