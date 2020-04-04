<h1>RetailManagementTool</h1>

<h2>Description</h2>

<p>My goal was to create an MVC application for retail stores to be able to manage their products, as it relates to promotions and zone allocations. The target audience would be retail stores of any kind. This application could be used by, both, home office and associates on the sales floor. As someone who has worked in the retail industry, I realize how important it is to get information to customer-facing associates in as quick and user-friendly a manner as possible.</p>

<h2>Database</h2>

<h4>Product</h4>
<ul>
Id [pk]
Department int [Foreign Key of Department Id]
SKU string
Style string
Color string
Size int [Foreign Key of Size Id]
Name string
TicketPrice decimal
SalePrice decimal
Promotion int [Foreign Key of Promotion Id]
ZoneLocation int [Foreign Key of Zone Id]
</ul>

<h4>Department</h4>
Id int [pk]
Name string
Promotion int [Foreign Key of Promotion Id]
List<Product> DepartmentProducts

<h4>Zone</h4>
Id int [pk]
Name string

<h4>Promotion</h4>
Id int [pk]
Description string

<h4>Role</h4>
Id int [pk]
Name string
UserId int

<h4>Size</h4>
Id int [pk]
Name string



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

<h2>Acknowledgements</h2>

<h4>User Roles</h4>
https://www.c-sharpcorner.com/UploadFile/asmabegam/Asp-Net-mvc-5-security-and-creating-user-role/

<h4>Seeding</h4>
https://stackoverflow.com/questions/51819260/seeding-data-in-startup-cs
