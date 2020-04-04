
RetailManagementTool


Aaron Barchet
Table of Contents

Table of Contents
Mission Statement
Database
Features
Trello Link
Wireframe
Schedule
Final Notes



Mission Statement
My goal is to create an application for retail stores to be able to manage their products, as it relates to promotions and zone allocations. The target audience would be retail stores of any kind. This application could be used by, both, home office and associates on the sales floor. As someone who has worked in the retail industry, I realize how important it is to get information to customer-facing associates in as quick and user-friendly a manner as possible.
Database
This is where your team writes out how your database will look like. List out each table, the columns (include the dataTypes), and the database associations your project will have on the server-side.

Product
Id [pk]
Department int [Foreign Key of Department Id]
SKU int
Style int
Color int
Size enum
Name string
TicketPrice decimal
SalePrice decimal
Promotion int [Foreign Key of Promotion Id]
ZoneLocation int [Foreign Key of Zone Id]


Department
Id int [pk]
Name string
Promotion int [Foreign Key of Promotion Id]

Zone
Id int [pk]
Name string

Promotion
Id int [pk]
Description string

Role
Id int [pk]
Name string
UserId int

       [MinLength(2, ErrorMessage = "Name must be at least 2 characters long.")]
        [MaxLength(50, ErrorMessage = "There are too many characters in this field.")]



Optional:


Endpoints

FUNCTIONALITY I WOULD LIKE TO ACCOMPLISH:

1.	Full CRUD for Product, Department, Promotion, Zone, Role)
2.	Get all products 
3.	Get product by Id
4.	Get all products by Department #
5.	Get all products by Zone #
6.	Get all products by Promotion
7.	Edit product by Id
8.	Edit multiple products' promotion by Department #
