# CMPG323-Project3-35689765

# EcoPower Logistics

The EcoPower Logistics Project is aimed at (Create,Read,Update,Delete) RESTful API that connects a database, helping in storing logistics data.The API works as a backend system that manages information related to customers,orders and more.

# Features

- Create:Allows for the adding of new data to the database.
- Read:Receives data from the database.
- Update:Allows for the changing of exisiting data in the database.
- Delete:Allows for the removal of selected data in the database.

# How StakeHolders Are To Use The Report That Is Developed

Stakeholders can use the EcoPower Logistics API for numerous purposes like:
- For mananging data,they can create,read,update and delete data using the API.
- Reports can be generated from using the data in the database.
- Intergrating the API with other existing systems and applications for logistics processing 
- Testing and developing of logistics related features and applications.
  
# The List of Endpoints to be Implemented

Customers Resource:

- GET /api/customers: Get a list of all customers.
- GET /api/customers/{id}: Get details of a specific customer by ID.
- POST /api/customers: Create a new customer.
- PUT /api/customers/{id}: Update an existing customer by ID.
- DELETE /api/customers/{id}: Delete a customer by ID.

Products Resource:

- GET /api/products: Get a list of all products.
- GET /api/products/{id}: Get details of a specific product by ID.
- POST /api/products: Create a new product.
- PUT /api/products/{id}: Update an existing product by ID.
- DELETE /api/products/{id}: Delete a product by ID.

Orders Resource:

- GET /api/orders: Get a list of all orders.
- GET /api/orders/{id}: Get details of a specific order by ID.
- POST /api/orders: Create a new order.
- PUT /api/orders/{id}: Update an existing order by ID.
- DELETE /api/orders/{id}: Delete an order by ID.

#Reference List

ChatGpt.2023.How to create a connection string for Azure SQL Database.https://chat.openai.com/c/5dd23d.Date of access: 30 Aug.2023.

Serkan Seker.2022.ASP.NET Core Web API Entity Framework Scaffolding.https://www.serkanseker.com/asp-net-core-web-api-entity-framework-scaffolding/.Date of access:30 Aug.2023.

ChatGpt.2023.Entity Framework Scaffold Command Error.https://chat.openai.com/c/5dd23d.Date of access:30 Aug.2023.

stackOverflow.2020.Unable to find provider assembly with name Microsoft.EntityFrameworkCore.SqlLite [duplicate].https://stackoverflow.com/questions/54657656/unable-to-find-provider-assembly-with-name-microsoft-entityframeworkcore-sqllite.Date of access:30 Aug.2023.

stackOverflow.2023.NET Core 6 : to protect potentially sensitive information in your connection string.https://stackoverflow.com/questions/75439434/net-core-6-to-protect-potentially-sensitive-information-in-your-connection-st.Date of access:30 Aug.2023.

