# OData Web API

Inspired by Microsoft docs:

* https://learn.microsoft.com/en-us/odata/webapi-8/getting-started?tabs=net60%2Cvisual-studio-2022%2Cvisual-studio
* https://learn.microsoft.com/en-us/odata/concepts/queryoptions-overview
* https://learn.microsoft.com/en-us/odata/client/getting-started
* https://www.jacobmohl.dk/how-to-add-odata-parameters-to-your-aspnet-core-api
* https://learn.microsoft.com/en-us/odata/webapi-8/fundamentals/actions-functions
* https://learn.microsoft.com/en-us/odata/webapi-8/fundamentals/action-routing?tabs=net60%2Cvisual-studio
* https://learn.microsoft.com/en-us/odata/webapi-8/fundamentals/metadata-routing?tabs=net60%2Cvisual-studio

Example OData Queries:

* http://localhost:5252/odata/Articles?$filter=ItemNumber%20eq%20%27Article%201%27
* http://localhost:5252/odata/Articles?$expand=Orders
* http://localhost:5252/odata/Customers/Default.SayHello(message='Otto')
* http://localhost:5252/odata/Customers(1)/Default.SayHello2(message='otto')